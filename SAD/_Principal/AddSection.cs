using System;
using System.Collections;
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
    public partial class AddSection : Form
    {
        ArrayList myArrayList = new ArrayList(); 
        public PrincipalForm reference { set; get; }
        public int sectionId;
        private DbConnect conRef = new DbConnect();
        DbConnect connect = new DbConnect();


        public AddSection()
        {
            InitializeComponent();
        }

        private void AddSection_Load(object sender, EventArgs e)
        {

        }



        public void ReadSupervisorsTable()
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
            //String query1 = "SELECT idstudent, fullname, gradename, lastname, birthdate, gender, 
            //gradename FROM student_table LEFT JOIN grade_level ON student_table.idgradelevel = grade_level.idgradelevel WHERE studstatus = 1";
            String query1 = "SELECT idsupervisor, fullname, gradename, status FROM supervisors LEFT JOIN grade_level ON supervisors.idgradelevel = grade_level.idgradelevel WHERE status = 1 OR status = 0";

            //String query2 = "SELECT * FROM sections";
            //String query3;
            dt = new DataTable();
            dt2 = new DataTable();

            da = new MySqlDataAdapter(query1, con);


            da.Fill(dt);


            datagridviewSupervisors.DataSource = dt;


            datagridviewSupervisors.ClearSelection();
            //AddSection f = new AddSection();


            //dt.Rows[0].Vi
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void showPrev()
        {
            this.Hide();
            //reference.clea();
            //reference.clearStaffFields();
            reference.Show();
        }
        private void btnAddSection_Click(object sender, EventArgs e)
        {

            Boolean flag = false;

            if (String.IsNullOrWhiteSpace(comboSupervisor.Text))
            {
                MessageBox.Show("please specify the Supervisor of the staff memeber");
                flag = true;

            }
            if (String.IsNullOrWhiteSpace(comboGradeLevelSection.Text))
            {
                MessageBox.Show("Please specify the grade level of the user");
                flag = true;
            }





            //Inserts to student_table 

            long jarrod;
            int one = 1;
            MySqlConnection con = conRef.connectFunc();
            if (flag == false)
            {

              
                String query1 = ("INSERT INTO sections (sectionname, idgradelevel, sectionstatus, idsupervisor) " +
                "VALUES (@sectionname, @idgradelevel, @sectionstatus, @idsupervisor)");
                using (MySqlCommand cmd = new MySqlCommand(query1, con))
                {

                    cmd.Parameters.AddWithValue("@sectionname", txtSectionName.Text);
                    cmd.Parameters.AddWithValue("@idgradelevel", comboGradeLevelSection.SelectedIndex);
                    cmd.Parameters.AddWithValue("@sectionstatus", one);
                    cmd.Parameters.AddWithValue("@idsupervisor", myArrayList[comboSupervisor.SelectedIndex]);

                    //cmd.Parameters.AddWithValue("@status", txtLn.Text);



                    ///cmd.Parameters.AddWithValue("@staffrole", comboRoleStaffs.Text);



                    con.Open();
                    cmd.ExecuteNonQuery();
                    jarrod = cmd.LastInsertedId;


                    if (jarrod < 0)
                    {
                        Console.WriteLine("Error inserting data into sections table!");
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("succesfully inserted into sections table");
                        con.Close();
                    }
                }
                String query2 = ("UPDATE supervisors SET idgradelevel = @idgradelevel, status = @status WHERE idsupervisor = @idsupervisor ");
                using (MySqlCommand cmd = new MySqlCommand(query2, con))
                {

                    cmd.Parameters.AddWithValue("@idgradelevel", comboGradeLevelSection.SelectedIndex);
                    cmd.Parameters.AddWithValue("@status", one);
                    cmd.Parameters.AddWithValue("@idsupervisor", myArrayList[comboSupervisor.SelectedIndex]);
                    MessageBox.Show(myArrayList[comboSupervisor.SelectedIndex].ToString());
                    //cmd.Parameters.AddWithValgue("@status", txtLn.Text);



                    ///cmd.Parameters.AddWithValue("@staffrole", comboRoleStaffs.Text);



                    con.Open();
                    cmd.ExecuteNonQuery();
                    jarrod = cmd.LastInsertedId;


                    if (jarrod < 0)
                    {
                        Console.WriteLine("Error inserting data into sections table!");
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("succesfully inserted into sections table");
                        con.Close();
                    }
                }

                
                reference.readData();
                clearAddSectionForm();
                showPrev();
                //reference.checkStudArchive.Checked = false;
                //reference.clearRegForm();
                //showPrev();
                

                
            }
            
         
            
          
        }
        
        private void clearStudFields()
        {
            /*
            txtFn.Text = "";
            txtMn.Text = "";
            txtLn.Text = "";
            dateTimeBirthdate.ResetText();
            comboGender.SelectedIndex = comboGender.Items.IndexOf(0);
            comboGradeLevel.SelectedIndex = comboGradeLevel.Items.IndexOf(0);
            combostatus.SelectedIndex = combostatus.Items.IndexOf(0);
            */
        }
        
        private void clearAddSectionForm()
        {
            txtSectionName.Clear();
            comboSupervisor.Items.Clear();
            comboGradeLevelSection.SelectedIndex = comboGradeLevelSection.Items.IndexOf(0);
            
        }
        


        private void AddSection_Shown(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in datagridviewSupervisors.Rows)
            {
                // determine the status of the supervisor
                int val = Int32.Parse(row.Cells[3].Value.ToString());
                //MessageBox.Show(val.ToString());
                if (val == 1)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                   // MessageBox.Show("passed val 1");

                }
                else
                {

                    comboSupervisor.Items.Add(row.Cells[1].Value.ToString());
                    myArrayList.Add(Int32.Parse(row.Cells[0].Value.ToString()));
                    row.DefaultCellStyle.BackColor = Color.Green;
                    //MessageBox.Show(myArrayList[0].ToString());
                    // MessageBox.Show("passed val 0");

                }

            }
           // MessageBox.Show(myArrayList.Count.ToString());
        }

        private void btnSectionCancel_Click(object sender, EventArgs e)
        {
            txtSectionName.Clear();
            comboSupervisor.Text = "";
            comboGradeLevelSection.SelectedIndex = comboGradeLevelSection.Items.IndexOf(0);
            showPrev();
        }

        private void datagridviewSupervisors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            System.Drawing.Color c = datagridviewSupervisors.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor;
            MessageBox.Show(c.ToString());
            if (c == Color.Green)
            {
                for (int i = 0; i < datagridviewSupervisors.SelectedRows.Count; i++)
                {
                    //f.userId = Convert.ToInt32(datagridviewSupervisors.SelectedRows[i].Cells[0].Value.ToString());
                    comboSupervisor.Text = (datagridviewSupervisors.SelectedRows[i].Cells[1].Value.ToString());
                    comboGradeLevelSection.Text = (datagridviewSupervisors.SelectedRows[i].Cells[2].Value.ToString());
                    /*
                    txtEditPass1.Text = datagridviewSupervisors.SelectedRows[i].Cells[2].Value.ToString();
                    comboEditRole.Text = datagridviewSupervisors.SelectedRows[i].Cells[3].Value.ToString();
                    comboStatus.Text = datagridviewSupervisors.SelectedRows[i].Cells[5].Value.ToString();
                    */

                    //f.dateTimePickerBirthdate.Text = accountListGridView.SelectedRows[i].Cells[3].Value.ToString();
                    //f.dateTimePicker1.Text = accountListGridView.SelectedRows[i].Cells[4].Value.ToString();
                    //f.comboStatus.Text = accountListGridView.SelectedRows[i].Cells[5].Value.ToString();

                }
            }
        }

            
        

        private void datagridviewSupervisors_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
            /*
            System.Drawing.Color c = datagridviewSupervisors.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor;
            MessageBox.Show(c.ToString());
            if (c == Color.Green)
            {
                for (int i = 0; i < datagridviewSupervisors.SelectedRows.Count; i++)
                {
                    //f.userId = Convert.ToInt32(datagridviewSupervisors.SelectedRows[i].Cells[0].Value.ToString());
                    comboSupervisor.Text = (datagridviewSupervisors.SelectedRows[i].Cells[1].Value.ToString());
                    comboGradeLevelSection.Text = (datagridviewSupervisors.SelectedRows[i].Cells[2].Value.ToString());
                    
                    txtEditPass1.Text = datagridviewSupervisors.SelectedRows[i].Cells[2].Value.ToString();
                    comboEditRole.Text = datagridviewSupervisors.SelectedRows[i].Cells[3].Value.ToString();
                    comboStatus.Text = datagridviewSupervisors.SelectedRows[i].Cells[5].Value.ToString();
                    

                    //f.dateTimePickerBirthdate.Text = accountListGridView.SelectedRows[i].Cells[3].Value.ToString();
                    //f.dateTimePicker1.Text = accountListGridView.SelectedRows[i].Cells[4].Value.ToString();
                    //f.comboStatus.Text = accountListGridView.SelectedRows[i].Cells[5].Value.ToString();

                }
            }
            */
    

        }

        private void datagridviewSupervisors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            Color c = datagridviewSupervisors.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor;
            MessageBox.Show(c.ToString());
            */
            if (datagridviewSupervisors.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Green)
            {
                for (int i = 0; i < datagridviewSupervisors.SelectedRows.Count; i++)
                {
                    //f.userId = Convert.ToInt32(datagridviewSupervisors.SelectedRows[i].Cells[0].Value.ToString());
                    comboSupervisor.Text = (datagridviewSupervisors.SelectedRows[i].Cells[1].Value.ToString());
                    comboGradeLevelSection.Text = (datagridviewSupervisors.SelectedRows[i].Cells[2].Value.ToString());
                    /*
                    txtEditPass1.Text = datagridviewSupervisors.SelectedRows[i].Cells[2].Value.ToString();
                    comboEditRole.Text = datagridviewSupervisors.SelectedRows[i].Cells[3].Value.ToString();
                    comboStatus.Text = datagridviewSupervisors.SelectedRows[i].Cells[5].Value.ToString();
                    */

                    //f.dateTimePickerBirthdate.Text = accountListGridView.SelectedRows[i].Cells[3].Value.ToString();
                    //f.dateTimePicker1.Text = accountListGridView.SelectedRows[i].Cells[4].Value.ToString();
                    //f.comboStatus.Text = accountListGridView.SelectedRows[i].Cells[5].Value.ToString();

                }
            }
        }
    }
}

