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
    public partial class Modules : Form
    {
        public Login reference { get; set; }

        private string loginName;

        public Modules(String role)
        {
            InitializeComponent();
            loginName = role;
        }

        public Modules()
        {
            InitializeComponent();
        }
      
        
        private void Modules_Load(object sender, EventArgs e)
        {
            label1.Text = loginName;
        }

        

        private void exitBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registrar_Stud_ManagForm registrarObject = new Registrar_Stud_ManagForm();
            registrarObject.Show();
        }
        /*
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_Manag_Form staffManagFrom = new Staff_Manag_Form();
            staffManagFrom.reference = this;
            staffManagFrom.Show();

        }
        */
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PACE_Inventory_Sub_Form PACEInventorySubsytemObject = new PACE_Inventory_Sub_Form();
            PACEInventorySubsytemObject.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Supervisor_Stud_Manag_Form supervisorStudManagFormObject1 = new Supervisor_Stud_Manag_Form();
            supervisorStudManagFormObject1.Show();
        }
        //
        //-------->Exit Buttons<--------
        //
        private void Modules_FormClosing(object sender, FormClosingEventArgs e)
        {
            reference.Show();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void signOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
