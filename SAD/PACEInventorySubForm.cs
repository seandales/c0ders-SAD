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
    public partial class PACE_Inventory_Sub_Form : Form
    {

        public Modules reference { get; set; }
        public PACE_Inventory_Sub_Form()
        {
            InitializeComponent();
        }

        private void PACEInventorySubsytem_Load(object sender, EventArgs e)
        {

        }

        private void PACEInventorySubsytem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modules object1 = new Modules(null);
            object1.reference = this;
            object1.Show();
            this.Hide();
            

        }

        private void recordDeliveryBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecordDeliveryForm recordDeliveryObject1 = new RecordDeliveryForm();
            recordDeliveryObject1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
        }
    }
}
