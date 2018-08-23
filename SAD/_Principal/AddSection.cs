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
    public partial class AddSection : Form
    {
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
        public void fillComboSupervisor(object sender, EventArgs e)
        {
            /*
            comboSupervisor.Items.Clear();
            foreach (DataGridViewRow row in datagridviewSupervisors.Rows)
            {
                comboSupervisor.Items.Add(row.Cells[1].Value.ToString());
            }
            */
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            String query1 = "SELECT * FROM Supervisors";

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


        private void btnAddSection_Click(object sender, EventArgs e)
        {
            comboSupervisor.Items.Clear();
            foreach (DataGridViewRow row in  datagridviewSupervisors.Rows)
            {
                //MessageBox.Show(row.Cells[1].Value.ToString());
                comboSupervisor.Items.Add(row.Cells[1].Value.ToString());
            }

        }
    }
}
