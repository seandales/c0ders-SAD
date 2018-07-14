using System;
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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void loginBut_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost; user id =root; database=sad_db; password=root;");
            MySqlDataAdapter sda = new MySqlDataAdapter("Select Role From users Where firstname='"+ userNameTextBox.Text + "' And password='" + passwordTextBox.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                //this.Hide();
                Modules place = new Modules(dt.Rows[0][0].ToString());
                ((Form)place).Controls["label1"].Text = dt.Rows[0][0].ToString();
                place.Show();
               
            }
            else
            {
                MessageBox.Show("login credentials are incorrect");
            }
            
        }

        private void exitBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passwordTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                passwordTextBox.Text = "";
            }
            
        }

        private void passwordTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                passwordTextBox.Text = "PASSWORD";
            }
        }

        private void userNameTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userNameTextBox.Text))
            {
                userNameTextBox.Text = "";
            }
            
        }

        private void userNameTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userNameTextBox.Text))
            {
                userNameTextBox.Text = "USERNAME";
            }
        }
    }
}
