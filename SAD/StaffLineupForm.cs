﻿using System;
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
    public partial class StaffLineupForm : Form
    {
        public StaffLineupForm()
        {
            InitializeComponent();
        }

        private void StaffLineupForm_Load(object sender, EventArgs e)
        {

        }

        private void StaffLineupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StaffManagForm staffManagFormObject1 = new StaffManagForm();
            staffManagFormObject1.Show();
        }
    }
}
