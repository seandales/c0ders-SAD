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
    public partial class RegistrarStudManagForm : Form
    {
        public RegistrarStudManagForm()
        {
            InitializeComponent();
        }

        private void RegistrarStudManagForm_Load(object sender, EventArgs e)
        {

        }

        private void RegistrarStudManagForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modules moduleObject = new Modules(null);
            moduleObject.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherStudentView teachListFormObject1 = new TeacherStudentView();
            teachListFormObject1.Show();
        }
    }
}
