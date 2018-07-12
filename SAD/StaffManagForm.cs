using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Staff_Manag_Form : Form
    {
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
            Modules moduleObject1 = new Modules(null);
            moduleObject1.Show();
        }

        private void StaffManagForm_Load(object sender, EventArgs e)
        {
           
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
    }
}
