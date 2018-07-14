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
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitBut = new System.Windows.Forms.Button();
            this.loginBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userNameTextBox.Location = new System.Drawing.Point(501, 301);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(256, 41);
            this.userNameTextBox.TabIndex = 0;
            this.userNameTextBox.Text = "USERNAME";
            this.userNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userNameTextBox.MouseEnter += new System.EventHandler(this.userNameTextBox_MouseEnter);
            this.userNameTextBox.MouseLeave += new System.EventHandler(this.userNameTextBox_MouseLeave);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordTextBox.Location = new System.Drawing.Point(501, 378);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(256, 41);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.Text = "PASSWORD";
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextBox.MouseEnter += new System.EventHandler(this.passwordTextBox_MouseEnter);
            this.passwordTextBox.MouseLeave += new System.EventHandler(this.passwordTextBox_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp4.Properties.Resources.Welcome;
            this.pictureBox1.Location = new System.Drawing.Point(428, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 268);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // exitBut
            // 
            this.exitBut.BackColor = System.Drawing.Color.White;
            this.exitBut.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.Exit1;
            this.exitBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBut.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBut.ForeColor = System.Drawing.Color.White;
            this.exitBut.Location = new System.Drawing.Point(793, 376);
            this.exitBut.Margin = new System.Windows.Forms.Padding(2);
            this.exitBut.Name = "exitBut";
            this.exitBut.Size = new System.Drawing.Size(102, 43);
            this.exitBut.TabIndex = 3;
            this.exitBut.UseVisualStyleBackColor = false;
            this.exitBut.Click += new System.EventHandler(this.exitBut_Click);
            // 
            // loginBut
            // 
            this.loginBut.BackColor = System.Drawing.Color.White;
            this.loginBut.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.Login1;
            this.loginBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBut.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBut.ForeColor = System.Drawing.Color.White;
            this.loginBut.Location = new System.Drawing.Point(790, 301);
            this.loginBut.Margin = new System.Windows.Forms.Padding(2);
            this.loginBut.Name = "loginBut";
            this.loginBut.Size = new System.Drawing.Size(105, 43);
            this.loginBut.TabIndex = 2;
            this.loginBut.UseVisualStyleBackColor = false;
            this.loginBut.Click += new System.EventHandler(this.loginBut_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(938, 664);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitBut);
            this.Controls.Add(this.loginBut);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = " Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginBut;
        private System.Windows.Forms.Button exitBut;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

