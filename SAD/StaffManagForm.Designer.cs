namespace WindowsFormsApp4
{
    partial class Staff_Manag_Form
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
            this.staffLineUpBut = new System.Windows.Forms.Button();
            this.supervisorLineUpBut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttViewArchive = new System.Windows.Forms.Button();
            this.buttEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtReligion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCivilStatus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.txtMn = new System.Windows.Forms.TextBox();
            this.txtLn = new System.Windows.Forms.TextBox();
            this.txtFn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttAdd = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // staffLineUpBut
            // 
            this.staffLineUpBut.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffLineUpBut.Location = new System.Drawing.Point(300, 1200);
            this.staffLineUpBut.Name = "staffLineUpBut";
            this.staffLineUpBut.Size = new System.Drawing.Size(345, 79);
            this.staffLineUpBut.TabIndex = 2;
            this.staffLineUpBut.Text = "Staff lineup";
            this.staffLineUpBut.UseVisualStyleBackColor = true;
            this.staffLineUpBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // supervisorLineUpBut
            // 
            this.supervisorLineUpBut.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supervisorLineUpBut.Location = new System.Drawing.Point(1602, 1200);
            this.supervisorLineUpBut.Name = "supervisorLineUpBut";
            this.supervisorLineUpBut.Size = new System.Drawing.Size(345, 79);
            this.supervisorLineUpBut.TabIndex = 2;
            this.supervisorLineUpBut.Text = "sa";
            this.supervisorLineUpBut.UseVisualStyleBackColor = true;
            this.supervisorLineUpBut.Click += new System.EventHandler(this.supervisorLineUpBut_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(2321, 611);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.ColumnRemoved += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnRemoved);
            // 
            // buttViewArchive
            // 
            this.buttViewArchive.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttViewArchive.Location = new System.Drawing.Point(14, 368);
            this.buttViewArchive.Name = "buttViewArchive";
            this.buttViewArchive.Size = new System.Drawing.Size(345, 79);
            this.buttViewArchive.TabIndex = 4;
            this.buttViewArchive.Text = "View Archive";
            this.buttViewArchive.UseVisualStyleBackColor = true;
            // 
            // buttEdit
            // 
            this.buttEdit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttEdit.Location = new System.Drawing.Point(14, 273);
            this.buttEdit.Name = "buttEdit";
            this.buttEdit.Size = new System.Drawing.Size(345, 79);
            this.buttEdit.TabIndex = 3;
            this.buttEdit.Text = "Edit";
            this.buttEdit.UseVisualStyleBackColor = true;
            this.buttEdit.Click += new System.EventHandler(this.buttEdit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtStatus);
            this.panel1.Controls.Add(this.txtReligion);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtCivilStatus);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtNationality);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblAge);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.txtGender);
            this.panel1.Controls.Add(this.txtBirthDate);
            this.panel1.Controls.Add(this.txtMn);
            this.panel1.Controls.Add(this.txtLn);
            this.panel1.Controls.Add(this.txtFn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttAdd);
            this.panel1.Controls.Add(this.buttEdit);
            this.panel1.Controls.Add(this.buttViewArchive);
            this.panel1.Location = new System.Drawing.Point(12, -39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2302, 505);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(1697, 429);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(565, 63);
            this.txtStatus.TabIndex = 11;
            // 
            // txtReligion
            // 
            this.txtReligion.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReligion.Location = new System.Drawing.Point(1697, 354);
            this.txtReligion.Name = "txtReligion";
            this.txtReligion.Size = new System.Drawing.Size(565, 63);
            this.txtReligion.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1460, 436);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 56);
            this.label11.TabIndex = 10;
            this.label11.Text = "Status";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1460, 354);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(168, 56);
            this.label13.TabIndex = 10;
            this.label13.Text = "Religion";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1460, 283);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 56);
            this.label12.TabIndex = 9;
            this.label12.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(1697, 281);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(565, 63);
            this.txtEmail.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(1697, 216);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(565, 63);
            this.txtAddress.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1460, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 56);
            this.label10.TabIndex = 6;
            this.label10.Text = "Address";
            // 
            // txtCivilStatus
            // 
            this.txtCivilStatus.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCivilStatus.Location = new System.Drawing.Point(1697, 155);
            this.txtCivilStatus.Name = "txtCivilStatus";
            this.txtCivilStatus.Size = new System.Drawing.Size(565, 63);
            this.txtCivilStatus.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1460, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(238, 56);
            this.label9.TabIndex = 6;
            this.label9.Text = "Civil Status";
            // 
            // txtNationality
            // 
            this.txtNationality.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationality.Location = new System.Drawing.Point(1697, 78);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(565, 63);
            this.txtNationality.TabIndex = 7;
            this.txtNationality.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1461, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 56);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nationality";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(457, 436);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(96, 56);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(457, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 56);
            this.label6.TabIndex = 6;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(457, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 56);
            this.label5.TabIndex = 5;
            this.label5.Text = "birthdate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 32);
            this.label4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(457, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 56);
            this.label3.TabIndex = 5;
            this.label3.Text = "Middle Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(457, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 56);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 56);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(726, 433);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(666, 63);
            this.txtAge.TabIndex = 2;
            this.txtAge.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Location = new System.Drawing.Point(726, 351);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(666, 63);
            this.txtGender.TabIndex = 2;
            this.txtGender.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirthDate.Location = new System.Drawing.Point(726, 288);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(666, 63);
            this.txtBirthDate.TabIndex = 2;
            this.txtBirthDate.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtMn
            // 
            this.txtMn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMn.Location = new System.Drawing.Point(726, 222);
            this.txtMn.Name = "txtMn";
            this.txtMn.Size = new System.Drawing.Size(666, 63);
            this.txtMn.TabIndex = 2;
            this.txtMn.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtLn
            // 
            this.txtLn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLn.Location = new System.Drawing.Point(726, 151);
            this.txtLn.Name = "txtLn";
            this.txtLn.Size = new System.Drawing.Size(666, 63);
            this.txtLn.TabIndex = 2;
            this.txtLn.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtFn
            // 
            this.txtFn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFn.Location = new System.Drawing.Point(726, 78);
            this.txtFn.Name = "txtFn";
            this.txtFn.Size = new System.Drawing.Size(666, 63);
            this.txtFn.TabIndex = 1;
            this.txtFn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(14, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(345, 79);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Supervisor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttAdd_Click);
            // 
            // buttAdd
            // 
            this.buttAdd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttAdd.Location = new System.Drawing.Point(14, 99);
            this.buttAdd.Name = "buttAdd";
            this.buttAdd.Size = new System.Drawing.Size(345, 79);
            this.buttAdd.TabIndex = 1;
            this.buttAdd.Text = "Add Staff";
            this.buttAdd.UseVisualStyleBackColor = true;
            this.buttAdd.Click += new System.EventHandler(this.buttAdd_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 472);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2353, 689);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(2333, 631);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Staff";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(2333, 631);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Supervisors";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Staff_Manag_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2551, 1399);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.supervisorLineUpBut);
            this.Controls.Add(this.staffLineUpBut);
            this.Name = "Staff_Manag_Form";
            this.Text = "staffManag";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffManagForm_FormClosing);
            this.Load += new System.EventHandler(this.StaffManagForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button staffLineUpBut;
        private System.Windows.Forms.Button supervisorLineUpBut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttViewArchive;
        private System.Windows.Forms.Button buttEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMn;
        private System.Windows.Forms.TextBox txtLn;
        private System.Windows.Forms.TextBox txtFn;
        private System.Windows.Forms.TextBox txtReligion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCivilStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.Button buttAdd;
        private System.Windows.Forms.Button button1;
    }
}