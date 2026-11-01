using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Employee_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Regex regexID = new Regex("^\\d{3}$");
                Regex regexName = new Regex(@"^[a-zA-Z]+( [a-zA-z]+)*$");

                if (String.IsNullOrWhiteSpace(txtID.Text))
                {
                    MessageBox.Show("Please Enter The ID", "Empty ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!regexID.IsMatch(txtID.Text.Trim()))
                {
                    MessageBox.Show("Please Enter ID With Three Digits Number", "Invalide ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (String.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Please Enter The Name", "Empty Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!regexName.IsMatch(txtName.Text.Trim()))
                {
                    MessageBox.Show("Please Enter Name With only Letters", "Invalide ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (String.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    MessageBox.Show("Please Enter The Address", "Empty Address", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                const string FileName = "Empolyee Information.txt";
                if (File.Exists(FileName))
                {
                    using (StreamReader reader = new StreamReader(FileName))
                    {
                        string lineFromFile;
                        while ((lineFromFile = reader.ReadLine()) != null)
                        {
                            string[] Info = lineFromFile.Split('|');
                            if (Info.Length > 0 && txtID.Text == Info[0])
                            {
                                MessageBox.Show("This ID Alearedy Exists! Please Try Again", "Exist ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtID.Focus();
                                txtID.SelectAll();
                                return;
                            }
                        }
                    }
                }
                using (StreamWriter writer = new StreamWriter(FileName, true))
                {
                    string line = txtID.Text + "|" + txtName.Text + "|" + txtAddress.Text;
                    writer.WriteLine(line, FileName);

                    if (!Directory.Exists("images"))
                    {
                        Directory.CreateDirectory("images");
                    }
                    pctEmpolyeeImage.Image.Save("images/" + txtID.Text + ".jpg");
                }

                MessageBox.Show("Employee Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtID.Text = "";
                txtID.Focus();
                txtName.Text = "";
                txtAddress.Text = "";
                pctEmpolyeeImage.Image = new PictureBox().Image;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                const string FileName = "Empolyee Information.txt";
                if (File.Exists(FileName))
                {
                    All_Employee_Information all_Employee = new All_Employee_Information();
                    all_Employee.Show();
                }
                else
                {
                    MessageBox.Show("Don't Found The File", "File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnFound_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtID.Text))
                {
                    MessageBox.Show("Please Enter The ID", "Empty ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                const string FileName = "Empolyee Information.txt";

                using (StreamReader reader = new StreamReader(FileName))
                {
                    string lineFromFile;
                    while ((lineFromFile = reader.ReadLine()) != null)
                    {
                        string[] Info = lineFromFile.Split('|');
                        if (Info.Length > 0 && txtID.Text == Info[0])
                        {
                            txtID.Text = Info[0];
                            txtName.Text = Info[1];
                            txtAddress.Text = Info[2];
                            string imagePath = "images/" + Info[0] + ".jpg";
                            if (File.Exists(imagePath))
                            {
                                pctEmpolyeeImage.Image = Image.FromFile(imagePath);
                            }
                            else
                            {
                                MessageBox.Show("Can Not Find This Image", "Didn't Found Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            return;
                        }
                    }
                    MessageBox.Show("Can Not Find This ID", "Didn't Found ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void BtnSelectImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.InitialDirectory = "C:\\Users\\Elite\\Desktop\\images";
                openFile.Title = "Select A Photo";
                openFile.Filter = "Images|*.jpg;*.png";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    pctEmpolyeeImage.Image = Image.FromFile(openFile.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnShowAllWithImages_Click(object sender, EventArgs e)
        {
            Form AllInfoWithImages = new Form();
            AllInfoWithImages.AutoScroll = true;
            AllInfoWithImages.Text = "All Information with Images ";
            AllInfoWithImages.StartPosition = FormStartPosition.CenterScreen;
            AllInfoWithImages.Font = this.Font;
            AllInfoWithImages.Size = this.Size;

           
            try
            {
                string FileName = "Empolyee Information.txt";
                StreamReader reader = new StreamReader(FileName);
                string line = "";
                int myTop = 0;

                do
                {
                    line = reader.ReadLine();
                    if(line != null)
                    {
                       

                        PictureBox picture = new PictureBox();
                        picture.Left = 10;
                        picture.Size = new Size(250, 150);
                        picture.Top = myTop;
                        picture.BorderStyle = BorderStyle.FixedSingle;
                        picture.SizeMode = PictureBoxSizeMode.StretchImage;

                        TextBox txtInfo = new TextBox();
                        txtInfo.Left = 10;
                        txtInfo.Width = 250;
                        txtInfo.Top = myTop+150;
                        txtInfo.Text = line;

                        string imagePath = "images/" + line.Split('|')[0].Trim() + ".jpg";
                        if (File.Exists(imagePath))
                            picture.Image = Image.FromFile(imagePath);
                        


                        AllInfoWithImages.Controls.Add(picture);
                        AllInfoWithImages.Controls.Add(txtInfo);

                        myTop += 200;
                    }

                } while (line != null);

                reader.Close();
                AllInfoWithImages.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString();
        }
    }
}
