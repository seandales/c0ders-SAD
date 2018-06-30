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
    public partial class StaffManagForm : Form
    {
        public StaffManagForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}
