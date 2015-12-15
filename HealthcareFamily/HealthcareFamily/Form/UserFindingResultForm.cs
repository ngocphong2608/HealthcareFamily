using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HealthcareFamilyDTO
{
    public partial class UserFindingResultForm : Form
    {
        public UserFindingResultForm()
        {
            InitializeComponent();
        }

        private void cmdNext_Click(object sender, EventArgs e)
        {

            String usr;


            // get user
            usr = this.lwvFindingResult.SelectedItems.ToString();
            


            this.Hide();
            var frm = new RelationshipSettingForm();
            frm.ShowDialog();
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
