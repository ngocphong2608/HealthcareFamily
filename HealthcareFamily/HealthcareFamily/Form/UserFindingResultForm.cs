using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HealthcareFamily
{
    public partial class UserFindingResultForm : Form
    {
        public UserFindingResultForm()
        {
            InitializeComponent();
        }

        private void cmdNext_Click(object sender, EventArgs e)
        {
            var frm = new RelationshipSettingForm();
            frm.ShowDialog();
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
