namespace Employee_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowAllWithImages = new System.Windows.Forms.Button();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnFound = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pctEmpolyeeImage = new System.Windows.Forms.PictureBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.labTime = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctEmpolyeeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.labTime);
            this.panel1.Controls.Add(this.btnShowAllWithImages);
            this.panel1.Controls.Add(this.btnSelectImage);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnShowAll);
            this.panel1.Controls.Add(this.btnFound);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.pctEmpolyeeImage);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 623);
            this.panel1.TabIndex = 0;
            // 
            // btnShowAllWithImages
            // 
            this.btnShowAllWithImages.BackColor = System.Drawing.Color.SteelBlue;
            this.btnShowAllWithImages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAllWithImages.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowAllWithImages.ForeColor = System.Drawing.Color.White;
            this.btnShowAllWithImages.Location = new System.Drawing.Point(30, 416);
            this.btnShowAllWithImages.Name = "btnShowAllWithImages";
            this.btnShowAllWithImages.Size = new System.Drawing.Size(836, 60);
            this.btnShowAllWithImages.TabIndex = 13;
            this.btnShowAllWithImages.Text = "Show All With Images";
            this.btnShowAllWithImages.UseVisualStyleBackColor = false;
            this.btnShowAllWithImages.Click += new System.EventHandler(this.BtnShowAllWithImages_Click);
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSelectImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectImage.ForeColor = System.Drawing.Color.White;
            this.btnSelectImage.Location = new System.Drawing.Point(926, 498);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(304, 60);
            this.btnSelectImage.TabIndex = 12;
            this.btnSelectImage.Text = "Select Image";
            this.btnSelectImage.UseVisualStyleBackColor = false;
            this.btnSelectImage.Click += new System.EventHandler(this.BtnSelectImage_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(680, 498);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(186, 60);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.SteelBlue;
            this.btnShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(459, 498);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(196, 60);
            this.btnShowAll.TabIndex = 10;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.BtnShowAll_Click);
            // 
            // btnFound
            // 
            this.btnFound.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFound.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFound.ForeColor = System.Drawing.Color.White;
            this.btnFound.Location = new System.Drawing.Point(245, 498);
            this.btnFound.Name = "btnFound";
            this.btnFound.Size = new System.Drawing.Size(186, 60);
            this.btnFound.TabIndex = 9;
            this.btnFound.Text = "Found";
            this.btnFound.UseVisualStyleBackColor = false;
            this.btnFound.Click += new System.EventHandler(this.BtnFound_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(30, 498);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnSave.Size = new System.Drawing.Size(186, 60);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // pctEmpolyeeImage
            // 
            this.pctEmpolyeeImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctEmpolyeeImage.Location = new System.Drawing.Point(926, 162);
            this.pctEmpolyeeImage.Name = "pctEmpolyeeImage";
            this.pctEmpolyeeImage.Size = new System.Drawing.Size(304, 314);
            this.pctEmpolyeeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctEmpolyeeImage.TabIndex = 7;
            this.pctEmpolyeeImage.TabStop = false;
            this.pctEmpolyeeImage.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(225, 309);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(641, 48);
            this.txtAddress.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 49);
            this.label4.TabIndex = 5;
            this.label4.Text = "Address:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(225, 235);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(641, 48);
            this.txtName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 49);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(225, 162);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(641, 48);
            this.txtID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(417, 23);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(7, 13, 7, 13);
            this.label1.Size = new System.Drawing.Size(449, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Information";
            // 
            // myTimer
            // 
            this.myTimer.Enabled = true;
            this.myTimer.Interval = 1000;
            this.myTimer.Tick += new System.EventHandler(this.MyTimer_Tick);
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.ForeColor = System.Drawing.Color.SteelBlue;
            this.labTime.Location = new System.Drawing.Point(945, 58);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(0, 40);
            this.labTime.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1286, 647);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Employee System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctEmpolyeeImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctEmpolyeeImage;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnFound;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShowAllWithImages;
        private System.Windows.Forms.Timer myTimer;
        private System.Windows.Forms.Label labTime;
    }
}

