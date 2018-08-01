using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Modules : Form
    {
        public Login reference { get; set; }

        private string loginName;

        public Modules(String role)
        {
            InitializeComponent();
            loginName = role;
        }
        public Modules()
        {
            InitializeComponent();
        }
        //
        //-------->Form Initialization<--------
        //
        private void Modules_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome back, " + loginName;
            //Sets Proper Form Size
            this.Size = new Size(1200, 675);

            //Sets HomePanel to Fill
            homePanel.Dock = DockStyle.Fill;

            //Sets AccountsPanel to Fill
            accountsPanel.Visible = false;
            accountsPanel.Dock = DockStyle.Fill;
        }
        //
        //-------->Navigation Buttons<--------
        //
        private void accountsButton_Click(object sender, EventArgs e)
        {
            //Switches Button BackColors
            homeButton.BackColor = Color.Transparent;
            accountsButton.BackColor = Color.FromArgb(57, 213, 255);

            //Switches Panel Visibility
            homePanel.Visible = false;
            accountsPanel.Visible = true;

            //Changes Label
            navigationLabel.Text = "Accounts";
        }
        private void homeButton_Click(object sender, EventArgs e)
        {
            //Switches Button BackColors
            homeButton.BackColor = Color.FromArgb(57, 213, 255);
            accountsButton.BackColor = Color.Transparent;

            //Switches Panel Visibility
            homePanel.Visible = true;
            accountsPanel.Visible = false;

            //Changes Label
            navigationLabel.Text = "Home";
        }
        //
        //-------->Exit Buttons<--------
        //
        private void Modules_FormClosing(object sender, FormClosingEventArgs e)
        {
            reference.Show();
        }
        private void signOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
