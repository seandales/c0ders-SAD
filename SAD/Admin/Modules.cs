﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp4
{
    public partial class Modules : Form
    {
        //public Staff_Manag_Form reference { get; set; }
        DbConnect conRef = new DbConnect();
        //Staff_Manag_Form frmObject = new Staff_Manag_Form();
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

            //Sets All Panels to Fill
            homePanel.Dock = DockStyle.Fill;
            accountsPanel.Dock = DockStyle.Fill;

            //Hides All Other Panels
            accountsPanel.Visible = false;
            readData();
        }
        //
        //-------->Navigation Buttons<--------
        //
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
        //
        //-------->Exit Buttons<--------
        //
        private void signOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Modules_FormClosing(object sender, FormClosingEventArgs e)
        {
            reference.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string strQuery = "INSERT INTO users(user_name, password, role) " +
                "VALUES (@user_name, @password, @role)";
            MySqlConnection con = conRef.connectFunc();
            MySqlCommand cmd = new MySqlCommand(strQuery, con);
            cmd.Parameters.AddWithValue("@user_name", txtfn1.Text);
            cmd.Parameters.AddWithValue("@password", txtpass1.Text);
            cmd.Parameters.AddWithValue("@role", combRole.Text);
            
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("successfully inserted");
            readData();
            //showPrevForm();
        }
        DbConnect connect = new DbConnect();
        MySqlDataAdapter da;
        DataTable dt;
        public void readData()
        {
            MySqlConnection con = connect.connectFunc();
            String query = "SELECT * FROM users";
            dt = new DataTable();
            da = new MySqlDataAdapter(query, con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //dt.Rows[0].Vi
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Textbox_TextChanged(object sender, EventArgs e)
        {
            /*
            if (String.IsNullOrWhiteSpace(txtfn1.Text)||String.IsNullOrWhiteSpace(txtpass1.Text))
            {
                btnAdd1.Enabled = false;
       
            }



            else
            {
                btnAdd1.Enabled = true;
            }
            */
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {

        }
        public void clear()
        {
            txtpass1.Text = ("");
            txtfn1.Text = ("");
        }
    }
}
