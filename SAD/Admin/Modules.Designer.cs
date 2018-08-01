namespace WindowsFormsApp4
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
            this.addUserLabel = new System.Windows.Forms.Label();
            this.smallerIcons = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.homePanel = new System.Windows.Forms.Panel();
            this.addPanel = new System.Windows.Forms.Panel();
            this.editButton = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.navigationLabel = new System.Windows.Forms.Label();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.accountsButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.signOutButton = new System.Windows.Forms.Button();
            this.fnLabel = new System.Windows.Forms.Label();
            this.mnLabel = new System.Windows.Forms.Label();
            this.lnLabel = new System.Windows.Forms.Label();
            this.fnTextbox = new System.Windows.Forms.TextBox();
            this.mnTextbox = new System.Windows.Forms.TextBox();
            this.lnTextbox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.bdayLabel = new System.Windows.Forms.Label();
            this.bdayDate = new System.Windows.Forms.DateTimePicker();
            this.genderLabel = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.civilStatusLabel = new System.Windows.Forms.Label();
            this.civilStatusComboBox = new System.Windows.Forms.ComboBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.accountsPanel.SuspendLayout();
            this.displayPanel.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.addPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
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
            // 
            // accountsPanel
            // 
            this.accountsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.accountsPanel.Controls.Add(this.addUserLabel);
            this.accountsPanel.Controls.Add(this.addPanel);
            this.accountsPanel.Controls.Add(this.editButton);
            this.accountsPanel.Controls.Add(this.textBox1);
            this.accountsPanel.Controls.Add(this.searchLabel);
            this.accountsPanel.Controls.Add(this.displayPanel);
            this.accountsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountsPanel.Location = new System.Drawing.Point(125, 60);
            this.accountsPanel.Name = "accountsPanel";
            this.accountsPanel.Size = new System.Drawing.Size(1075, 615);
            this.accountsPanel.TabIndex = 7;
            // 
            // addUserLabel
            // 
            this.addUserLabel.AutoSize = true;
            this.addUserLabel.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserLabel.ForeColor = System.Drawing.Color.Black;
            this.addUserLabel.Location = new System.Drawing.Point(843, 16);
            this.addUserLabel.Name = "addUserLabel";
            this.addUserLabel.Size = new System.Drawing.Size(148, 27);
            this.addUserLabel.TabIndex = 16;
            this.addUserLabel.Text = "Add User";
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(138, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 34);
            this.textBox1.TabIndex = 11;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.Black;
            this.searchLabel.Location = new System.Drawing.Point(6, 12);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(148, 27);
            this.searchLabel.TabIndex = 14;
            this.searchLabel.Text = "Search: ";
            // 
            // displayPanel
            // 
            this.displayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayPanel.Controls.Add(this.dataGridView1);
            this.displayPanel.Location = new System.Drawing.Point(11, 51);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(750, 550);
            this.displayPanel.TabIndex = 13;
            // 
            // homePanel
            // 
            this.homePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homePanel.Controls.Add(this.label1);
            this.homePanel.Location = new System.Drawing.Point(125, 60);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(200, 100);
            this.homePanel.TabIndex = 6;
            // 
            // addPanel
            // 
            this.addPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addPanel.BackgroundImage")));
            this.addPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addPanel.Controls.Add(this.comboBox1);
            this.addPanel.Controls.Add(this.roleLabel);
            this.addPanel.Controls.Add(this.textBox2);
            this.addPanel.Controls.Add(this.emailLabel);
            this.addPanel.Controls.Add(this.civilStatusComboBox);
            this.addPanel.Controls.Add(this.civilStatusLabel);
            this.addPanel.Controls.Add(this.genderComboBox);
            this.addPanel.Controls.Add(this.genderLabel);
            this.addPanel.Controls.Add(this.bdayDate);
            this.addPanel.Controls.Add(this.bdayLabel);
            this.addPanel.Controls.Add(this.addButton);
            this.addPanel.Controls.Add(this.clearButton);
            this.addPanel.Controls.Add(this.lnTextbox);
            this.addPanel.Controls.Add(this.mnTextbox);
            this.addPanel.Controls.Add(this.fnTextbox);
            this.addPanel.Controls.Add(this.lnLabel);
            this.addPanel.Controls.Add(this.mnLabel);
            this.addPanel.Controls.Add(this.fnLabel);
            this.addPanel.Location = new System.Drawing.Point(771, 51);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(292, 550);
            this.addPanel.TabIndex = 15;
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
            this.editButton.Location = new System.Drawing.Point(427, 9);
            this.editButton.Name = "editButton";
            this.editButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editButton.Size = new System.Drawing.Size(89, 34);
            this.editButton.TabIndex = 12;
            this.editButton.Text = "Edit";
            this.editButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.editButton.UseVisualStyleBackColor = false;
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
            this.topPanel.TabIndex = 5;
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
            this.sidePanel.Controls.Add(this.accountsButton);
            this.sidePanel.Controls.Add(this.homeButton);
            this.sidePanel.Controls.Add(this.signOutButton);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(125, 675);
            this.sidePanel.TabIndex = 4;
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
            this.accountsButton.ImageKey = "Accounts.png";
            this.accountsButton.ImageList = this.Icons;
            this.accountsButton.Location = new System.Drawing.Point(0, 125);
            this.accountsButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.accountsButton.Name = "accountsButton";
            this.accountsButton.Size = new System.Drawing.Size(125, 125);
            this.accountsButton.TabIndex = 6;
            this.accountsButton.Text = "\r\nAccounts";
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
            // fnLabel
            // 
            this.fnLabel.AutoSize = true;
            this.fnLabel.BackColor = System.Drawing.Color.Transparent;
            this.fnLabel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnLabel.Location = new System.Drawing.Point(90, 15);
            this.fnLabel.Name = "fnLabel";
            this.fnLabel.Size = new System.Drawing.Size(129, 16);
            this.fnLabel.TabIndex = 0;
            this.fnLabel.Text = "First Name:";
            // 
            // mnLabel
            // 
            this.mnLabel.AutoSize = true;
            this.mnLabel.BackColor = System.Drawing.Color.Transparent;
            this.mnLabel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnLabel.Location = new System.Drawing.Point(87, 75);
            this.mnLabel.Name = "mnLabel";
            this.mnLabel.Size = new System.Drawing.Size(140, 16);
            this.mnLabel.TabIndex = 1;
            this.mnLabel.Text = "Middle Name:";
            // 
            // lnLabel
            // 
            this.lnLabel.AutoSize = true;
            this.lnLabel.BackColor = System.Drawing.Color.Transparent;
            this.lnLabel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnLabel.Location = new System.Drawing.Point(98, 135);
            this.lnLabel.Name = "lnLabel";
            this.lnLabel.Size = new System.Drawing.Size(118, 16);
            this.lnLabel.TabIndex = 2;
            this.lnLabel.Text = "Last Name:";
            // 
            // fnTextbox
            // 
            this.fnTextbox.Location = new System.Drawing.Point(33, 40);
            this.fnTextbox.Name = "fnTextbox";
            this.fnTextbox.Size = new System.Drawing.Size(222, 23);
            this.fnTextbox.TabIndex = 3;
            this.fnTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mnTextbox
            // 
            this.mnTextbox.Location = new System.Drawing.Point(33, 100);
            this.mnTextbox.Name = "mnTextbox";
            this.mnTextbox.Size = new System.Drawing.Size(222, 23);
            this.mnTextbox.TabIndex = 4;
            this.mnTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lnTextbox
            // 
            this.lnTextbox.Location = new System.Drawing.Point(33, 160);
            this.lnTextbox.Name = "lnTextbox";
            this.lnTextbox.Size = new System.Drawing.Size(222, 23);
            this.lnTextbox.TabIndex = 5;
            this.lnTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(220)))), ((int)(((byte)(129)))));
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(1)))));
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(65)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ImageKey = "(none)";
            this.addButton.ImageList = this.smallerIcons;
            this.addButton.Location = new System.Drawing.Point(157, 491);
            this.addButton.Name = "addButton";
            this.addButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addButton.Size = new System.Drawing.Size(100, 34);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Add";
            this.addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // bdayLabel
            // 
            this.bdayLabel.AutoSize = true;
            this.bdayLabel.BackColor = System.Drawing.Color.Transparent;
            this.bdayLabel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdayLabel.Location = new System.Drawing.Point(98, 195);
            this.bdayLabel.Name = "bdayLabel";
            this.bdayLabel.Size = new System.Drawing.Size(118, 16);
            this.bdayLabel.TabIndex = 19;
            this.bdayLabel.Text = "Birthdate:";
            // 
            // bdayDate
            // 
            this.bdayDate.Location = new System.Drawing.Point(33, 220);
            this.bdayDate.MaxDate = new System.DateTime(2018, 8, 2, 0, 0, 0, 0);
            this.bdayDate.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.bdayDate.Name = "bdayDate";
            this.bdayDate.Size = new System.Drawing.Size(222, 23);
            this.bdayDate.TabIndex = 20;
            this.bdayDate.Value = new System.DateTime(2018, 8, 2, 0, 0, 0, 0);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.BackColor = System.Drawing.Color.Transparent;
            this.genderLabel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(37, 265);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(96, 16);
            this.genderLabel.TabIndex = 21;
            this.genderLabel.Text = "Gender: ";
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "",
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(139, 262);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(116, 24);
            this.genderComboBox.TabIndex = 22;
            // 
            // civilStatusLabel
            // 
            this.civilStatusLabel.AutoSize = true;
            this.civilStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.civilStatusLabel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.civilStatusLabel.Location = new System.Drawing.Point(74, 300);
            this.civilStatusLabel.Name = "civilStatusLabel";
            this.civilStatusLabel.Size = new System.Drawing.Size(151, 16);
            this.civilStatusLabel.TabIndex = 23;
            this.civilStatusLabel.Text = "Civil Status:";
            // 
            // civilStatusComboBox
            // 
            this.civilStatusComboBox.FormattingEnabled = true;
            this.civilStatusComboBox.Items.AddRange(new object[] {
            "",
            "Single",
            "Married"});
            this.civilStatusComboBox.Location = new System.Drawing.Point(90, 325);
            this.civilStatusComboBox.Name = "civilStatusComboBox";
            this.civilStatusComboBox.Size = new System.Drawing.Size(116, 24);
            this.civilStatusComboBox.TabIndex = 24;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(62, 360);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(173, 16);
            this.emailLabel.TabIndex = 25;
            this.emailLabel.Text = "E-Mail Address:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(33, 385);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 23);
            this.textBox2.TabIndex = 26;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.BackColor = System.Drawing.Color.Transparent;
            this.roleLabel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.Location = new System.Drawing.Point(52, 433);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(63, 16);
            this.roleLabel.TabIndex = 27;
            this.roleLabel.Text = "Role:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "Admin",
            "Principal",
            "Human Resource Manager",
            "Registrar",
            "Supervising Custodian",
            "Supervisor",
            "Monitor"});
            this.comboBox1.Location = new System.Drawing.Point(121, 430);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(116, 24);
            this.comboBox1.TabIndex = 28;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(748, 548);
            this.dataGridView1.TabIndex = 0;
            // 
            // Modules
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 675);
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
            this.Text = "Modules";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Modules_FormClosing);
            this.Load += new System.EventHandler(this.Modules_Load);
            this.accountsPanel.ResumeLayout(false);
            this.accountsPanel.PerformLayout();
            this.displayPanel.ResumeLayout(false);
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.ImageList smallerIcons;
        private System.Windows.Forms.Label addUserLabel;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox lnTextbox;
        private System.Windows.Forms.TextBox mnTextbox;
        private System.Windows.Forms.TextBox fnTextbox;
        private System.Windows.Forms.Label lnLabel;
        private System.Windows.Forms.Label mnLabel;
        private System.Windows.Forms.Label fnLabel;
        private System.Windows.Forms.Label bdayLabel;
        private System.Windows.Forms.DateTimePicker bdayDate;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label civilStatusLabel;
        private System.Windows.Forms.ComboBox civilStatusComboBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}