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
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
