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

        private void Login_Load(object sender, EventArgs e)
        {
           
        }



        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            
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

        private void loginBut_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
