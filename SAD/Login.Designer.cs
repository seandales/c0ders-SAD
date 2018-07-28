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
            this.loginBut = new System.Windows.Forms.Button();
            this.exitBut = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.userNameTextBox.Location = new System.Drawing.Point(701, 334);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.userNameTextBox.Multiline = true;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(236, 28);
            this.userNameTextBox.TabIndex = 0;
            this.userNameTextBox.Text = "Username";
            this.userNameTextBox.TextChanged += new System.EventHandler(this.userNameTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.passwordTextBox.Location = new System.Drawing.Point(701, 402);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(236, 26);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.Text = "Password";
            // 
            // loginBut
            // 
            this.loginBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.loginBut.FlatAppearance.BorderSize = 0;
            this.loginBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBut.ForeColor = System.Drawing.SystemColors.Control;
            this.loginBut.Location = new System.Drawing.Point(738, 459);
            this.loginBut.Margin = new System.Windows.Forms.Padding(1);
            this.loginBut.Name = "loginBut";
            this.loginBut.Size = new System.Drawing.Size(154, 39);
            this.loginBut.TabIndex = 4;
            this.loginBut.Text = "Login";
            this.loginBut.UseVisualStyleBackColor = false;
            this.loginBut.Click += new System.EventHandler(this.loginBut_Click);
            // 
            // exitBut
            // 
            this.exitBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.exitBut.FlatAppearance.BorderSize = 0;
            this.exitBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exitBut.Location = new System.Drawing.Point(738, 519);
            this.exitBut.Margin = new System.Windows.Forms.Padding(1);
            this.exitBut.Name = "exitBut";
            this.exitBut.Size = new System.Drawing.Size(154, 39);
            this.exitBut.TabIndex = 4;
            this.exitBut.Text = "Cancel";
            this.exitBut.UseVisualStyleBackColor = false;
            this.exitBut.Click += new System.EventHandler(this.exitBut_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(698, 237);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 38);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Welcome Back";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(694, 276);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(258, 33);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Login to your account to get started";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.sign_up4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1141, 816);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exitBut);
            this.Controls.Add(this.loginBut);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginBut;
        private System.Windows.Forms.Button exitBut;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

