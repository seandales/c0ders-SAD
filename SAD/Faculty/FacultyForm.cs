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
    public partial class FacultyForm : Form
    {
        public Login reference { get; set; }
        private string loginName;
        //
        //-------->Form Initialization<--------
        //
        public FacultyForm()
        {
            InitializeComponent();
        }
        public FacultyForm(String role)
        {
            InitializeComponent();
            loginName = role;
        }
        public void showPrescriptions(Boolean b)
        {
            prescriptionsButton.Visible = b;
        }
        private void HRMForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome back, " + loginName;

            //Sets Proper Form Size
            this.Size = new Size(1200, 675);

            //Sets All Panels to Fill
            homePanel.Dock = DockStyle.Fill;

            //Hides All Other Panels
        }
        //
        //-------->Navigation Buttons<--------
        //
        private void homeButton_Click(object sender, EventArgs e)
        {
            //Switches Button BackColors
            homeButton.BackColor = Color.FromArgb(57, 213, 255);
            studentsButton.BackColor = Color.Transparent;
            prescriptionsButton.BackColor = Color.Transparent;

            //Switches Panel Visibility
            homePanel.Visible = true;

            //Changes Label
            navigationLabel.Text = "Home";
        }
        private void studentsButton_Click(object sender, EventArgs e)
        {
            //Switches Button BackColors
            homeButton.BackColor = Color.Transparent;
            studentsButton.BackColor = Color.FromArgb(57, 213, 255);
            prescriptionsButton.BackColor = Color.Transparent;

            //Switches Panel Visibility
            homePanel.Visible = false;
        //    studentsPanel.Visible = true;
        //    prescriptionsPanel.Visible = false;

            //Changes Label
            navigationLabel.Text = "Students";
        }
        private void prescriptionsButton_Click(object sender, EventArgs e)
        {
            //Switches Button BackColors
            homeButton.BackColor = Color.Transparent;
            studentsButton.BackColor = Color.Transparent;
            prescriptionsButton.BackColor = Color.FromArgb(57, 213, 255);

            //Switches Panel Visibility
            homePanel.Visible = false;
        //    studentsPanel.Visible = false;
        //    prescriptionsPanel.Visible = true;

            //Changes Label
            navigationLabel.Text = "Prescriptions";
        }
        //
        //-------->Exit Buttons<--------
        //
        private void signOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FacultyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            reference.Show();
        }
    }
}