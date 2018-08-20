﻿namespace WindowsFormsApp4
{
    partial class HRMForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HRMForm));
            this.smallerIcons = new System.Windows.Forms.ImageList(this.components);
            this.Icons = new System.Windows.Forms.ImageList(this.components);
            this.homePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.navigationLabel = new System.Windows.Forms.Label();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.staffsButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.signOutButton = new System.Windows.Forms.Button();
            this.staffsPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail2 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.comboRoleStaffs = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.comboCivilStatus = new System.Windows.Forms.ComboBox();
            this.civilStatusLabel = new System.Windows.Forms.Label();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.dateTimeBirthdate = new System.Windows.Forms.DateTimePicker();
            this.bdayLabel = new System.Windows.Forms.Label();
            this.btnStaffAdd = new System.Windows.Forms.Button();
            this.btnStaffCancel = new System.Windows.Forms.Button();
            this.txtLn = new System.Windows.Forms.TextBox();
            this.txtMn = new System.Windows.Forms.TextBox();
            this.txtFn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnStaffEdit = new System.Windows.Forms.Button();
            this.txtStaffSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.staffListGridView = new System.Windows.Forms.DataGridView();
            this.homePanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.staffsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffListGridView)).BeginInit();
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
            // Icons
            // 
            this.Icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Icons.ImageStream")));
            this.Icons.TransparentColor = System.Drawing.Color.Transparent;
            this.Icons.Images.SetKeyName(0, "X Icon.jpg");
            this.Icons.Images.SetKeyName(1, "Home.png");
            this.Icons.Images.SetKeyName(2, "SignOut.png");
            this.Icons.Images.SetKeyName(3, "Accounts.png");
            // 
            // homePanel
            // 
            this.homePanel.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.PanelBG;
            this.homePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homePanel.Controls.Add(this.label1);
            this.homePanel.Location = new System.Drawing.Point(151, 83);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(200, 100);
            this.homePanel.TabIndex = 10;
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
            // topPanel
            // 
            this.topPanel.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.TopPanel;
            this.topPanel.Controls.Add(this.ExitButton);
            this.topPanel.Controls.Add(this.navigationLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(125, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1601, 60);
            this.topPanel.TabIndex = 9;
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
            this.sidePanel.Size = new System.Drawing.Size(125, 1061);
            this.sidePanel.TabIndex = 8;
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
            this.staffsButton.TabIndex = 6;
            this.staffsButton.Text = "\r\nStaffs";
            this.staffsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.staffsButton.UseVisualStyleBackColor = false;
            this.staffsButton.Click += new System.EventHandler(this.staffsButton_Click);
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
            // staffsPanel
            // 
            this.staffsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("staffsPanel.BackgroundImage")));
            this.staffsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.staffsPanel.Controls.Add(this.panel2);
            this.staffsPanel.Controls.Add(this.btnStaffEdit);
            this.staffsPanel.Controls.Add(this.txtStaffSearch);
            this.staffsPanel.Controls.Add(this.label8);
            this.staffsPanel.Controls.Add(this.panel4);
            this.staffsPanel.Location = new System.Drawing.Point(195, 114);
            this.staffsPanel.Name = "staffsPanel";
            this.staffsPanel.Size = new System.Drawing.Size(1467, 991);
            this.staffsPanel.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtEmail2);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.comboRoleStaffs);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.emailLabel);
            this.panel2.Controls.Add(this.comboCivilStatus);
            this.panel2.Controls.Add(this.civilStatusLabel);
            this.panel2.Controls.Add(this.comboGender);
            this.panel2.Controls.Add(this.genderLabel);
            this.panel2.Controls.Add(this.dateTimeBirthdate);
            this.panel2.Controls.Add(this.bdayLabel);
            this.panel2.Controls.Add(this.btnStaffAdd);
            this.panel2.Controls.Add(this.btnStaffCancel);
            this.panel2.Controls.Add(this.txtLn);
            this.panel2.Controls.Add(this.txtMn);
            this.panel2.Controls.Add(this.txtFn);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(771, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(447, 549);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.TopPanel;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(443, 42);
            this.panel3.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(66, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = "Add Staff";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "@";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmail2
            // 
            this.txtEmail2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail2.Location = new System.Drawing.Point(216, 383);
            this.txtEmail2.Name = "txtEmail2";
            this.txtEmail2.Size = new System.Drawing.Size(82, 25);
            this.txtEmail2.TabIndex = 33;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(33, 383);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(119, 25);
            this.txtEmail.TabIndex = 32;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboRoleStaffs
            // 
            this.comboRoleStaffs.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRoleStaffs.FormattingEnabled = true;
            this.comboRoleStaffs.Items.AddRange(new object[] {
            "",
            "Registrar",
            "Supervising Custodian",
            "Supervisor",
            "Monitor"});
            this.comboRoleStaffs.Location = new System.Drawing.Point(33, 433);
            this.comboRoleStaffs.Name = "comboRoleStaffs";
            this.comboRoleStaffs.Size = new System.Drawing.Size(116, 25);
            this.comboRoleStaffs.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Role:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(30, 357);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(143, 17);
            this.emailLabel.TabIndex = 25;
            this.emailLabel.Text = "E-Mail Address:";
            // 
            // comboCivilStatus
            // 
            this.comboCivilStatus.AutoCompleteCustomSource.AddRange(new string[] {
            "",
            "Married",
            "Single",
            "Widowed"});
            this.comboCivilStatus.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCivilStatus.FormattingEnabled = true;
            this.comboCivilStatus.Items.AddRange(new object[] {
            "",
            "Single",
            "Married"});
            this.comboCivilStatus.Location = new System.Drawing.Point(33, 318);
            this.comboCivilStatus.Name = "comboCivilStatus";
            this.comboCivilStatus.Size = new System.Drawing.Size(116, 25);
            this.comboCivilStatus.TabIndex = 24;
            // 
            // civilStatusLabel
            // 
            this.civilStatusLabel.AutoSize = true;
            this.civilStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.civilStatusLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.civilStatusLabel.Location = new System.Drawing.Point(30, 298);
            this.civilStatusLabel.Name = "civilStatusLabel";
            this.civilStatusLabel.Size = new System.Drawing.Size(125, 17);
            this.civilStatusLabel.TabIndex = 23;
            this.civilStatusLabel.Text = "Civil Status:";
            // 
            // comboGender
            // 
            this.comboGender.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "",
            "Male",
            "Female"});
            this.comboGender.Location = new System.Drawing.Point(33, 270);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(113, 25);
            this.comboGender.TabIndex = 22;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.BackColor = System.Drawing.Color.Transparent;
            this.genderLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(30, 250);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(80, 17);
            this.genderLabel.TabIndex = 21;
            this.genderLabel.Text = "Gender: ";
            // 
            // dateTimeBirthdate
            // 
            this.dateTimeBirthdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeBirthdate.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeBirthdate.Location = new System.Drawing.Point(33, 221);
            this.dateTimeBirthdate.MaxDate = new System.DateTime(2018, 8, 2, 0, 0, 0, 0);
            this.dateTimeBirthdate.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimeBirthdate.Name = "dateTimeBirthdate";
            this.dateTimeBirthdate.Size = new System.Drawing.Size(222, 26);
            this.dateTimeBirthdate.TabIndex = 20;
            this.dateTimeBirthdate.Value = new System.DateTime(2018, 8, 2, 0, 0, 0, 0);
            // 
            // bdayLabel
            // 
            this.bdayLabel.AutoSize = true;
            this.bdayLabel.BackColor = System.Drawing.Color.Transparent;
            this.bdayLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdayLabel.Location = new System.Drawing.Point(30, 201);
            this.bdayLabel.Name = "bdayLabel";
            this.bdayLabel.Size = new System.Drawing.Size(98, 17);
            this.bdayLabel.TabIndex = 19;
            this.bdayLabel.Text = "Birthdate:";
            // 
            // btnStaffAdd
            // 
            this.btnStaffAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(220)))), ((int)(((byte)(129)))));
            this.btnStaffAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(1)))));
            this.btnStaffAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(65)))));
            this.btnStaffAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffAdd.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffAdd.ImageKey = "(none)";
            this.btnStaffAdd.ImageList = this.smallerIcons;
            this.btnStaffAdd.Location = new System.Drawing.Point(190, 480);
            this.btnStaffAdd.Name = "btnStaffAdd";
            this.btnStaffAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStaffAdd.Size = new System.Drawing.Size(152, 53);
            this.btnStaffAdd.TabIndex = 18;
            this.btnStaffAdd.Text = "Add";
            this.btnStaffAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStaffAdd.UseVisualStyleBackColor = false;
            // 
            // btnStaffCancel
            // 
            this.btnStaffCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(92)))), ((int)(((byte)(76)))));
            this.btnStaffCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(12)))));
            this.btnStaffCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(60)))), ((int)(((byte)(44)))));
            this.btnStaffCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffCancel.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffCancel.ImageKey = "(none)";
            this.btnStaffCancel.ImageList = this.smallerIcons;
            this.btnStaffCancel.Location = new System.Drawing.Point(18, 480);
            this.btnStaffCancel.Name = "btnStaffCancel";
            this.btnStaffCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStaffCancel.Size = new System.Drawing.Size(137, 53);
            this.btnStaffCancel.TabIndex = 17;
            this.btnStaffCancel.Text = "Cancel";
            this.btnStaffCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStaffCancel.UseVisualStyleBackColor = false;
            // 
            // txtLn
            // 
            this.txtLn.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLn.Location = new System.Drawing.Point(33, 171);
            this.txtLn.Name = "txtLn";
            this.txtLn.Size = new System.Drawing.Size(222, 25);
            this.txtLn.TabIndex = 5;
            this.txtLn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMn
            // 
            this.txtMn.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMn.Location = new System.Drawing.Point(33, 121);
            this.txtMn.Name = "txtMn";
            this.txtMn.Size = new System.Drawing.Size(222, 25);
            this.txtMn.TabIndex = 4;
            this.txtMn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFn
            // 
            this.txtFn.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFn.Location = new System.Drawing.Point(33, 71);
            this.txtFn.Name = "txtFn";
            this.txtFn.Size = new System.Drawing.Size(222, 25);
            this.txtFn.TabIndex = 3;
            this.txtFn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFn.TextChanged += new System.EventHandler(this.txtFn_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Last Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Middle Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "First Name:";
            // 
            // btnStaffEdit
            // 
            this.btnStaffEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(75)))));
            this.btnStaffEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.btnStaffEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnStaffEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffEdit.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffEdit.ImageKey = "(none)";
            this.btnStaffEdit.ImageList = this.smallerIcons;
            this.btnStaffEdit.Location = new System.Drawing.Point(427, 9);
            this.btnStaffEdit.Name = "btnStaffEdit";
            this.btnStaffEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStaffEdit.Size = new System.Drawing.Size(89, 34);
            this.btnStaffEdit.TabIndex = 12;
            this.btnStaffEdit.Text = "Edit";
            this.btnStaffEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStaffEdit.UseVisualStyleBackColor = false;
            // 
            // txtStaffSearch
            // 
            this.txtStaffSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtStaffSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStaffSearch.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffSearch.Location = new System.Drawing.Point(138, 9);
            this.txtStaffSearch.Name = "txtStaffSearch";
            this.txtStaffSearch.Size = new System.Drawing.Size(272, 34);
            this.txtStaffSearch.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 27);
            this.label8.TabIndex = 14;
            this.label8.Text = "Search: ";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.staffListGridView);
            this.panel4.Location = new System.Drawing.Point(11, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(750, 550);
            this.panel4.TabIndex = 13;
            // 
            // staffListGridView
            // 
            this.staffListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffListGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffListGridView.Location = new System.Drawing.Point(0, 0);
            this.staffListGridView.Name = "staffListGridView";
            this.staffListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.staffListGridView.Size = new System.Drawing.Size(748, 548);
            this.staffListGridView.TabIndex = 0;
            // 
            // HRMForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.PanelBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1726, 1061);
            this.Controls.Add(this.staffsPanel);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.sidePanel);
            this.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HRMForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HRMForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HRMForm_FormClosing);
            this.Load += new System.EventHandler(this.HRMForm_Load);
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.staffsPanel.ResumeLayout(false);
            this.staffsPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.staffListGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList smallerIcons;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ImageList Icons;
        private System.Windows.Forms.Label navigationLabel;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button staffsButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel staffsPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox comboRoleStaffs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.ComboBox comboCivilStatus;
        private System.Windows.Forms.Label civilStatusLabel;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.DateTimePicker dateTimeBirthdate;
        private System.Windows.Forms.Label bdayLabel;
        private System.Windows.Forms.Button btnStaffAdd;
        private System.Windows.Forms.Button btnStaffCancel;
        private System.Windows.Forms.TextBox txtLn;
        private System.Windows.Forms.TextBox txtMn;
        private System.Windows.Forms.TextBox txtFn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnStaffEdit;
        private System.Windows.Forms.TextBox txtStaffSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView staffListGridView;
    }
}