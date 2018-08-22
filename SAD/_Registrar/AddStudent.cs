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
    public partial class AddStudent : Form
    {
        public RegForm reference { set; get; }
        public int studId;
        private DbConnect conRef = new DbConnect();
        public AddStudent()
        {
            InitializeComponent();
            dateTimeBirthdate.CustomFormat = "dd-MM-yyyy";
        }

        private void btnAddStud_Click(object sender, EventArgs e)
        {

            Boolean flag = false;

            if (comboGender.Text == null || comboGender.SelectedIndex == 0)
            {
                MessageBox.Show("please specify the gender of the staff memeber");
                flag = true;

            }
            if (comboGradeLevel.Text == null || comboGradeLevel.SelectedIndex == 0)
            {
                MessageBox.Show("Please specify the grade level of the user");
                flag = true;
            }
            if (combostatus.Text == null || combostatus.SelectedIndex == 0)
            {
                MessageBox.Show("Please specify the status  of the user");
                flag = true;
            }
          
            //Inserts to student_table 
            if (flag == false)
            {

                String query1 = ("INSERT INTO student_table (firstname,middlename,lastname, birthdate, gender, idgradelevel, studstatus ) " +
                    "VALUES (@firstname, @middlename, @lastname, @birthdate, @gender, @idgradelevel, @studstatus)");
                long jarrod;
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
                    ///cmd.Parameters.AddWithValue("@staffrole", comboRoleStaffs.Text);



                    con.Open();
                    cmd.ExecuteNonQuery();
                    jarrod = cmd.LastInsertedId;
                    //settingId(jarrod);
                    MessageBox.Show(jarrod.ToString());
                    //int insertedID = Convert.ToInt32(cmd.ExecuteScalar());

                    if (jarrod < 0)
                    {
                        Console.WriteLine("Error inserting data into student table!");
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("succesfully inserted into student table");
                        con.Close();
                    }
                }
                reference.readDataStud();
                reference.checkStudArchive.Checked = false;
                clearStudFields();
                reference.clearRegForm();
                showPrev();
            }
        }

        private void btnStudCancel_Click(object sender, EventArgs e)
        {
            reference.checkStudArchive.Checked = false;
            clearStudFields();
            reference.clearRegForm();
            showPrev();
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
        private void showPrev()
        {
            this.Hide();
            //reference.clea();
            //reference.clearStaffFields();
            reference.Show();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }
    }
    
}
