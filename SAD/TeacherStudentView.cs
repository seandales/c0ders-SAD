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
    public partial class Teacher_Student_View : Form
    {
        public Teacher_Student_View()
        {
            InitializeComponent();
        }

        private void TeachListForm_Load(object sender, EventArgs e)
        {

        }

        private void TeachListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Registrar_Stud_ManagForm registrarStudManagFormObject1 = new Registrar_Stud_ManagForm();
            registrarStudManagFormObject1.Show();
        }
    }
}
