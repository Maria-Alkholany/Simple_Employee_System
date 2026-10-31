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

namespace Employee_System
{
    public partial class All_Employee_Information : Form
    {
        public All_Employee_Information()
        {
            InitializeComponent();
        }

        private void All_Employee_Information_Load(object sender, EventArgs e)
        {
            try
            {
                dgvEmployees.Columns.Clear();
                dgvEmployees.Columns.Add("ID", "Eployee ID");
                dgvEmployees.Columns.Add("Name", "Eployee Name");
                dgvEmployees.Columns.Add("Address", "Eployee Address");

                const string FileName = "Empolyee Information.txt";

                using (StreamReader reader = new StreamReader(FileName))
                {
                    string lineFromFile;
                    while ((lineFromFile = reader.ReadLine()) != null)
                    {
                        string[] Info = lineFromFile.Split('|');
                        dgvEmployees.Rows.Add(Info[0], Info[1], Info[2]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
