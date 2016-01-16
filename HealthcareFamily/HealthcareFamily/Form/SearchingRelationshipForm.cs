using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace HealthcareFamilyGUI
{
    public partial class SearchingRelationshipForm : MetroForm
    {
        public string Relationship { get; set; }
        public SearchingRelationshipForm()
        {
            InitializeComponent();
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cmdFinish_Click(object sender, EventArgs e)
        {
            Relationship = cbRelationship.SelectedItem.ToString();

            // luc form quay ve can phai xoa het noi dung trong cai list di
            this.Close();

            //this.Hide();
            //this.Close();
        }

        private void SearchingRelationshipForm_Load(object sender, EventArgs e)
        {
            cbRelationship.SelectedIndex = 0;
        }
    }
}
