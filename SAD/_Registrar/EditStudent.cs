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
    public partial class EditStudent : Form
    {
        public int studId;
        public RegForm reference { get; set; }
        private DbConnect conRef = new DbConnect();
        //public int studId;
        public EditStudent()
        {
            InitializeComponent();
            dateTimeBirthdate.CustomFormat = "dd-MM-yyyy";
            textBox1.Text = studId.ToString();
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnAddStud_Click(object sender, EventArgs e)
        {
            Boolean flag = false;

            if (comboGender.SelectedItem == null)
            {
                MessageBox.Show("please specify the gender of the user");
                flag = true;

            }
            if (comboGradeLevel.SelectedItem == null)
            {
                MessageBox.Show("please specify the gradelevel of the user");
                flag = true;

            }


            /*
            if (txtPass.Text != txtPass2.Text)
            {
                MessageBox.Show("Passwords do not match please try again");
            }
            */
            else if (flag == false)
            {
                Modules frm = new Modules();
                String query1 = ("UPDATE student_table SET firstname = @firstname, middlename = @middlename, lastname = @lastname, birthdate = @birthdate," +
                    "gender = @gender, idgradelevel = @gradelevel, studstatus = @studstatus WHERE idstudent = @idstudent");
                MySqlConnection con = conRef.connectFunc();
                using (MySqlCommand cmd = new MySqlCommand(query1, con))
                {
                    cmd.Parameters.AddWithValue("@firstname", txtFn.Text);
                    cmd.Parameters.AddWithValue("@middlename", txtMn.Text);
                    cmd.Parameters.AddWithValue("@lastname", txtLn.Text);
                    cmd.Parameters.AddWithValue("@birthdate", dateTimeBirthdate.Value.Date);
                    cmd.Parameters.AddWithValue("@gender", comboGender.Text);
                    cmd.Parameters.AddWithValue("@gradelevel", comboGradeLevel.Text);
                    cmd.Parameters.AddWithValue("@studstatus", combostatus.Text);
                    cmd.Parameters.AddWithValue("@idstudent", studId);
                    /*
                    cmd.Parameters.AddWithValue("@staffstatus", comboBoxStaffStatus.Text);
                    cmd.Parameters.AddWithValue("@staffrole", comboBoxRole.Text);
                    cmd.Parameters.AddWithValue("@idStaff", staffId);
                    */
                    con.Open();
                    int result = cmd.ExecuteNonQuery();
                    //checking for errors
                    if (result < 0)
                    {
                        Console.WriteLine("Error inserting data into staff_table!");
                    }
                    else
                    {
                        MessageBox.Show("succesfully updated staff table");

                    }
                    con.Close();
                    reference.readDataStud();
                    clearfields();
                    showPref();
                }

                //Form();

            }
            else
            {
                MessageBox.Show(" error");
            }
        }
        private void clearfields()
        {
            txtFn.Text = "";
            txtMn.Text = "";
            txtLn.Text = "";
            dateTimeBirthdate.ResetText();
            comboGender.SelectedIndex = comboGender.Items.IndexOf(0);
            //comboRoleAccounts.SelectedIndex = comboRoleAccounts.Items.IndexOf(0);


            txtFn.Clear();
            txtMn.Clear();
            txtLn.Clear();
            dateTimeBirthdate.ResetText();

            comboGender.SelectedIndex = comboGender.Items.IndexOf(0);
            comboGradeLevel.SelectedIndex = comboGradeLevel.Items.IndexOf(0);
            combostatus.SelectedIndex = combostatus.Items.IndexOf(0);
            //comboRoleAccounts.SelectedIndex = comboRoleAccounts.Items.IndexOf(0);
            //txtStaffSearch.Clear();
        }
        private void showPref()
        {
            this.Hide();
            reference.clearStudFields();
            //reference.clearStaffFields();
            reference.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
 
}
