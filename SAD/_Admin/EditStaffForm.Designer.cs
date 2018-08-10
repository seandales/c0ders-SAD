namespace WindowsFormsApp4
{
    partial class EditStaffForm
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
            this.txtEditStaffFn = new System.Windows.Forms.TextBox();
            this.txtEditStaffMn = new System.Windows.Forms.TextBox();
            this.txtEditStaffLn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerBirthdate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.comboBoxCivilStatus = new System.Windows.Forms.ComboBox();
            this.btnCancelEditStaff = new System.Windows.Forms.Button();
            this.btnUpdateEditStaff = new System.Windows.Forms.Button();
            this.comboBoxStaffStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtEditStaffFn
            // 
            this.txtEditStaffFn.Location = new System.Drawing.Point(186, 63);
            this.txtEditStaffFn.Name = "txtEditStaffFn";
            this.txtEditStaffFn.Size = new System.Drawing.Size(179, 38);
            this.txtEditStaffFn.TabIndex = 0;
            // 
            // txtEditStaffMn
            // 
            this.txtEditStaffMn.Location = new System.Drawing.Point(186, 125);
            this.txtEditStaffMn.Name = "txtEditStaffMn";
            this.txtEditStaffMn.Size = new System.Drawing.Size(179, 38);
            this.txtEditStaffMn.TabIndex = 0;
            // 
            // txtEditStaffLn
            // 
            this.txtEditStaffLn.Location = new System.Drawing.Point(186, 200);
            this.txtEditStaffLn.Name = "txtEditStaffLn";
            this.txtEditStaffLn.Size = new System.Drawing.Size(179, 38);
            this.txtEditStaffLn.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Middle Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-2, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Birthdate";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-2, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Gender";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Civil Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 32);
            this.label7.TabIndex = 1;
            this.label7.Text = "Role";
            // 
            // dateTimePickerBirthdate
            // 
            this.dateTimePickerBirthdate.Location = new System.Drawing.Point(186, 270);
            this.dateTimePickerBirthdate.Name = "dateTimePickerBirthdate";
            this.dateTimePickerBirthdate.Size = new System.Drawing.Size(200, 38);
            this.dateTimePickerBirthdate.TabIndex = 2;
            this.dateTimePickerBirthdate.Value = new System.DateTime(2018, 8, 10, 0, 0, 0, 0);
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male ",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(186, 345);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(121, 39);
            this.comboBoxGender.TabIndex = 3;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Supervisor",
            "Supervising Custodian",
            "Monitor"});
            this.comboBoxRole.Location = new System.Drawing.Point(584, 169);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(121, 39);
            this.comboBoxRole.TabIndex = 4;
            // 
            // comboBoxCivilStatus
            // 
            this.comboBoxCivilStatus.FormattingEnabled = true;
            this.comboBoxCivilStatus.Items.AddRange(new object[] {
            "Married\t",
            "Single\t",
            "Widowed\t"});
            this.comboBoxCivilStatus.Location = new System.Drawing.Point(584, 48);
            this.comboBoxCivilStatus.Name = "comboBoxCivilStatus";
            this.comboBoxCivilStatus.Size = new System.Drawing.Size(121, 39);
            this.comboBoxCivilStatus.TabIndex = 5;
            // 
            // btnCancelEditStaff
            // 
            this.btnCancelEditStaff.Location = new System.Drawing.Point(498, 371);
            this.btnCancelEditStaff.Name = "btnCancelEditStaff";
            this.btnCancelEditStaff.Size = new System.Drawing.Size(207, 124);
            this.btnCancelEditStaff.TabIndex = 6;
            this.btnCancelEditStaff.Text = "Cancel";
            this.btnCancelEditStaff.UseVisualStyleBackColor = true;
            this.btnCancelEditStaff.Click += new System.EventHandler(this.btnCancelEditStaff_Click);
            // 
            // btnUpdateEditStaff
            // 
            this.btnUpdateEditStaff.Location = new System.Drawing.Point(750, 371);
            this.btnUpdateEditStaff.Name = "btnUpdateEditStaff";
            this.btnUpdateEditStaff.Size = new System.Drawing.Size(193, 124);
            this.btnUpdateEditStaff.TabIndex = 7;
            this.btnUpdateEditStaff.Text = "Update";
            this.btnUpdateEditStaff.UseVisualStyleBackColor = true;
            this.btnUpdateEditStaff.Click += new System.EventHandler(this.btnUpdateEditStaff_Click);
            // 
            // comboBoxStaffStatus
            // 
            this.comboBoxStaffStatus.FormattingEnabled = true;
            this.comboBoxStaffStatus.Items.AddRange(new object[] {
            "1",
            "0"});
            this.comboBoxStaffStatus.Location = new System.Drawing.Point(584, 111);
            this.comboBoxStaffStatus.Name = "comboBoxStaffStatus";
            this.comboBoxStaffStatus.Size = new System.Drawing.Size(121, 39);
            this.comboBoxStaffStatus.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(420, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 32);
            this.label8.TabIndex = 1;
            this.label8.Text = "Status";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(584, 242);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 38);
            this.textBox1.TabIndex = 8;
            // 
            // EditStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 621);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnUpdateEditStaff);
            this.Controls.Add(this.btnCancelEditStaff);
            this.Controls.Add(this.comboBoxStaffStatus);
            this.Controls.Add(this.comboBoxCivilStatus);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.dateTimePickerBirthdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEditStaffLn);
            this.Controls.Add(this.txtEditStaffMn);
            this.Controls.Add(this.txtEditStaffFn);
            this.Name = "EditStaffForm";
            this.Text = "EditStaffForm";
            this.Load += new System.EventHandler(this.EditStaffForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtEditStaffFn;
        public System.Windows.Forms.TextBox txtEditStaffMn;
        public System.Windows.Forms.TextBox txtEditStaffLn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DateTimePicker dateTimePickerBirthdate;
        public System.Windows.Forms.ComboBox comboBoxGender;
        public System.Windows.Forms.ComboBox comboBoxRole;
        public System.Windows.Forms.ComboBox comboBoxCivilStatus;
        private System.Windows.Forms.Button btnCancelEditStaff;
        private System.Windows.Forms.Button btnUpdateEditStaff;
        public System.Windows.Forms.ComboBox comboBoxStaffStatus;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textBox1;
    }
}