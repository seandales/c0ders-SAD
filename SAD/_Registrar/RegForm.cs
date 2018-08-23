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

            //Jarrod fucks around here
            txtSearchStud.Clear();
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

            //jarrod fucks around here
            txtSearchStud.Clear();

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
            AddStudent f = new AddStudent();
            f.reference = this;
            f.ShowDialog();



        }
 
        /*
        private void btnStudCancel_Click(object sender, EventArgs e)
        {
            clearStudFields();
        }
        */

        private void btnEditStud_Click(object sender, EventArgs e)
        {
            int one = 1;
            int zero = 0;

            EditStud f = new EditStud();
            if (checkStudArchive.Checked == false)
            {
                for (int i = 0; i < datagridStud.SelectedRows.Count; i++)
                {
                    f.studId = Convert.ToInt32(datagridStud.SelectedRows[i].Cells[0].Value.ToString());
                    f.txtFn.Text = (datagridStud.SelectedRows[i].Cells[1].Value.ToString());
                    f.txtMn.Text = (datagridStud.SelectedRows[i].Cells[2].Value.ToString());
                    f.txtLn.Text = datagridStud.SelectedRows[i].Cells[3].Value.ToString();
                    f.dateTimeBirthdate.Text = datagridStud.SelectedRows[i].Cells[4].Value.ToString();
                    f.comboGender.Text = datagridStud.SelectedRows[i].Cells[5].Value.ToString();
                    f.comboGradeLevel.Text = datagridStud.SelectedRows[i].Cells[6].Value.ToString();
                    f.combostatus.Text = one.ToString();

                    //f.dateTimePickerBirthdate.Text = accountListGridView.SelectedRows[i].Cells[3].Value.ToString();
                    //f.dateTimePicker1.Text = accountListGridView.SelectedRows[i].Cells[4].Value.ToString();
                    //f.comboStatus.Text = accountListGridView.SelectedRows[i].Cells[5].Value.ToString();



                }
            }

            if (checkStudArchive.Checked == true)
            {
                for (int i = 0; i < archiveStud.SelectedRows.Count; i++)
                {
                    f.studId = Convert.ToInt32(datagridStud.SelectedRows[i].Cells[0].Value.ToString());
                    f.txtFn.Text = (datagridStud.SelectedRows[i].Cells[1].Value.ToString());
                    f.txtMn.Text = (datagridStud.SelectedRows[i].Cells[2].Value.ToString());
                    f.txtLn.Text = datagridStud.SelectedRows[i].Cells[3].Value.ToString();
                    f.dateTimeBirthdate.Text = datagridStud.SelectedRows[i].Cells[4].Value.ToString();
                    f.comboGender.Text = datagridStud.SelectedRows[i].Cells[5].Value.ToString();
                    f.comboGradeLevel.Text = datagridStud.SelectedRows[i].Cells[6].Value.ToString();
                    f.combostatus.Text = zero.ToString();

                }
                //ddStaffForm addForm = new AddStaffForm();
        
            }
            f.reference = this;
            clearRegForm();
            //addForm.butAdd.Enabled = false;
            // addForm.butAdd.Enabled = true;
            f.ShowDialog();
        }

        private void checkStudArchive_CheckedChanged(object sender, EventArgs e)
        {
            if (checkStudArchive.Checked == true)
            {
                readArchive();
            }
            if (checkStudArchive.Checked == false)
            {
                readDataStud();
            }
        }

        private void checkStudArchive_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkStudArchive.Checked == true)
            {
                readArchive();
                btnEditStud.Enabled = false;
            }
            if (checkStudArchive.Checked == false)
            {
                readDataStud();
                btnEditStud.Enabled = false;

            }
        }

        private void txtSearchStud_TextChanged(object sender, EventArgs e)
        {
            if (checkStudArchive.Checked == true)
            {
                using (MySqlConnection conn = conRef.connectFunc())
                {
                    conn.Open();
                    
                    string query = ("SELECT idstudent, firstname, middlename, lastname, birthdate, gender, gradename FROM student_table LEFT JOIN grade_level ON student_table.idgradelevel = grade_level.idgrade_level WHERE firstname LIKE '" + txtSearchStud.Text + "%' AND studstatus = 0");
                    MySqlDataAdapter ad2;
                    DataTable newdt2;
                    ad2 = new MySqlDataAdapter(query, conn);
                    newdt2 = new DataTable();
                    ad2.Fill(newdt2);
                    archiveStud.DataSource = newdt2;
                    btnEditStud.Enabled = true;
                }
            }
            if (checkStudArchive.Checked == false)
            {
                using (MySqlConnection conn = conRef.connectFunc())
                {
                    conn.Open();
                    string query = ("SELECT idstudent, firstname, middlename, lastname, birthdate, gender, gradename FROM student_table LEFT JOIN grade_level ON student_table.idgradelevel = grade_level.idgrade_level WHERE firstname LIKE '" + txtSearchStud.Text + "%' AND studstatus = 1");
                    MySqlDataAdapter ad3;
                    DataTable newdt3;
                    ad3 = new MySqlDataAdapter(query, conn);
                    newdt3 = new DataTable();
                    ad3.Fill(newdt3);
                    datagridStud.DataSource = newdt3;
                    btnEditStud.Enabled = true;
                }
             
            }
            else
            {
                if (String.IsNullOrWhiteSpace(txtSearchStud.Text))
                {
                    btnEditStud.Enabled = false;
                    datagridStud.ClearSelection();
                }
            }
        }

        private void archiveStud_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEditStud.Enabled = true;
        }

        private void datagridStud_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEditStud.Enabled = true;

        }

        public void readArchive()
        {


            datagridStud.Visible = false;
            datagridStud.Enabled = false;

            archiveStud.Visible = true;
            archiveStud.Enabled = true;
            datagridStud.ClearSelection();
            archiveStud.ClearSelection();

        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

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


        /*
private void checkStudArchive_CheckedChanged(object sender, EventArgs e)
{
   if (archiveStud.Checked == true)
   {
       readArchive();
   }
   if (archiveStud.Checked == false)
   {
       readDataStud();
   }
}
*/


        public void readDataStud()
        {
            DbConnect connect = new DbConnect();
            MySqlDataAdapter da, da2;
            DataTable dt, dt2;

            MySqlConnection con = connect.connectFunc();
            String query1 = "SELECT idstudent, firstname, middlename, lastname, birthdate, gender, gradename FROM student_table LEFT JOIN grade_level ON student_table.idgradelevel = grade_level.idgradelevel WHERE studstatus = 1";
            String query2 = "SELECT idstudent, firstname, middlename, lastname, birthdate, gender, gradename FROM student_table LEFT JOIN grade_level ON student_table.idgradelevel = grade_level.idgradelevel WHERE studstatus = 0";

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
        public void clearRegForm()
        {
            txtSearchStud.Clear();
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
