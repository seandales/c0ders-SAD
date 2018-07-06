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
    public partial class Supervisor_Lineup_Form : Form
    {
        public Supervisor_Lineup_Form()
        {
            InitializeComponent();
        }

        private void SupervisorLineupForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Staff_Manag_Form staffManagFormObject1 = new Staff_Manag_Form();
            staffManagFormObject1.Show();
        }

        private void SupervisorLineupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
