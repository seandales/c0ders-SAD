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
    public partial class AddSection : Form
    {
        public PrincipalForm reference { set; get; }
        public int sectionId;
        private DbConnect conRef = new DbConnect();
        public AddSection()
        {
            InitializeComponent();
        }

        private void AddSection_Load(object sender, EventArgs e)
        {

        }
    }
}
