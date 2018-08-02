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
    public partial class HRMForm : Form
    {
        public Login reference { get; set; }

        private string loginName;

        public HRMForm(String role)
        {
            InitializeComponent();
            loginName = role;
        }
        public HRMForm()
        {
            InitializeComponent();
        }
        //
        //-------->Form Initialization<--------
        //
        private void HRMForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome back, " + loginName;

            //Sets Proper Form Size
            this.Size = new Size(1200, 675);

            //Sets All Panels to Fill
            homePanel.Dock = DockStyle.Fill;
            staffsPanel.Dock = DockStyle.Fill;

            //Hides All Other Panels
            staffsPanel.Visible = false;
        }
        //
        //-------->Navigation Buttons<--------
        //
        private void homeButton_Click(object sender, EventArgs e)
        {
            //Switches Button BackColors
            homeButton.BackColor = Color.FromArgb(57, 213, 255);
            staffsButton.BackColor = Color.Transparent;

            //Switches Panel Visibility
            homePanel.Visible = true;

            //Changes Label
            navigationLabel.Text = "Home";
        }
        private void staffsButton_Click(object sender, EventArgs e)
        {
            //Switches Button BackColors
            homeButton.BackColor = Color.Transparent;
            staffsButton.BackColor = Color.FromArgb(57, 213, 255);

            //Switches Panel Visibility
            homePanel.Visible = false;
            staffsPanel.Visible = true;

            //Changes Label
            navigationLabel.Text = "Accounts";
        }
        //
        //-------->Exit Buttons<--------
        //
        private void signOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void HRMForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            reference.Show();
        }
    }
}
