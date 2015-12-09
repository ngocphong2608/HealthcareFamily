using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HealthcareFamily
{
    public partial class UserFindingForm : Form
    {
        public UserFindingForm()
        {
            InitializeComponent();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNext_Click(object sender, EventArgs e)
        {
            var frm = new UserFindingResultForm();
            frm.ShowDialog();
        }
    }
}
