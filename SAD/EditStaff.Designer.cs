namespace WindowsFormsApp4
{
    partial class EditStaff
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
            this.combostatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboGradeLevel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.dateTimeBirthdate = new System.Windows.Forms.DateTimePicker();
            this.bdayLabel = new System.Windows.Forms.Label();
            this.txtLn = new System.Windows.Forms.TextBox();
            this.txtMn = new System.Windows.Forms.TextBox();
            this.txtFn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combostatus
            // 
            this.combostatus.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combostatus.FormattingEnabled = true;
            this.combostatus.Items.AddRange(new object[] {
            "",
            "0",
            "1"});
            this.combostatus.Location = new System.Drawing.Point(39, 349);
            this.combostatus.Name = "combostatus";
            this.combostatus.Size = new System.Drawing.Size(116, 25);
            this.combostatus.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Status";
            // 
            // comboGradeLevel
            // 
            this.comboGradeLevel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGradeLevel.FormattingEnabled = true;
            this.comboGradeLevel.Items.AddRange(new object[] {
            "",
            "1grade\t",
            "2grade\t",
            "3grade"});
            this.comboGradeLevel.Location = new System.Drawing.Point(39, 301);
            this.comboGradeLevel.Name = "comboGradeLevel";
            this.comboGradeLevel.Size = new System.Drawing.Size(116, 25);
            this.comboGradeLevel.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Grade Level";
            // 
            // comboGender
            // 
            this.comboGender.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "",
            "M",
            "F"});
            this.comboGender.Location = new System.Drawing.Point(39, 253);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(113, 25);
            this.comboGender.TabIndex = 38;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.BackColor = System.Drawing.Color.Transparent;
            this.genderLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(36, 233);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(80, 17);
            this.genderLabel.TabIndex = 37;
            this.genderLabel.Text = "Gender: ";
            // 
            // dateTimeBirthdate
            // 
            this.dateTimeBirthdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeBirthdate.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeBirthdate.Location = new System.Drawing.Point(39, 203);
            this.dateTimeBirthdate.MaxDate = new System.DateTime(2018, 8, 2, 0, 0, 0, 0);
            this.dateTimeBirthdate.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimeBirthdate.Name = "dateTimeBirthdate";
            this.dateTimeBirthdate.Size = new System.Drawing.Size(222, 26);
            this.dateTimeBirthdate.TabIndex = 36;
            this.dateTimeBirthdate.Value = new System.DateTime(2018, 8, 2, 0, 0, 0, 0);
            // 
            // bdayLabel
            // 
            this.bdayLabel.AutoSize = true;
            this.bdayLabel.BackColor = System.Drawing.Color.Transparent;
            this.bdayLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdayLabel.Location = new System.Drawing.Point(36, 183);
            this.bdayLabel.Name = "bdayLabel";
            this.bdayLabel.Size = new System.Drawing.Size(98, 17);
            this.bdayLabel.TabIndex = 35;
            this.bdayLabel.Text = "Birthdate:";
            // 
            // txtLn
            // 
            this.txtLn.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLn.Location = new System.Drawing.Point(39, 153);
            this.txtLn.Name = "txtLn";
            this.txtLn.Size = new System.Drawing.Size(222, 25);
            this.txtLn.TabIndex = 34;
            this.txtLn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMn
            // 
            this.txtMn.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMn.Location = new System.Drawing.Point(39, 103);
            this.txtMn.Name = "txtMn";
            this.txtMn.Size = new System.Drawing.Size(222, 25);
            this.txtMn.TabIndex = 33;
            this.txtMn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFn
            // 
            this.txtFn.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFn.Location = new System.Drawing.Point(39, 53);
            this.txtFn.Name = "txtFn";
            this.txtFn.Size = new System.Drawing.Size(222, 25);
            this.txtFn.TabIndex = 32;
            this.txtFn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Last Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Middle Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "First Name:";
            // 
            // EditStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.combostatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboGradeLevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.dateTimeBirthdate);
            this.Controls.Add(this.bdayLabel);
            this.Controls.Add(this.txtLn);
            this.Controls.Add(this.txtMn);
            this.Controls.Add(this.txtFn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Name = "EditStaff";
            this.Text = "EditStaff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combostatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboGradeLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.DateTimePicker dateTimeBirthdate;
        private System.Windows.Forms.Label bdayLabel;
        private System.Windows.Forms.TextBox txtLn;
        private System.Windows.Forms.TextBox txtMn;
        private System.Windows.Forms.TextBox txtFn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}