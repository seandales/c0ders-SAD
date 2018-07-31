namespace WindowsFormsApp4
{
    partial class AddStaffForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.txtFn = new System.Windows.Forms.TextBox();
            this.txtLn = new System.Windows.Forms.TextBox();
            this.txtMn = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtReligion = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.butAdd = new System.Windows.Forms.Button();
            this.buttUpdate = new System.Windows.Forms.Button();
            this.comboxGend = new System.Windows.Forms.ComboBox();
            this.comboCivil = new System.Windows.Forms.ComboBox();
            this.buttCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboxStatus = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, -72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Middle Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Birthdate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gender";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(60, 586);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(66, 32);
            this.Age.TabIndex = 0;
            this.Age.Text = "Age";
            // 
            // txtFn
            // 
            this.txtFn.Location = new System.Drawing.Point(298, 117);
            this.txtFn.Multiline = true;
            this.txtFn.Name = "txtFn";
            this.txtFn.Size = new System.Drawing.Size(482, 38);
            this.txtFn.TabIndex = 0;
            // 
            // txtLn
            // 
            this.txtLn.Location = new System.Drawing.Point(298, 192);
            this.txtLn.Multiline = true;
            this.txtLn.Name = "txtLn";
            this.txtLn.Size = new System.Drawing.Size(482, 38);
            this.txtLn.TabIndex = 2;
            this.txtLn.TextChanged += new System.EventHandler(this.Textbox_TextChanged);
            // 
            // txtMn
            // 
            this.txtMn.Location = new System.Drawing.Point(298, 293);
            this.txtMn.Multiline = true;
            this.txtMn.Name = "txtMn";
            this.txtMn.Size = new System.Drawing.Size(482, 38);
            this.txtMn.TabIndex = 3;
            this.txtMn.TextChanged += new System.EventHandler(this.Textbox_TextChanged);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(298, 580);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(482, 38);
            this.txtAge.TabIndex = 6;
            this.txtAge.TextChanged += new System.EventHandler(this.Textbox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(892, -72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nationality";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(886, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Civil Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(886, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(886, 401);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 32);
            this.label10.TabIndex = 0;
            this.label10.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(885, 490);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 32);
            this.label11.TabIndex = 0;
            this.label11.Text = "Religion";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(886, 586);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 32);
            this.label12.TabIndex = 0;
            this.label12.Text = "Status";
            // 
            // txtNationality
            // 
            this.txtNationality.Location = new System.Drawing.Point(1124, 126);
            this.txtNationality.Multiline = true;
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(482, 38);
            this.txtNationality.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(1124, 293);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(482, 38);
            this.txtAddress.TabIndex = 9;
            this.txtAddress.TextChanged += new System.EventHandler(this.Textbox_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(1124, 395);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(482, 38);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.TextChanged += new System.EventHandler(this.Textbox_TextChanged);
            // 
            // txtReligion
            // 
            this.txtReligion.Location = new System.Drawing.Point(1124, 487);
            this.txtReligion.Multiline = true;
            this.txtReligion.Name = "txtReligion";
            this.txtReligion.Size = new System.Drawing.Size(482, 38);
            this.txtReligion.TabIndex = 11;
            this.txtReligion.TextChanged += new System.EventHandler(this.Textbox_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(298, 401);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(482, 38);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(102, 759);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(282, 102);
            this.butAdd.TabIndex = 2;
            this.butAdd.Text = "o43";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // buttUpdate
            // 
            this.buttUpdate.Location = new System.Drawing.Point(481, 759);
            this.buttUpdate.Name = "buttUpdate";
            this.buttUpdate.Size = new System.Drawing.Size(282, 102);
            this.buttUpdate.TabIndex = 3;
            this.buttUpdate.Text = "Update";
            this.buttUpdate.UseVisualStyleBackColor = true;
            this.buttUpdate.Click += new System.EventHandler(this.buttUpdate_Click);
            // 
            // comboxGend
            // 
            this.comboxGend.FormattingEnabled = true;
            this.comboxGend.Items.AddRange(new object[] {
            "",
            "Male",
            "Female"});
            this.comboxGend.Location = new System.Drawing.Point(298, 481);
            this.comboxGend.Name = "comboxGend";
            this.comboxGend.Size = new System.Drawing.Size(482, 39);
            this.comboxGend.TabIndex = 5;
            this.comboxGend.SelectedIndexChanged += new System.EventHandler(this.comboxGend_SelectedIndexChanged);
            // 
            // comboCivil
            // 
            this.comboCivil.FormattingEnabled = true;
            this.comboCivil.Items.AddRange(new object[] {
            "Married \t",
            "Single\t\t",
            "Widowed"});
            this.comboCivil.Location = new System.Drawing.Point(1124, 189);
            this.comboCivil.Name = "comboCivil";
            this.comboCivil.Size = new System.Drawing.Size(482, 39);
            this.comboCivil.TabIndex = 8;
            // 
            // buttCancel
            // 
            this.buttCancel.Location = new System.Drawing.Point(947, 759);
            this.buttCancel.Name = "buttCancel";
            this.buttCancel.Size = new System.Drawing.Size(282, 102);
            this.buttCancel.TabIndex = 3;
            this.buttCancel.Text = "Cancel";
            this.buttCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.comboxStatus);
            this.groupBox1.Controls.Add(this.comboCivil);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboxGend);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtReligion);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.Age);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtMn);
            this.groupBox1.Controls.Add(this.txtFn);
            this.groupBox1.Controls.Add(this.txtNationality);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtLn);
            this.groupBox1.Location = new System.Drawing.Point(88, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1835, 636);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.TextChanged += new System.EventHandler(this.groupBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "First Name";
            // 
            // comboxStatus
            // 
            this.comboxStatus.FormattingEnabled = true;
            this.comboxStatus.Items.AddRange(new object[] {
            "0",
            "1"});
            this.comboxStatus.Location = new System.Drawing.Point(1124, 579);
            this.comboxStatus.Name = "comboxStatus";
            this.comboxStatus.Size = new System.Drawing.Size(482, 39);
            this.comboxStatus.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(886, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 32);
            this.label13.TabIndex = 0;
            this.label13.Text = "Nationality";
            // 
            // AddStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1991, 1013);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttCancel);
            this.Controls.Add(this.buttUpdate);
            this.Controls.Add(this.butAdd);
            this.Name = "AddStaffForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddStaffForm_FormClosing);
            this.Load += new System.EventHandler(this.AddStaffForm_Load);
            this.Shown += new System.EventHandler(this.AddStaffForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Age;
        public System.Windows.Forms.TextBox txtFn;
        public System.Windows.Forms.TextBox txtLn;
        public System.Windows.Forms.TextBox txtMn;
        public System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtNationality;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtReligion;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Button butAdd;
        public System.Windows.Forms.Button buttUpdate;
        public System.Windows.Forms.ComboBox comboxGend;
        public System.Windows.Forms.ComboBox comboCivil;
        private System.Windows.Forms.Button buttCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.ComboBox comboxStatus;
    }
}