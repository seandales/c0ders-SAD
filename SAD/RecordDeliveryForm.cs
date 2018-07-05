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
    public partial class RecordDeliveryForm : Form
    {
        public RecordDeliveryForm()
        {
            InitializeComponent();
        }

        private void RecordDeliveryForm_Load(object sender, EventArgs e)
        {

        }

        private void RecordDeliveryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            PACEInventorySubForm PACEInventoryObject1 = new PACEInventorySubForm();
            PACEInventoryObject1.Show();
        }
    }
}
