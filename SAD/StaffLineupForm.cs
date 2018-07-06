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
    public partial class Staff_Lineup_Form : Form
    {
        public Staff_Lineup_Form()
        {
            InitializeComponent();
        }

        private void StaffLineupForm_Load(object sender, EventArgs e)
        {

        }

        private void StaffLineupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Staff_Manag_Form staffManagFormObject1 = new Staff_Manag_Form();
            staffManagFormObject1.Show();
        }
    }
}
