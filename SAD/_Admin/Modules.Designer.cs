﻿namespace WindowsFormsApp4
{
    partial class Modules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modules));
            this.label1 = new System.Windows.Forms.Label();
            this.Icons = new System.Windows.Forms.ImageList(this.components);
            this.accountsPanel = new System.Windows.Forms.Panel();
            this.addPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addUserLabel = new System.Windows.Forms.Label();
            this.comboRoleAccounts = new System.Windows.Forms.ComboBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.smallerIcons = new System.Windows.Forms.ImageList(this.components);
            this.clearButton = new System.Windows.Forms.Button();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lnLabel = new System.Windows.Forms.Label();
            this.mnLabel = new System.Windows.Forms.Label();
            this.fnLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.accountListGridView = new System.Windows.Forms.DataGridView();
            this.homePanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.navigationLabel = new System.Windows.Forms.Label();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.staffsButton = new System.Windows.Forms.Button();
            this.accountsButton = new System.Windows.Forms.Button();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtLn = new System.Windows.Forms.TextBox();
            this.txtMn = new System.Windows.Forms.TextBox();
            this.txtFn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.staffListGridView = new System.Windows.Forms.DataGridView();
            this.editButton = new System.Windows.Forms.Button();
            this.accountsPanel.SuspendLayout();
            this.addPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.displayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountListGridView)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status";
            // 
            // Icons
            // 
            this.Icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Icons.ImageStream")));
            this.Icons.TransparentColor = System.Drawing.Color.Transparent;
            this.Icons.Images.SetKeyName(0, "X Icon.jpg");
            this.Icons.Images.SetKeyName(1, "Home.png");
            this.Icons.Images.SetKeyName(2, "SignOut.png");
            this.Icons.Images.SetKeyName(3, "Accounts.png");
            this.Icons.Images.SetKeyName(4, "account.png");
            // 
            // accountsPanel
            // 
            this.accountsPanel.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.PanelBG;
            this.accountsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.accountsPanel.Controls.Add(this.editButton);
            this.accountsPanel.Controls.Add(this.addPanel);
            this.accountsPanel.Controls.Add(this.textBox1);
            this.accountsPanel.Controls.Add(this.searchLabel);
            this.accountsPanel.Controls.Add(this.displayPanel);
            this.accountsPanel.Location = new System.Drawing.Point(130, 70);
            this.accountsPanel.Name = "accountsPanel";
            this.accountsPanel.Size = new System.Drawing.Size(1070, 775);
            this.accountsPanel.TabIndex = 7;
            this.accountsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.accountsPanel_Paint);
            // 
            // addPanel
            // 
            this.addPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addPanel.BackgroundImage")));
            this.addPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addPanel.Controls.Add(this.panel1);
            this.addPanel.Controls.Add(this.comboRoleAccounts);
            this.addPanel.Controls.Add(this.roleLabel);
            this.addPanel.Controls.Add(this.btnAdd);
            this.addPanel.Controls.Add(this.clearButton);
            this.addPanel.Controls.Add(this.txtPass2);
            this.addPanel.Controls.Add(this.txtPass);
            this.addPanel.Controls.Add(this.txtUser);
            this.addPanel.Controls.Add(this.lnLabel);
            this.addPanel.Controls.Add(this.mnLabel);
            this.addPanel.Controls.Add(this.fnLabel);
            this.addPanel.Location = new System.Drawing.Point(771, 51);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(292, 550);
            this.addPanel.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.TopPanel;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.addUserLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 42);
            this.panel1.TabIndex = 36;
            // 
            // addUserLabel
            // 
            this.addUserLabel.AutoSize = true;
            this.addUserLabel.BackColor = System.Drawing.Color.Transparent;
            this.addUserLabel.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserLabel.ForeColor = System.Drawing.Color.Black;
            this.addUserLabel.Location = new System.Drawing.Point(68, 9);
            this.addUserLabel.Name = "addUserLabel";
            this.addUserLabel.Size = new System.Drawing.Size(365, 68);
            this.addUserLabel.TabIndex = 16;
            this.addUserLabel.Text = "Add User";
            // 
            // comboRoleAccounts
            // 
            this.comboRoleAccounts.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRoleAccounts.FormattingEnabled = true;
            this.comboRoleAccounts.Items.AddRange(new object[] {
            "",
            "Admin",
            "Principal",
            "Human Resource Manager",
            "Registrar",
            "Supervising Custodian",
            "Supervisor",
            "Monitor"});
            this.comboRoleAccounts.Location = new System.Drawing.Point(33, 230);
            this.comboRoleAccounts.Name = "comboRoleAccounts";
            this.comboRoleAccounts.Size = new System.Drawing.Size(116, 50);
            this.comboRoleAccounts.TabIndex = 28;
            this.comboRoleAccounts.SelectedIndexChanged += new System.EventHandler(this.comboRoleAccounts_SelectedIndexChanged);
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.BackColor = System.Drawing.Color.Transparent;
            this.roleLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.Location = new System.Drawing.Point(30, 210);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(134, 43);
            this.roleLabel.TabIndex = 27;
            this.roleLabel.Text = "Role:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(220)))), ((int)(((byte)(129)))));
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(1)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(65)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ImageKey = "(none)";
            this.btnAdd.ImageList = this.smallerIcons;
            this.btnAdd.Location = new System.Drawing.Point(156, 491);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.Size = new System.Drawing.Size(100, 34);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(92)))), ((int)(((byte)(76)))));
            this.clearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(12)))));
            this.clearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(60)))), ((int)(((byte)(44)))));
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ImageKey = "(none)";
            this.clearButton.ImageList = this.smallerIcons;
            this.clearButton.Location = new System.Drawing.Point(33, 491);
            this.clearButton.Name = "clearButton";
            this.clearButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clearButton.Size = new System.Drawing.Size(100, 34);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "Cancel";
            this.clearButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click_1);
            // 
            // txtPass2
            // 
            this.txtPass2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass2.Location = new System.Drawing.Point(33, 182);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.PasswordChar = '*';
            this.txtPass2.Size = new System.Drawing.Size(222, 52);
            this.txtPass2.TabIndex = 5;
            this.txtPass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPass2.TextChanged += new System.EventHandler(this.Textbox_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(33, 134);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(222, 52);
            this.txtPass.TabIndex = 4;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPass.TextChanged += new System.EventHandler(this.Textbox_TextChanged);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(33, 86);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(222, 52);
            this.txtUser.TabIndex = 3;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUser.TextChanged += new System.EventHandler(this.Textbox_TextChanged);
            // 
            // lnLabel
            // 
            this.lnLabel.AutoSize = true;
            this.lnLabel.BackColor = System.Drawing.Color.Transparent;
            this.lnLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnLabel.Location = new System.Drawing.Point(30, 162);
            this.lnLabel.Name = "lnLabel";
            this.lnLabel.Size = new System.Drawing.Size(387, 43);
            this.lnLabel.TabIndex = 2;
            this.lnLabel.Text = "Repeat Password:";
            // 
            // mnLabel
            // 
            this.mnLabel.AutoSize = true;
            this.mnLabel.BackColor = System.Drawing.Color.Transparent;
            this.mnLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnLabel.Location = new System.Drawing.Point(30, 114);
            this.mnLabel.Name = "mnLabel";
            this.mnLabel.Size = new System.Drawing.Size(226, 43);
            this.mnLabel.TabIndex = 1;
            this.mnLabel.Text = "Password:";
            // 
            // fnLabel
            // 
            this.fnLabel.AutoSize = true;
            this.fnLabel.BackColor = System.Drawing.Color.Transparent;
            this.fnLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnLabel.Location = new System.Drawing.Point(30, 66);
            this.fnLabel.Name = "fnLabel";
            this.fnLabel.Size = new System.Drawing.Size(226, 43);
            this.fnLabel.TabIndex = 0;
            this.fnLabel.Text = "Username:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(138, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 75);
            this.textBox1.TabIndex = 11;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchLabel.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.Black;
            this.searchLabel.Location = new System.Drawing.Point(6, 12);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(365, 68);
            this.searchLabel.TabIndex = 14;
            this.searchLabel.Text = "Search: ";
            // 
            // displayPanel
            // 
            this.displayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayPanel.Controls.Add(this.accountListGridView);
            this.displayPanel.Location = new System.Drawing.Point(11, 51);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(750, 550);
            this.displayPanel.TabIndex = 13;
            // 
            // accountListGridView
            // 
            this.accountListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountListGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountListGridView.Location = new System.Drawing.Point(0, 0);
            this.accountListGridView.Name = "accountListGridView";
            this.accountListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accountListGridView.Size = new System.Drawing.Size(748, 548);
            this.accountListGridView.TabIndex = 0;
            this.accountListGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountListGridView_CellContentClick);
            // 
            // homePanel
            // 
            this.homePanel.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.PanelBG;
            this.homePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homePanel.Controls.Add(this.label1);
            this.homePanel.Location = new System.Drawing.Point(671, 67);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(200, 100);
            this.homePanel.TabIndex = 6;
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
            this.topPanel.Size = new System.Drawing.Size(1726, 60);
            this.topPanel.TabIndex = 5;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint_1);
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
            this.navigationLabel.Size = new System.Drawing.Size(342, 120);
            this.navigationLabel.TabIndex = 0;
            this.navigationLabel.Text = "Home";
            // 
            // sidePanel
            // 
            this.sidePanel.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.SidePanel1;
            this.sidePanel.Controls.Add(this.staffsButton);
            this.sidePanel.Controls.Add(this.accountsButton);
            this.sidePanel.Controls.Add(this.homeButton);
            this.sidePanel.Controls.Add(this.signOutButton);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(125, 1560);
            this.sidePanel.TabIndex = 4;
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
            this.staffsButton.TabIndex = 7;
            this.staffsButton.Text = "\r\nStaffs";
            this.staffsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.staffsButton.UseVisualStyleBackColor = false;
            this.staffsButton.Click += new System.EventHandler(this.staffsButton_Click);
            // 
            // accountsButton
            // 
            this.accountsButton.BackColor = System.Drawing.Color.Transparent;
            this.accountsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accountsButton.FlatAppearance.BorderSize = 0;
            this.accountsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.accountsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.accountsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountsButton.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsButton.ForeColor = System.Drawing.Color.Black;
            this.accountsButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.accountsButton.ImageKey = "account.png";
            this.accountsButton.ImageList = this.Icons;
            this.accountsButton.Location = new System.Drawing.Point(0, 250);
            this.accountsButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.accountsButton.Name = "accountsButton";
            this.accountsButton.Size = new System.Drawing.Size(125, 125);
            this.accountsButton.TabIndex = 6;
            this.accountsButton.Text = "Accounts";
            this.accountsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.accountsButton.UseVisualStyleBackColor = false;
            this.accountsButton.Click += new System.EventHandler(this.accountsButton_Click);
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
            this.staffsPanel.Controls.Add(this.button3);
            this.staffsPanel.Controls.Add(this.textBox2);
            this.staffsPanel.Controls.Add(this.label8);
            this.staffsPanel.Controls.Add(this.panel4);
            this.staffsPanel.Location = new System.Drawing.Point(268, 826);
            this.staffsPanel.Name = "staffsPanel";
            this.staffsPanel.Size = new System.Drawing.Size(1321, 615);
            this.staffsPanel.TabIndex = 12;
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
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txtLn);
            this.panel2.Controls.Add(this.txtMn);
            this.panel2.Controls.Add(this.txtFn);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(771, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 550);
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
            this.panel3.Size = new System.Drawing.Size(288, 42);
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
            this.label2.Size = new System.Drawing.Size(407, 68);
            this.label2.TabIndex = 16;
            this.label2.Text = "Add Staff";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 44);
            this.label3.TabIndex = 34;
            this.label3.Text = "@";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmail2
            // 
            this.txtEmail2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail2.Location = new System.Drawing.Point(173, 371);
            this.txtEmail2.Name = "txtEmail2";
            this.txtEmail2.Size = new System.Drawing.Size(82, 52);
            this.txtEmail2.TabIndex = 33;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(33, 371);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(119, 52);
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
            this.comboRoleStaffs.Location = new System.Drawing.Point(33, 421);
            this.comboRoleStaffs.Name = "comboRoleStaffs";
            this.comboRoleStaffs.Size = new System.Drawing.Size(116, 50);
            this.comboRoleStaffs.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 43);
            this.label4.TabIndex = 27;
            this.label4.Text = "Role:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(30, 351);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(364, 43);
            this.emailLabel.TabIndex = 25;
            this.emailLabel.Text = "E-Mail Address:";
            // 
            // comboCivilStatus
            // 
            this.comboCivilStatus.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCivilStatus.FormattingEnabled = true;
            this.comboCivilStatus.Items.AddRange(new object[] {
            "",
            "Single",
            "Married"});
            this.comboCivilStatus.Location = new System.Drawing.Point(33, 321);
            this.comboCivilStatus.Name = "comboCivilStatus";
            this.comboCivilStatus.Size = new System.Drawing.Size(116, 50);
            this.comboCivilStatus.TabIndex = 24;
            // 
            // civilStatusLabel
            // 
            this.civilStatusLabel.AutoSize = true;
            this.civilStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.civilStatusLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.civilStatusLabel.Location = new System.Drawing.Point(30, 301);
            this.civilStatusLabel.Name = "civilStatusLabel";
            this.civilStatusLabel.Size = new System.Drawing.Size(318, 43);
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
            this.comboGender.Location = new System.Drawing.Point(33, 271);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(113, 50);
            this.comboGender.TabIndex = 22;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.BackColor = System.Drawing.Color.Transparent;
            this.genderLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(30, 251);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(203, 43);
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
            this.dateTimeBirthdate.Size = new System.Drawing.Size(222, 54);
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
            this.bdayLabel.Size = new System.Drawing.Size(249, 43);
            this.bdayLabel.TabIndex = 19;
            this.bdayLabel.Text = "Birthdate:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(220)))), ((int)(((byte)(129)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(1)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(65)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageKey = "(none)";
            this.button1.ImageList = this.smallerIcons;
            this.button1.Location = new System.Drawing.Point(157, 491);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(92)))), ((int)(((byte)(76)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(12)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(60)))), ((int)(((byte)(44)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageKey = "(none)";
            this.button2.ImageList = this.smallerIcons;
            this.button2.Location = new System.Drawing.Point(33, 491);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(100, 34);
            this.button2.TabIndex = 17;
            this.button2.Text = "Cancel";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txtLn
            // 
            this.txtLn.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLn.Location = new System.Drawing.Point(33, 171);
            this.txtLn.Name = "txtLn";
            this.txtLn.Size = new System.Drawing.Size(222, 52);
            this.txtLn.TabIndex = 5;
            this.txtLn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMn
            // 
            this.txtMn.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMn.Location = new System.Drawing.Point(33, 121);
            this.txtMn.Name = "txtMn";
            this.txtMn.Size = new System.Drawing.Size(222, 52);
            this.txtMn.TabIndex = 4;
            this.txtMn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFn
            // 
            this.txtFn.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFn.Location = new System.Drawing.Point(33, 71);
            this.txtFn.Name = "txtFn";
            this.txtFn.Size = new System.Drawing.Size(222, 52);
            this.txtFn.TabIndex = 3;
            this.txtFn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 43);
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
            this.label6.Size = new System.Drawing.Size(295, 43);
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
            this.label7.Size = new System.Drawing.Size(272, 43);
            this.label7.TabIndex = 0;
            this.label7.Text = "First Name:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(75)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageKey = "(none)";
            this.button3.ImageList = this.smallerIcons;
            this.button3.Location = new System.Drawing.Point(427, 9);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(89, 34);
            this.button3.TabIndex = 12;
            this.button3.Text = "Edit";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(138, 9);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(272, 75);
            this.textBox2.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(365, 68);
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
            this.staffListGridView.Size = new System.Drawing.Size(748, 548);
            this.staffListGridView.TabIndex = 0;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(75)))));
            this.editButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.editButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ImageKey = "(none)";
            this.editButton.ImageList = this.smallerIcons;
            this.editButton.Location = new System.Drawing.Point(420, 25);
            this.editButton.Name = "editButton";
            this.editButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editButton.Size = new System.Drawing.Size(89, 34);
            this.editButton.TabIndex = 16;
            this.editButton.Text = "Edit";
            this.editButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click_2);
            // 
            // Modules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.PanelBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1851, 1560);
            this.Controls.Add(this.staffsPanel);
            this.Controls.Add(this.accountsPanel);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.sidePanel);
            this.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Modules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Modules_FormClosing);
            this.Load += new System.EventHandler(this.Modules_Load);
            this.accountsPanel.ResumeLayout(false);
            this.accountsPanel.PerformLayout();
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.displayPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountListGridView)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label navigationLabel;
        private System.Windows.Forms.ImageList Icons;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button accountsButton;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Panel accountsPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.ImageList smallerIcons;
        private System.Windows.Forms.Label addUserLabel;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox txtPass2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lnLabel;
        private System.Windows.Forms.Label mnLabel;
        private System.Windows.Forms.Label fnLabel;
        private System.Windows.Forms.ComboBox comboRoleAccounts;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.DataGridView accountListGridView;
        private System.Windows.Forms.Button staffsButton;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtLn;
        private System.Windows.Forms.TextBox txtMn;
        private System.Windows.Forms.TextBox txtFn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView staffListGridView;
        private System.Windows.Forms.Button editButton;
    }
}