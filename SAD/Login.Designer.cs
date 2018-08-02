namespace WindowsFormsApp4
{
    partial class Login
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
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBut = new System.Windows.Forms.Button();
            this.exitBut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.Silver;
            this.passwordTextBox.Location = new System.Drawing.Point(85, 630);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(455, 47);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Text = "pass";
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNameTextBox.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.ForeColor = System.Drawing.Color.Silver;
            this.userNameTextBox.Location = new System.Drawing.Point(88, 534);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(453, 47);
            this.userNameTextBox.TabIndex = 1;
            this.userNameTextBox.Text = "username";
            this.userNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userNameTextBox.Enter += new System.EventHandler(this.userNameTextBox_Enter);
            this.userNameTextBox.Leave += new System.EventHandler(this.userNameTextBox_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.WelcomeHD;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(85, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(749, 420);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(243, 737);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Forgot Password?";
            // 
            // loginBut
            // 
            this.loginBut.BackColor = System.Drawing.Color.DarkBlue;
            this.loginBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBut.FlatAppearance.BorderSize = 0;
            this.loginBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.loginBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.loginBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBut.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBut.ForeColor = System.Drawing.Color.White;
            this.loginBut.Location = new System.Drawing.Point(635, 517);
            this.loginBut.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.loginBut.Name = "loginBut";
            this.loginBut.Size = new System.Drawing.Size(200, 81);
            this.loginBut.TabIndex = 3;
            this.loginBut.Text = "Login";
            this.loginBut.UseVisualStyleBackColor = false;
            this.loginBut.Click += new System.EventHandler(this.loginBut_Click);
            // 
            // exitBut
            // 
            this.exitBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.exitBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBut.FlatAppearance.BorderSize = 0;
            this.exitBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.exitBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.exitBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBut.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBut.Location = new System.Drawing.Point(635, 613);
            this.exitBut.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.exitBut.Name = "exitBut";
            this.exitBut.Size = new System.Drawing.Size(200, 86);
            this.exitBut.TabIndex = 4;
            this.exitBut.Text = "Exit";
            this.exitBut.UseVisualStyleBackColor = false;
            this.exitBut.Click += new System.EventHandler(this.exitBut_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.exitBut);
            this.panel1.Controls.Add(this.loginBut);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.userNameTextBox);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 829);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 835);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginBut;
        private System.Windows.Forms.Button exitBut;
        private System.Windows.Forms.Panel panel1;
    }
}

