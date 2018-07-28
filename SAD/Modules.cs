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
        public PACE_Inventory_Sub_Form reference { get; set; }

        public Modules(String role)
        {
            InitializeComponent();
            label1.Text = role;
        }
      
        
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Modules_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login loginObject = new Login();
            loginObject.Show();
            

            
        }

        private void exitBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registrar_Stud_ManagForm registrarObject = new Registrar_Stud_ManagForm();
            registrarObject.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_Manag_Form staffManagForm1 = new Staff_Manag_Form();
            staffManagForm1.Show();
        }

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
    }
}
