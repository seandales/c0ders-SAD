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
    public partial class EditStud : Form
    {

        public int studId;
        public RegForm reference { get; set; }
        // public int userId;
        public String username, password, role;

        private DbConnect conRef = new DbConnect();
        public EditStud()
        {
            InitializeComponent();
        }

        private void btnStudCancel_Click(object sender, EventArgs e)
        {
            reference.checkStudArchive.Checked = false;
            clearStudFields();
            reference.clearRegForm();
            showPrev();
        }
        private void showPrev()
        {
            this.Hide();
            //reference.clea();
            //reference.clearStaffFields();
            reference.Show();
        }
        private void clearStudFields()
        {
            txtFn.Text = "";
            txtMn.Text = "";
            txtLn.Text = "";
            dateTimeBirthdate.ResetText();
            comboGender.SelectedIndex = comboGender.Items.IndexOf(0);
            comboGradeLevel.SelectedIndex = comboGradeLevel.Items.IndexOf(0);
            combostatus.SelectedIndex = combostatus.Items.IndexOf(0);
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
                MessageBox.Show("please specify the gradelvel of the user");
                flag = true;

            }
            if (combostatus.SelectedItem == null)
            {
                MessageBox.Show("please specify the status of the user");
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

                // MySqlConnection con = conRef.connectFunc();
                String query1 = ("UPDATE student_table SET firstname = @firstname, middlename = @middlename, lastname = @lastname, birthdate = @birthdate," +
                    "gender = @gender, idgradelevel = @idgradelevel, studstatus = @studstatus WHERE idstudent = @idStud ");
                /*
                String query1 = ("UPDATE staff_table SET firstname ='" + txtEditStaffFn.Text + "', middlename = '" + txtEditStaffMn.Text +
                    "', lastname ='" + txtEditStaffLn.Text + "', birthdate = @birthdate,
                    "' gender ='" + comboBoxGender.Text + "', civilstatus ='" + comboBoxCivilStatus.Text  +
                    "', staffstatus ='" + comboBoxStaffStatus.Text + "', staffRole = '" + comboBoxRole.Text + "' " +
                    "WHERE idStaff ='" +staffId+ "' ");
                    */
                MySqlConnection con = conRef.connectFunc();
                using (MySqlCommand cmd = new MySqlCommand(query1, con))
                {
                    cmd.Parameters.AddWithValue("@firstname", txtFn.Text);
                    cmd.Parameters.AddWithValue("@middlename", txtMn.Text);
                    cmd.Parameters.AddWithValue("@lastname", txtLn.Text);
                    cmd.Parameters.AddWithValue("@birthdate", dateTimeBirthdate.Value.Date);
                    cmd.Parameters.AddWithValue("@gender", comboGender.Text);
                    cmd.Parameters.AddWithValue("@idgradelevel", comboGradeLevel.Text);
                    cmd.Parameters.AddWithValue("@studstatus", combostatus.Text);
                    cmd.Parameters.AddWithValue("@idStud", studId);



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
                    reference.checkStudArchive.Checked = false;
                    clearStudFields();
                    showPrev();

                }

                //Form();

            }
            else
            {
                MessageBox.Show(" error");
            }



        }


    }

}
