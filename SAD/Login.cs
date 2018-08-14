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
        private DbConnect con = new DbConnect();
        private string loginName;

        public Login()
        {
            con.connectFunc();
            InitializeComponent();
            userNameTextBox.Text = "admin";
            passwordTextBox.Text = "admin";
        }
        //
        //-------->Login Button<--------
        //
        private void loginBut_Click(object sender, EventArgs e)
        {
        
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT roleuser, firstname " +
                                                        "FROM users_table " +
                                                        "LEFT JOIN staff_table " +
                                                        "ON users_table.idStaff = staff_table.idStaff " +
                                                        "WHERE username ='" + userNameTextBox.Text.ToLower() +
                                                        "' AND password ='" + passwordTextBox.Text +
                                                        "'", con.connectFunc());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            if (dt.Rows.Count >= 1)
            {
                String role = dt.Rows[0][0].ToString();
                loginName = dt.Rows[0][1].ToString();

                //Identifies User's Role
                if (role == "Admin")                                                        //If User is Admin
                {
                    Modules modFrm = new Modules(role);
                    modFrm.Size = new Size(1200, 675);
                    modFrm.reference = this;
                    this.Hide();
                    modFrm.Show();
                }
                else if (role == "Principal")                                               //If User is Principal
                {
                    HRMForm hrmFrm = new HRMForm(role);
                    hrmFrm.Size = new Size(1200, 675);
                    hrmFrm.reference = this;
                    this.Hide();
                    hrmFrm.Show();
                }
                else if (role == "Hrm")                                                     //If User is Human Resource Manager
                {
                    HRMForm hrmFrm = new HRMForm(role);
                    hrmFrm.Size = new Size(1200, 675);
                    hrmFrm.reference = this;
                    this.Hide();
                    hrmFrm.Show();
                }
                else if (role == "Registrar")                                               //If User is Registrar
                {
                    /*
                    RegForm regFrm = new RegForm(role);
                    regFrm.Size = new Size(1200, 675);
                    regFrm.reference = this;
                    this.Hide();
                    regFrm.Show();
                    */
                }
                else if (role == "Sc")                                                      //If User is Supervising Custodian
                {
                    /*
                    SCForm scFrm = new SCForm(role);
                    scFrm.Size = new Size(1200, 675);
                    scFrm.reference = this;
                    this.Hide();
                    scFrm.Show();
                    */
                }
                else if (role == "Supervisor" || role == "Monitor")                         //If User is Faculty
                {
                    FacultyForm facultyFrm = new FacultyForm(role);
                    facultyFrm.Size = new Size(1200, 675);
                    facultyFrm.reference = this;
                    this.Hide();
                    if (role == "monitor")
                    {
                        //Show-Hide PACE Prescriptions Button
                        facultyFrm.showPrescriptions(false);
                    }else facultyFrm.showPrescriptions(true);
                    facultyFrm.Show();
                }
            }
            else
            {
                MessageBox.Show("Username and Password do not match.");
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
