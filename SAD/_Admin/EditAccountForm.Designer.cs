namespace WindowsFormsApp4
{
    partial class EditAccountForm
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
            this.txtEditUserName = new System.Windows.Forms.TextBox();
            this.txtEditPass1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.butCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comboEditRole = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.Label();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtEditUserName
            // 
            this.txtEditUserName.Location = new System.Drawing.Point(227, 125);
            this.txtEditUserName.Name = "txtEditUserName";
            this.txtEditUserName.Size = new System.Drawing.Size(259, 38);
            this.txtEditUserName.TabIndex = 0;
            this.txtEditUserName.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // txtEditPass1
            // 
            this.txtEditPass1.Location = new System.Drawing.Point(227, 198);
            this.txtEditPass1.Name = "txtEditPass1";
            this.txtEditPass1.Size = new System.Drawing.Size(259, 38);
            this.txtEditPass1.TabIndex = 1;
            this.txtEditPass1.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "role";
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(597, 409);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(157, 92);
            this.butCancel.TabIndex = 5;
            this.butCancel.Text = "cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(842, 409);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(157, 92);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // comboEditRole
            // 
            this.comboEditRole.FormattingEnabled = true;
            this.comboEditRole.Items.AddRange(new object[] {
            "Admin",
            "Principal",
            "Supervisor",
            "HRM"});
            this.comboEditRole.Location = new System.Drawing.Point(227, 281);
            this.comboEditRole.Name = "comboEditRole";
            this.comboEditRole.Size = new System.Drawing.Size(259, 39);
            this.comboEditRole.TabIndex = 6;
            this.comboEditRole.SelectedIndexChanged += new System.EventHandler(this.comboEditRole_SelectedIndexChanged);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(70, 342);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(96, 32);
            this.status.TabIndex = 7;
            this.status.Text = "Status";
            // 
            // comboStatus
            // 
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "1",
            "0"});
            this.comboStatus.Location = new System.Drawing.Point(227, 351);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(259, 39);
            this.comboStatus.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(694, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 38);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // EditAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 528);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.comboEditRole);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEditPass1);
            this.Controls.Add(this.txtEditUserName);
            this.Name = "EditAccountForm";
            this.Text = "EditAccountForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditAccountForm_FormClosing);
            this.Load += new System.EventHandler(this.EditAccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtEditUserName;
        public System.Windows.Forms.TextBox txtEditPass1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.ComboBox comboEditRole;
        private System.Windows.Forms.Label status;
        public System.Windows.Forms.ComboBox comboStatus;
        public System.Windows.Forms.TextBox textBox1;
    }
}