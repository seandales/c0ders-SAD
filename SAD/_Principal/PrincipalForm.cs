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
    public partial class PrincipalForm : Form
    {
        //public Staff_Manag_Form reference { get; set; }
        DbConnect conRef = new DbConnect();
        DbConnect connect = new DbConnect();

        //Staff_Manag_Form frmObject = new Staff_Manag_Form();
        public Login reference { get; set; }
        //private string loginName;
        public PrincipalForm()
        {
            InitializeComponent();

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            /*
            //Switches Button BackColors
            homeButton.BackColor = Color.FromArgb(57, 213, 255);
            btnCreateSection.BackColor = Color.Transparent;
            accountsButton.BackColor = Color.Transparent;

            //Switches Panel Visibility
            homePanel.Visible = true;
            staffsPanel.Visible = false;
            accountsPanel.Visible = false;

            //Changes Label
            navigationLabel.Text = "Home";
            */
        }

        private void staffsButton_Click(object sender, EventArgs e)
        {

        }

        private void studentsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        public void readData()
        {
            MySqlDataAdapter da, da2;
            DataTable dt, dt2;
            MySqlConnection con = connect.connectFunc();
            /*
            String query = "SELECT idsection, sectionname, firstname, middlename, lastname, gradename" +
                "FROM sections " +
                "JOIN supervisors ON " +
                "supervisors.idsupervisor = sections.idsupervisor " +
                "JOIN gradelevel " +
                "ON grade_level.idgradelevel = sections.idgradelevel" +
                " WHERE sectionstatus = 1";
                */
            String query1 = "SELECT idstudent, firstname, middlename, lastname, birthdate, gender, gradename FROM student_table LEFT JOIN grade_level ON student_table.idgradelevel = grade_level.idgradelevel WHERE studstatus = 1";

            String query = "SELECT idsection, sectionname, firstname, middlename, lastname, gradename FROM sections LEFT JOIN supervisors ON sections.idsupervisor = supervisors.idsupervisor " +
                "LEFT JOIN grade_level ON sections.idgradelevel = grade_level.idgradelevel WHERE sectionstatus = 1";
            String query2 = "SELECT * FROM sections";

            //String query2 = "SELECT * FROM sections";
            //String query3;
            dt = new DataTable();
            dt2 = new DataTable(); 

            da = new MySqlDataAdapter(query, con);
            da2 = new MySqlDataAdapter(query2, con);

            da.Fill(dt);
            da2.Fill(dt2);
            /*
            SELECT TableA.*, TableB.*, TableC.*, TableD.*
            FROM TableA
            JOIN TableB
            ON TableB.aID = TableA.aID
            JOIN TableC
            ON TableC.cID = TableB.cID
            JOIN TableD
            ON TableD.dID = TableA.dID
            WHERE DATE(TableC.date)=date(now()) 
             /*
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

            datagridSection.DataSource = dt;
            archiveSection.DataSource = dt2;
            //atagridSection.Columns[0].Visible = false;
            //archiveSection.Columns[0].Visible = false;


            archiveSection.Visible = false;
            archiveSection.Enabled = false;
            datagridSection.Visible = true;
            datagridSection.Enabled = true;
            datagridSection.ClearSelection();
            archiveSection.ClearSelection();
            

            //dt.Rows[0].Vi

        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            readData();
        }

        private void archiveSection_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddSection_Click(object sender, EventArgs e)
        {
            AddSection f = new AddSection();
            f.reference = this;
            f.ShowDialog();
        }

        private void btnEditStud_Click(object sender, EventArgs e)
        {
            /*
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
        */
        }
    }
}
