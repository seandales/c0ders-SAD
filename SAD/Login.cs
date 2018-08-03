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
        //
        //-------->Login Button<--------
        //``````
        private void loginBut_Click(object sender, EventArgs e)
        { 
        
            //using(var con = new MySqlConnection(con.connectionString))
            MySqlDataAdapter sda = new MySqlDataAdapter("Select role From users Where user_name='"+ userNameTextBox.Text + "' And password='" + passwordTextBox.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            String role = dt.Rows[0][0].ToString();
            /*
            if (role`)
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
            */
        
            
            if (role == "Admin")                                                        //If User is Admin
            {
                Modules modFrm = new Modules();
                modFrm.reference = this;
                modFrm.Show();
                this.Hide();
            }
            else if (userNameTextBox.Text == "Principal")                                              //If User is Principal
            {

            }else if (userNameTextBox.Text == "HRM")                                                    //If User is Human Resource Manager
            {
                HRMForm hrmFrm = new HRMForm();
                hrmFrm.reference = this;
                hrmFrm.Show();
                this.Hide();
            }
            else if (userNameTextBox.Text == "Registrar")                                              //If User is Registrar
            {

            }else if (userNameTextBox.Text == "sc")                                                     //If User is Supervising Custodian
            {

            }else if (userNameTextBox.Text == "supervisor" || userNameTextBox.Text == "monitor")        //If User is Faculty
            {
                if (userNameTextBox.Text == "monitor")
                {
                    //Hide PACE Prescriptions Button
                }
            }
        }
        //
        //-------->Exit Button<--------
        //
        private void exitBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        //-------->Password Textbox<--------
        //
        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "pass")
            {
                passwordTextBox.Text = "";
                passwordTextBox.ForeColor = Color.Black;
            }
        }
        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.Text = "pass";
                passwordTextBox.ForeColor = Color.Silver;
            }
        }
        //
        //-------->Username Textbox<--------
        //
        private void userNameTextBox_Enter(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "username")
            {
                userNameTextBox.Text = "";
                userNameTextBox.ForeColor = Color.Black;
            }
        }

        private void userNameTextBox_Leave(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "")
            {
                userNameTextBox.Text = "username";
                userNameTextBox.ForeColor = Color.Silver;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
