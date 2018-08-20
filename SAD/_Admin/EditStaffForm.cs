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
    public partial class EditStaffForm : Form
    {
        public int staffId;
        public Modules reference { get; set; }
       // public int userId;
        public String username, password, role;

        private DbConnect conRef = new DbConnect();
       // public Modules reference { get; set; }
        public EditStaffForm()
        {
            InitializeComponent();
            dateTimePickerBirthdate.CustomFormat = "dd-MM-yyyy";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void EditStaffForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateEditStaff_Click(object sender, EventArgs e)
        {
            Boolean flag = false;
             
            if (comboBoxRole.SelectedItem == null)
            {
                MessageBox.Show("please specify the role of the user");
                flag = true;

            }
            if (comboBoxStaffStatus.SelectedItem == null)
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
                String query1 = ("UPDATE staff_table SET firstname = @firstname, middlename = @middlename, lastname = @lastname, birthdate = @birthdate," +
                    "gender = @gender, civilstatus = @civilstatus, staffstatus = @staffstatus, staffrole = @staffrole WHERE idStaff = @idStaff ");
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
                    cmd.Parameters.AddWithValue("@firstname", txtEditStaffFn.Text);
                    cmd.Parameters.AddWithValue("@middlename", txtEditStaffMn.Text);
                    cmd.Parameters.AddWithValue("@lastname", txtEditStaffMn.Text);
                    cmd.Parameters.AddWithValue("@birthdate", dateTimePickerBirthdate.Value.Date);
                    cmd.Parameters.AddWithValue("@gender", comboBoxGender.Text);
                    cmd.Parameters.AddWithValue("@civilstatus", comboBoxCivilStatus.Text);
                    cmd.Parameters.AddWithValue("@staffstatus", comboBoxStaffStatus.Text);
                    cmd.Parameters.AddWithValue("@staffrole", comboBoxRole.Text);
                    cmd.Parameters.AddWithValue("@idStaff", staffId);

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
                    reference.readData();
                    clearFields();
                    showPref();
                }

                //Form();

            }
            else
            {
                MessageBox.Show(" error");
            }
        



        }
    

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelEditStaff_Click(object sender, EventArgs e)
        {
            Modules obj = new Modules();
            clearFields();
            showPref();
            
            

            
        }

        private void txtEditStaffFn_TextChanged(object sender, EventArgs e)
        {

        }
        private void showPref()
        {
            this.Hide();
            reference.clearAccountFields();
            reference.clearStaffFields();
            reference.Show();
        }
        private void clearFields()
        {
            txtEditStaffFn.Text = "";
            txtEditStaffMn.Text = "";
            txtEditStaffLn.Text = "";
            dateTimePickerBirthdate.ResetText();
            comboBoxCivilStatus.SelectedIndex = comboBoxCivilStatus.Items.IndexOf(0);
            comboBoxRole.SelectedIndex = comboBoxRole.Items.IndexOf(0);

        }
    }
}
