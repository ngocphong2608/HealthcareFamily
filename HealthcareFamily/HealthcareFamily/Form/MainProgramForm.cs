﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HealthcareFamily
{
    public partial class MainProgramForm : Form
    {
        public MainProgramForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdAddUser_Click(object sender, EventArgs e)
        {
            var frm = new UserFindingForm();
            frm.Show();
        }
    }
}
