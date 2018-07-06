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
    public partial class Supervisor_Stud_Manag_Form : Form
    {
        public Supervisor_Stud_Manag_Form()
        {
            InitializeComponent();
        }

        private void SupervisorStudManagForm_Load(object sender, EventArgs e)
        {

        }

        private void SupervisorStudManagForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modules modulesObject1 = new Modules(null);
            modulesObject1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
