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
using HealthcareFamilyGUI.FormArguments;
using HealthcareFamilyBUS;
using HealthcareFamilyDTO;

namespace HealthcareFamilyGUI
{
    public partial class SearchingRelationshipForm : MetroForm
    {
        public string Relationship { get; set; }
        public SearchingRelationshipForm()
        {
            InitializeComponent();
        }
        public SearchingRelationshipForm(SearchingRelationshipFormArguments arg)
        {
            InitializeComponent();
            Arguments = arg;
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;
        }

        private void cmdFinish_Click(object sender, EventArgs e)
        {
            Relationship = cbRelationship.SelectedItem.ToString();

            // luc form quay ve can phai xoa het noi dung trong cai list di
            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void SearchingRelationshipForm_Load(object sender, EventArgs e)
        {
            UserBUS userBUS = new UserBUS();
            UserDTO user = userBUS.GetUserInformation(Arguments.Username);
            UserDTO follower = userBUS.GetUserInformationByEmail(Arguments.FollowerEmail);

            if (user.AccountType == "Family" && follower.AccountType == "Family")
            {
                cbRelationship.Items.Add("Family");
            } else
            {
                cbRelationship.Items.Add("Family");
                cbRelationship.Items.Add("Doctor");
            }

            cbRelationship.SelectedIndex = 0;
        }
    }
}
