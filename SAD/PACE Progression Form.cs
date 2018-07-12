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
    public partial class PACE_Progression_Form : Form
    {
        public PACE_Progression_Form()
        {
            InitializeComponent();
        }

        private void PACE_Progression_Form_Load(object sender, EventArgs e)
        {

        }

        private void PACE_Progression_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Supervisor_Stud_Manag_Form object1 = new Supervisor_Stud_Manag_Form();
            object1.Show();
        }
    }
}
