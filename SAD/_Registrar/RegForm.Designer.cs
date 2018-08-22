namespace WindowsFormsApp4
{
    partial class RegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegForm));
            this.smallerIcons = new System.Windows.Forms.ImageList(this.components);
            this.topPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Icons = new System.Windows.Forms.ImageList(this.components);
            this.navigationLabel = new System.Windows.Forms.Label();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.staffsButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.signOutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.homePanel = new System.Windows.Forms.Panel();
            this.studentsPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addUserLabel = new System.Windows.Forms.Label();
            this.checkStudArchive = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEditStud = new System.Windows.Forms.Button();
            this.txtSearchStud = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.archiveStud = new System.Windows.Forms.DataGridView();
            this.datagridStud = new System.Windows.Forms.DataGridView();
            this.btnAddStud = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.studentsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archiveStud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridStud)).BeginInit();
            this.SuspendLayout();
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
            // topPanel
            // 
            this.topPanel.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.TopPanel;
            this.topPanel.Controls.Add(this.ExitButton);
            this.topPanel.Controls.Add(this.navigationLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(125, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1228, 60);
            this.topPanel.TabIndex = 13;
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
            // Icons
            // 
            this.Icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Icons.ImageStream")));
            this.Icons.TransparentColor = System.Drawing.Color.Transparent;
            this.Icons.Images.SetKeyName(0, "X Icon.jpg");
            this.Icons.Images.SetKeyName(1, "Home.png");
            this.Icons.Images.SetKeyName(2, "SignOut.png");
            this.Icons.Images.SetKeyName(3, "Accounts.png");
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
            // sidePanel
            // 
            this.sidePanel.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.SidePanel1;
            this.sidePanel.Controls.Add(this.staffsButton);
            this.sidePanel.Controls.Add(this.homeButton);
            this.sidePanel.Controls.Add(this.signOutButton);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(125, 929);
            this.sidePanel.TabIndex = 12;
            // 
            // staffsButton
            // 
            this.staffsButton.BackColor = System.Drawing.Color.Transparent;
            this.staffsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staffsButton.FlatAppearance.BorderSize = 0;
            this.staffsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.staffsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.staffsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffsButton.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffsButton.ForeColor = System.Drawing.Color.Black;
            this.staffsButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.staffsButton.ImageKey = "Accounts.png";
            this.staffsButton.ImageList = this.Icons;
            this.staffsButton.Location = new System.Drawing.Point(0, 125);
            this.staffsButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.staffsButton.Name = "staffsButton";
            this.staffsButton.Size = new System.Drawing.Size(125, 125);
            this.staffsButton.TabIndex = 15;
            this.staffsButton.Text = "\r\nStudents";
            this.staffsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.staffsButton.UseVisualStyleBackColor = false;
            this.staffsButton.Click += new System.EventHandler(this.studentsButton_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 35);
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
            this.homePanel.Location = new System.Drawing.Point(463, 162);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(200, 100);
            this.homePanel.TabIndex = 14;
            // 
            // studentsPanel
            // 
            this.studentsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("studentsPanel.BackgroundImage")));
            this.studentsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.studentsPanel.Controls.Add(this.panel1);
            this.studentsPanel.Controls.Add(this.checkStudArchive);
            this.studentsPanel.Controls.Add(this.label8);
            this.studentsPanel.Controls.Add(this.btnEditStud);
            this.studentsPanel.Controls.Add(this.txtSearchStud);
            this.studentsPanel.Controls.Add(this.panel4);
            this.studentsPanel.Controls.Add(this.btnAddStud);
            this.studentsPanel.Location = new System.Drawing.Point(182, 125);
            this.studentsPanel.Name = "studentsPanel";
            this.studentsPanel.Size = new System.Drawing.Size(1075, 628);
            this.studentsPanel.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.AnotherPanel;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(782, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 144);
            this.panel1.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Section:";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.TopPanel;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.addUserLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 42);
            this.panel2.TabIndex = 37;
            // 
            // addUserLabel
            // 
            this.addUserLabel.AutoSize = true;
            this.addUserLabel.BackColor = System.Drawing.Color.Transparent;
            this.addUserLabel.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserLabel.ForeColor = System.Drawing.Color.Black;
            this.addUserLabel.Location = new System.Drawing.Point(20, 10);
            this.addUserLabel.Name = "addUserLabel";
            this.addUserLabel.Size = new System.Drawing.Size(233, 27);
            this.addUserLabel.TabIndex = 16;
            this.addUserLabel.Text = "Sort Students";
            // 
            // checkStudArchive
            // 
            this.checkStudArchive.AutoSize = true;
            this.checkStudArchive.Location = new System.Drawing.Point(592, 26);
            this.checkStudArchive.Name = "checkStudArchive";
            this.checkStudArchive.Size = new System.Drawing.Size(167, 20);
            this.checkStudArchive.TabIndex = 16;
            this.checkStudArchive.Text = " View Archived";
            this.checkStudArchive.UseVisualStyleBackColor = true;
            this.checkStudArchive.CheckedChanged += new System.EventHandler(this.checkStudArchive_CheckedChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 27);
            this.label8.TabIndex = 14;
            this.label8.Text = "Search: ";
            // 
            // btnEditStud
            // 
            this.btnEditStud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(75)))));
            this.btnEditStud.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.btnEditStud.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnEditStud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStud.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStud.ImageKey = "(none)";
            this.btnEditStud.ImageList = this.smallerIcons;
            this.btnEditStud.Location = new System.Drawing.Point(450, 11);
            this.btnEditStud.Name = "btnEditStud";
            this.btnEditStud.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEditStud.Size = new System.Drawing.Size(89, 34);
            this.btnEditStud.TabIndex = 12;
            this.btnEditStud.Text = "Edit";
            this.btnEditStud.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditStud.UseVisualStyleBackColor = false;
            this.btnEditStud.Click += new System.EventHandler(this.btnEditStud_Click);
            // 
            // txtSearchStud
            // 
            this.txtSearchStud.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSearchStud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchStud.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchStud.Location = new System.Drawing.Point(172, 11);
            this.txtSearchStud.Name = "txtSearchStud";
            this.txtSearchStud.Size = new System.Drawing.Size(272, 34);
            this.txtSearchStud.TabIndex = 11;
            this.txtSearchStud.TextChanged += new System.EventHandler(this.txtSearchStud_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.archiveStud);
            this.panel4.Controls.Add(this.datagridStud);
            this.panel4.Location = new System.Drawing.Point(11, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(750, 550);
            this.panel4.TabIndex = 13;
            // 
            // archiveStud
            // 
            this.archiveStud.AllowUserToAddRows = false;
            this.archiveStud.AllowUserToDeleteRows = false;
            this.archiveStud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.archiveStud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.archiveStud.Location = new System.Drawing.Point(0, 0);
            this.archiveStud.Name = "archiveStud";
            this.archiveStud.ReadOnly = true;
            this.archiveStud.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.archiveStud.Size = new System.Drawing.Size(748, 548);
            this.archiveStud.TabIndex = 1;
            this.archiveStud.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.archiveStud_CellMouseDown);
            // 
            // datagridStud
            // 
            this.datagridStud.AllowUserToAddRows = false;
            this.datagridStud.AllowUserToDeleteRows = false;
            this.datagridStud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridStud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridStud.Location = new System.Drawing.Point(0, 0);
            this.datagridStud.Name = "datagridStud";
            this.datagridStud.ReadOnly = true;
            this.datagridStud.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridStud.Size = new System.Drawing.Size(748, 548);
            this.datagridStud.TabIndex = 0;
            this.datagridStud.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagridStud_CellMouseDown);
            // 
            // btnAddStud
            // 
            this.btnAddStud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(220)))), ((int)(((byte)(129)))));
            this.btnAddStud.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(1)))));
            this.btnAddStud.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(65)))));
            this.btnAddStud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStud.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStud.ImageKey = "(none)";
            this.btnAddStud.ImageList = this.smallerIcons;
            this.btnAddStud.Location = new System.Drawing.Point(782, 339);
            this.btnAddStud.Name = "btnAddStud";
            this.btnAddStud.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddStud.Size = new System.Drawing.Size(271, 50);
            this.btnAddStud.TabIndex = 18;
            this.btnAddStud.Text = "Add Student";
            this.btnAddStud.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddStud.UseVisualStyleBackColor = false;
            this.btnAddStud.Click += new System.EventHandler(this.btnAddStud_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.PanelBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1353, 929);
            this.Controls.Add(this.studentsPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.homePanel);
            this.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegForm_FormClosing);
            this.Load += new System.EventHandler(this.RegForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.studentsPanel.ResumeLayout(false);
            this.studentsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.archiveStud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridStud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList smallerIcons;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ImageList Icons;
        private System.Windows.Forms.Label navigationLabel;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Button staffsButton;
        private System.Windows.Forms.Panel studentsPanel;
        public System.Windows.Forms.CheckBox checkStudArchive;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddStud;
        private System.Windows.Forms.Button btnEditStud;
        private System.Windows.Forms.TextBox txtSearchStud;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView archiveStud;
        private System.Windows.Forms.DataGridView datagridStud;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label addUserLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}