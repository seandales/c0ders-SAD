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
    public partial class RegForm : Form
    {
        //public Staff_Manag_Form reference { get; set; }
        DbConnect conRef = new DbConnect();

        //Staff_Manag_Form frmObject = new Staff_Manag_Form();
        public Login reference { get; set; }
        private string loginName;
        //
        public RegForm()
        {
            InitializeComponent();
            readDataStud();
        }
        //
        //-------->Form Initialization<--------
        //
        public RegForm(String role)
        {
            InitializeComponent();
            loginName = role;
        }
        private void RegForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome back, " + loginName;

            //Sets All Panels to Fill
            homePanel.Dock = DockStyle.Fill;
            studentsPanel.Dock = DockStyle.Fill;

            //Hides All Other Panels
            studentsPanel.Visible = false;
        }
        //
        //-------->Navigation Buttons<--------
        //
        private void homeButton_Click(object sender, EventArgs e)
        {
            //Switches Button BackColors
            homeButton.BackColor = Color.FromArgb(57, 213, 255);
            staffsButton.BackColor = Color.Transparent;

            //Switches Panel Visibility
            homePanel.Visible = true;
            studentsPanel.Visible = false;

            //Changes Label
            navigationLabel.Text = "Home";
        }
        private void studentsButton_Click(object sender, EventArgs e)
        {
            //Switches Button BackColors
            homeButton.BackColor = Color.Transparent;
            staffsButton.BackColor = Color.FromArgb(57, 213, 255);

            //Switches Panel Visibility
            studentsPanel.Visible = true;
            homePanel.Visible = false;

            //Changes Label
            navigationLabel.Text = "Staffs";
        }
        //
        //-------->Exit Buttons<--------
        //
        private void signOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void RegForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            reference.Show();
        }


        private void btnAddStud_Click(object sender, EventArgs e)
        {
            AddStudent addStudentFrm = new AddStudent();
            addStudentFrm.reference = this;


            /*
            Boolean flag = false;
            if (comboGender.SelectedItem == null || comboGender.SelectedIndex == 0)
            {
                MessageBox.Show("please specify the gender of the user");
                flag = true;

            }
            if (comboGradeLevel.SelectedItem == null || comboGradeLevel.SelectedItem == null)
            {
                MessageBox.Show("please specify the grade level of the student");
            }
            if (combostatus.SelectedItem == null || combostatus.SelectedItem == null)
            {
                MessageBox.Show("please specify the grade level of the student");
            }



            else if (flag == false)
            {
                int number = 1;
                String query1 = ("INSERT INTO student_table (firstname,middlename,lastname, birthdate, gender,  idgradelevel, sectionname, studstatus)" +
                    " VALUES (@firstname, @middlename, @lastname, @birthdate, @gender, @idgradelevel, @sectionname, @studstatus)");
                MySqlConnection con = conRef.connectFunc();
                using (MySqlCommand cmd = new MySqlCommand(query1, con))
                {
                    cmd.Parameters.AddWithValue("@firstname", txtFn.Text);
                    cmd.Parameters.AddWithValue("@middlename", txtMn.Text);
                    cmd.Parameters.AddWithValue("@lastname", txtLn.Text);
                    cmd.Parameters.AddWithValue("@birthdate", dateTimeBirthdate.Value.Date);
                    cmd.Parameters.AddWithValue("@gender", comboGender.Text);
                    cmd.Parameters.AddWithValue("@idgradelevel", comboGradeLevel.SelectedIndex);
                    cmd.Parameters.AddWithValue("@sectionname", 1);
                    cmd.Parameters.AddWithValue("@studstatus", combostatus.Text);
                    con.Open();
                    int result = cmd.ExecuteNonQuery();
                    //checking for errors
                    if (result < 0)
                    {
                        Console.WriteLine("Error inserting data into student table!");
                    }
                    else
                    {
                        MessageBox.Show("succesfully inserted into student table");

                    }
                    con.Close();
                    readDataStud();
                    clearStudFields();
                }

                //Form();
            }
            else
            {
                MessageBox.Show(" error");
            }

            */


        }
        DbConnect connect = new DbConnect();
        MySqlDataAdapter da, da2;
        DataTable dt, dt2;

        /*
        private void btnStudCancel_Click(object sender, EventArgs e)
        {
            clearStudFields();
        }
        */

        private void btnEditStud_Click(object sender, EventArgs e)
        {
            /*
            EditStudentcs f = new EditStudentcs();
            if (checkStudArchive.Checked == false)
            {
                for (int i = 0; i < accountListGridView.SelectedRows.Count; i++)
                {
                    f.userId = Convert.ToInt32(accountListGridView.SelectedRows[i].Cells[0].Value.ToString());
                    f.textBox1.Text = (accountListGridView.SelectedRows[i].Cells[0].Value.ToString());
                    f.txtEditUserName.Text = (accountListGridView.SelectedRows[i].Cells[1].Value.ToString());
                    f.txtEditPass1.Text = accountListGridView.SelectedRows[i].Cells[2].Value.ToString();
                    f.comboEditRole.Text = accountListGridView.SelectedRows[i].Cells[3].Value.ToString();
                    f.comboStatus.Text = accountListGridView.SelectedRows[i].Cells[5].Value.ToString();

                    //f.dateTimePickerBirthdate.Text = accountListGridView.SelectedRows[i].Cells[3].Value.ToString();
                    //f.dateTimePicker1.Text = accountListGridView.SelectedRows[i].Cells[4].Value.ToString();
                    //f.comboStatus.Text = accountListGridView.SelectedRows[i].Cells[5].Value.ToString();



                }
            }
            if (checkStudArchive.Checked == true)
            {
                for (int i = 0; i < archive1.SelectedRows.Count; i++)
                {
                    f.userId = Convert.ToInt32(archive1.SelectedRows[i].Cells[0].Value.ToString());
                    f.textBox1.Text = (archive1.SelectedRows[i].Cells[0].Value.ToString());
                    f.txtEditUserName.Text = (archive1.SelectedRows[i].Cells[1].Value.ToString());
                    f.txtEditPass1.Text = archive1.SelectedRows[i].Cells[2].Value.ToString();
                    f.comboEditRole.Text = archive1.SelectedRows[i].Cells[3].Value.ToString();
                    f.comboStatus.Text = archive1.SelectedRows[i].Cells[5].Value.ToString();

                    //f.dateTimePickerBirthdate.Text = accountListGridView.SelectedRows[i].Cells[3].Value.ToString();
                    //f.dateTimePicker1.Text = accountListGridView.SelectedRows[i].Cells[4].Value.ToString();
                    //f.comboStatus.Text = accountListGridView.SelectedRows[i].Cells[5].Value.ToString();



                }
            }

        /*
private void btnEditStud_Click(object sender, EventArgs e)
{
   EditAccountForm f = new EditAccountForm();
   for (int i = 0; i < stud.SelectedRows.Count; i++)
   {
       f.userId = Convert.ToInt32(accountListGridView.SelectedRows[i].Cells[0].Value.ToString());
       f.textBox1.Text = (accountListGridView.SelectedRows[i].Cells[0].Value.ToString());
       f.txtEditUserName.Text = (accountListGridView.SelectedRows[i].Cells[1].Value.ToString());
       f.txtEditPass1.Text = accountListGridView.SelectedRows[i].Cells[2].Value.ToString();
       f.comboEditRole.Text = accountListGridView.SelectedRows[i].Cells[3].Value.ToString();
       f.comboStatus.Text = accountListGridView.SelectedRows[i].Cells[5].Value.ToString();

       //f.dateTimePickerBirthdate.Text = accountListGridView.SelectedRows[i].Cells[3].Value.ToString();
       //f.dateTimePicker1.Text = accountListGridView.SelectedRows[i].Cells[4].Value.ToString();
       //f.comboStatus.Text = accountListGridView.SelectedRows[i].Cells[5].Value.ToString();



   }

   this.Hide();
   //ddStaffForm addForm = new AddStaffForm();
   f.reference = this;
   //addForm.butAdd.Enabled = false;
   // addForm.butAdd.Enabled = true;
   f.Show();
}
*/
        }

        public void readDataStud()
        {
            MySqlConnection con = connect.connectFunc();
            String query1 = "SELECT * FROM student_table WHERE studstatus = 1";
            String query2 = "SELECT * FROM student_table WHERE studstatus = 0";

            dt = new DataTable();
            dt2 = new DataTable();


            da = new MySqlDataAdapter(query1, con);
            da2 = new MySqlDataAdapter(query2, con);


            da.Fill(dt);
            da2.Fill(dt2);
            /*
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
            
            bSource.DataSource = dt2;
            bSource.DataSource = dt3;
            bSource.DataSource = dt4;
            */



            // accountListGridView.DataSource = bSource;
            datagridStud.DataSource = dt;
            archiveStud.DataSource = dt2;
            datagridStud.Columns[0].Visible = false;
            archiveStud.Columns[0].Visible = false;
            datagridStud.ClearSelection();
            archiveStud.ClearSelection();
            archiveStud.Visible = false;
            archiveStud.Enabled = false;
            datagridStud.Visible = true;
            datagridStud.Enabled = true;
            datagridStud.ClearSelection();
            archiveStud.ClearSelection();
            //dt.Rows[0].Vi

        }
        /*
        public void clearStudFields()
        {
            txtFn.Clear();
            txtMn.Clear();
            txtLn.Clear();
            comboGender.SelectedIndex = comboGender.Items.IndexOf(0);
            comboGradeLevel.SelectedIndex = comboGradeLevel.Items.IndexOf(0);
            combostatus.SelectedIndex = combostatus.Items.IndexOf(0);
            txtSearchStud.Clear();
        }
        */
    }
}
