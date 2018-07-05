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
    public partial class SupervisorLineupForm : Form
    {
        public SupervisorLineupForm()
        {
            InitializeComponent();
        }

        private void SupervisorLineupForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StaffManagForm staffManagFormObject1 = new StaffManagForm();
            staffManagFormObject1.Show();
        }

        private void SupervisorLineupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
