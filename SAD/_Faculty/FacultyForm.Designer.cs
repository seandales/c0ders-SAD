namespace WindowsFormsApp4
{
    partial class FacultyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacultyForm));
            this.Icons = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.homePanel = new System.Windows.Forms.Panel();
            this.smallerIcons = new System.Windows.Forms.ImageList(this.components);
            this.signOutButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.studentsButton = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.prescriptionsButton = new System.Windows.Forms.Button();
            this.navigationLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.studentsPanel = new System.Windows.Forms.Panel();
            this.prescriptionsPanel = new System.Windows.Forms.Panel();
            this.homePanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Icons
            // 
            this.Icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Icons.ImageStream")));
            this.Icons.TransparentColor = System.Drawing.Color.Transparent;
            this.Icons.Images.SetKeyName(0, "X Icon.jpg");
            this.Icons.Images.SetKeyName(1, "Home.png");
            this.Icons.Images.SetKeyName(2, "SignOut.png");
            this.Icons.Images.SetKeyName(3, "Accounts.png");
            this.Icons.Images.SetKeyName(4, "Clipboard.png");
            this.Icons.Images.SetKeyName(5, "account.png");
            this.Icons.Images.SetKeyName(6, "Classroom.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status";
            // 
            // homePanel
            // 
            this.homePanel.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.PanelBG;
            this.homePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homePanel.Controls.Add(this.label1);
            this.homePanel.Location = new System.Drawing.Point(189, 125);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(200, 100);
            this.homePanel.TabIndex = 10;
            // 
            // smallerIcons
            // 
            this.smallerIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallerIcons.ImageStream")));
            this.smallerIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.smallerIcons.Images.SetKeyName(0, "Add.png");
            this.smallerIcons.Images.SetKeyName(1, "Edit.png");
            this.smallerIcons.Images.SetKeyName(2, "Archive.png");
            this.smallerIcons.Images.SetKeyName(3, "Delete.png");
            // 
            // signOutButton
            // 
            this.signOutButton.BackColor = System.Drawing.Color.Transparent;
            this.signOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signOutButton.FlatAppearance.BorderSize = 0;
            this.signOutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.signOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.signOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signOutButton.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOutButton.ForeColor = System.Drawing.Color.Black;
            this.signOutButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.signOutButton.ImageKey = "SignOut.png";
            this.signOutButton.ImageList = this.Icons;
            this.signOutButton.Location = new System.Drawing.Point(0, 550);
            this.signOutButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(125, 125);
            this.signOutButton.TabIndex = 3;
            this.signOutButton.Text = "\r\nSign Out";
            this.signOutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.signOutButton.UseVisualStyleBackColor = false;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.homeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.homeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.Black;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.homeButton.ImageKey = "Home.png";
            this.homeButton.ImageList = this.Icons;
            this.homeButton.Location = new System.Drawing.Point(0, 0);
            this.homeButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(125, 125);
            this.homeButton.TabIndex = 5;
            this.homeButton.Text = "\r\nHome";
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // studentsButton
            // 
            this.studentsButton.BackColor = System.Drawing.Color.Transparent;
            this.studentsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentsButton.FlatAppearance.BorderSize = 0;
            this.studentsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.studentsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.studentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentsButton.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsButton.ForeColor = System.Drawing.Color.Black;
            this.studentsButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.studentsButton.ImageKey = "Classroom.png";
            this.studentsButton.ImageList = this.Icons;
            this.studentsButton.Location = new System.Drawing.Point(0, 125);
            this.studentsButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.studentsButton.Name = "studentsButton";
            this.studentsButton.Size = new System.Drawing.Size(125, 125);
            this.studentsButton.TabIndex = 6;
            this.studentsButton.Text = "\r\nStudents";
            this.studentsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.studentsButton.UseVisualStyleBackColor = false;
            this.studentsButton.Click += new System.EventHandler(this.studentsButton_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.SidePanel1;
            this.sidePanel.Controls.Add(this.prescriptionsButton);
            this.sidePanel.Controls.Add(this.studentsButton);
            this.sidePanel.Controls.Add(this.homeButton);
            this.sidePanel.Controls.Add(this.signOutButton);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(125, 675);
            this.sidePanel.TabIndex = 8;
            // 
            // prescriptionsButton
            // 
            this.prescriptionsButton.BackColor = System.Drawing.Color.Transparent;
            this.prescriptionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prescriptionsButton.FlatAppearance.BorderSize = 0;
            this.prescriptionsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.prescriptionsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.prescriptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prescriptionsButton.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prescriptionsButton.ForeColor = System.Drawing.Color.Black;
            this.prescriptionsButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.prescriptionsButton.ImageKey = "Clipboard.png";
            this.prescriptionsButton.ImageList = this.Icons;
            this.prescriptionsButton.Location = new System.Drawing.Point(0, 250);
            this.prescriptionsButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.prescriptionsButton.Name = "prescriptionsButton";
            this.prescriptionsButton.Size = new System.Drawing.Size(125, 125);
            this.prescriptionsButton.TabIndex = 7;
            this.prescriptionsButton.Text = "\r\nPre-\r\nscriptions";
            this.prescriptionsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.prescriptionsButton.UseVisualStyleBackColor = false;
            this.prescriptionsButton.Click += new System.EventHandler(this.prescriptionsButton_Click);
            // 
            // navigationLabel
            // 
            this.navigationLabel.AutoSize = true;
            this.navigationLabel.BackColor = System.Drawing.Color.Transparent;
            this.navigationLabel.Font = new System.Drawing.Font("Lucida Console", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationLabel.Location = new System.Drawing.Point(5, 9);
            this.navigationLabel.Name = "navigationLabel";
            this.navigationLabel.Size = new System.Drawing.Size(140, 48);
            this.navigationLabel.TabIndex = 0;
            this.navigationLabel.Text = "Home";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Black;
            this.ExitButton.ImageKey = "X Icon.jpg";
            this.ExitButton.ImageList = this.Icons;
            this.ExitButton.Location = new System.Drawing.Point(1015, -1);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(60, 60);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.TopPanel;
            this.topPanel.Controls.Add(this.ExitButton);
            this.topPanel.Controls.Add(this.navigationLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(125, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1075, 60);
            this.topPanel.TabIndex = 9;
            // 
            // studentsPanel
            // 
            this.studentsPanel.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.PanelBG;
            this.studentsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.studentsPanel.Location = new System.Drawing.Point(217, 336);
            this.studentsPanel.Name = "studentsPanel";
            this.studentsPanel.Size = new System.Drawing.Size(200, 100);
            this.studentsPanel.TabIndex = 11;
            // 
            // prescriptionsPanel
            // 
            this.prescriptionsPanel.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.PanelBG;
            this.prescriptionsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prescriptionsPanel.Location = new System.Drawing.Point(640, 165);
            this.prescriptionsPanel.Name = "prescriptionsPanel";
            this.prescriptionsPanel.Size = new System.Drawing.Size(200, 100);
            this.prescriptionsPanel.TabIndex = 11;
            // 
            // FacultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.PanelBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.studentsPanel);
            this.Controls.Add(this.prescriptionsPanel);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.sidePanel);
            this.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FacultyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faculty";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FacultyForm_FormClosing);
            this.Load += new System.EventHandler(this.FacultyForm_Load);
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList Icons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.ImageList smallerIcons;
        private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button studentsButton;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Label navigationLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button prescriptionsButton;
        private System.Windows.Forms.Panel studentsPanel;
        private System.Windows.Forms.Panel prescriptionsPanel;
    }
}