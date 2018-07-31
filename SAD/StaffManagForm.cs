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
    public partial class Staff_Manag_Form : Form
    {
        public Modules reference { get; set; }
        //private MySqlConnection con;
        public Staff_Manag_Form()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_Lineup_Form staffLineupFormObject1 = new Staff_Lineup_Form();
            staffLineupFormObject1.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_ColumnRemoved(object sender, DataGridViewColumnEventArgs e)
        {

        }

        private void StaffManagForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            reference.Show();
        }

        private void StaffManagForm_Load(object sender, EventArgs e)
        {
            readData();
        }

        private void supervisorLineUpBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Supervisor_Lineup_Form supervisorLineupFormObject1 = new Supervisor_Lineup_Form();
            supervisorLineupFormObject1.Show();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void butAddStaff(object sender, EventArgs e)
        {
            this.Hide();
            
        }
        DbConnect connect = new DbConnect();
        MySqlDataAdapter da;
        DataTable dt;
        public void readData()
        {
            MySqlConnection con = connect.connectFunc();
            String query = "SELECT * FROM staff";
            dt = new DataTable();
            da = new MySqlDataAdapter(query, con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void buttAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStaffForm addForm = new AddStaffForm();
            addForm.reference = this;
            addForm.butAdd.Enabled = true;
            addForm.butAdd.Enabled = false;
            addForm.Show();
        }

        private void buttEdit_Click(object sender, EventArgs e)
        {
            AddStaffForm f = new AddStaffForm();
            for( int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                f.txtFn.Text = dataGridView1.SelectedRows[i].Cells[1].Value.ToString();
                f.txtMn.Text = dataGridView1.SelectedRows[i].Cells[2].Value.ToString();
                f.txtLn.Text = dataGridView1.SelectedRows[i].Cells[3].Value.ToString();
                f.dateTimePicker1.Text = dataGridView1.SelectedRows[i].Cells[4].Value.ToString();
                f.comboxGend.Text = dataGridView1.SelectedRows[i].Cells[5].Value.ToString();
                f.txtAge.Text = dataGridView1.SelectedRows[i].Cells[6].Value.ToString();
                f.txtNationality.Text = dataGridView1.SelectedRows[i].Cells[7].Value.ToString();
                f.comboCivil.Text = dataGridView1.SelectedRows[i].Cells[8].Value.ToString();
                f.txtAddress.Text = dataGridView1.SelectedRows[i].Cells[9].Value.ToString();
                f.txtEmail.Text = dataGridView1.SelectedRows[i].Cells[10].Value.ToString();
                f.txtReligion.Text = dataGridView1.SelectedRows[i].Cells[11].Value.ToString();
                f.comboxStatus.Text = dataGridView1.SelectedRows[i].Cells[12].Value.ToString();
               

            }
            this.Hide();
            AddStaffForm addForm = new AddStaffForm();
            addForm.reference = this;
            addForm.butAdd.Enabled = false;
            addForm.butAdd.Enabled = true;
            addForm.Show();
        }
        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idStaff"].Value.ToString());
            MySqlConnection con = connect.connectFunc();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM staff WHERE idStaff=" + id + "";
            con.Open();
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtFn.Text = dr["first_name"].ToString();
                txtMn.Text = dr["middle_name"].ToString();
                txtLn.Text = dr["last_name"].ToString();
                txtBirthDate.Text = dr["birthdate"].ToString();
                txtGender.Text = dr["gender"].ToString();
                txtAge.Text = dr["age"].ToString();
                txtNationality.Text = dr["nationality"].ToString();
                txtCivilStatus.Text = dr["civil_status"].ToString();
                txtAddress.Text = dr["address"].ToString();
                txtEmail.Text = dr["email"].ToString();
                txtReligion.Text = dr["religion"].ToString();
                txtStatus.Text = dr["status"].ToString();
            }
        }
            

    }
}
