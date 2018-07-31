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
        private MySqlConnection con;
      
        public Login()
        {
            con = new MySqlConnection("server=localhost; user id =root; database=sad_db; password=root;");
            InitializeComponent();
        }

        private void loginBut_Click(object sender, EventArgs e)
        {
            //using(var con = new MySqlConnection(conClass.connectionString))
            MySqlDataAdapter sda = new MySqlDataAdapter("Select role From user Where user_name='"+ userNameTextBox.Text + "' And password='" + passwordTextBox.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                this.Hide();
                Modules modFrm = new Modules(dt.Rows[0][0].ToString());
                modFrm.reference = this;
                modFrm.Show();
          
               
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

        private void Login_Load(object sender, EventArgs e)
        {

        }
        /*
        public class conClass
        {
            public static readonly string connectionString = "Server=localhost;Port=3306;Database=sad_db;Uid=root:Pwd=root";
        }
        */
    }
}
