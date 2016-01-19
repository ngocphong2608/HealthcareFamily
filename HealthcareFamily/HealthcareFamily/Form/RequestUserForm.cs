using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using HealthcareFamilyGUI.FormArguments;
using HeathcareFamilyBUS;
using HealthcareFamilyDTO;
using HealthcareFamilyBUS;
using MetroFramework;

namespace HealthcareFamilyGUI
{
    public partial class RequestUserForm : MetroForm
    {
        public RequestUserForm()
        {
            InitializeComponent();
        }
        public RequestUserForm(UserInformationFormArguments arg)
        {
            InitializeComponent();
            Arguments = arg;
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAcceptUser_Click(object sender, EventArgs e)
        {
            if (lvwRequestUser.SelectedItems.Count > 0)
            {
                string email = lvwRequestUser.SelectedItems[0].SubItems[1].Text;

                FollowerBUS followerBUS = new FollowerBUS();

                followerBUS.AcceptFollowByEmail(Arguments.Username, email);

                MetroMessageBox.Show(this, "Add user successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                RequestUserForm_ReLoad();
            } else
            {
                MetroMessageBox.Show(this, "Please choose a user!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RequestUserForm_ReLoad()
        {
            FollowerBUS followerBUS = new FollowerBUS();
            UserBUS userBUS = new UserBUS();
            List<FollowerDTO> followerList = followerBUS.GetAllRequestUser(Arguments.Username);

            DataTable table = new DataTable();

            DataColumn countColumn = new DataColumn(
                "Name", Type.GetType("System.String"));
            table.Columns.Add(countColumn);

            DataColumn emailColumn = new DataColumn(
                "Email", Type.GetType("System.String"));
            table.Columns.Add(emailColumn);

            DataColumn accColumn = new DataColumn(
                "Account Type", Type.GetType("System.String"));
            table.Columns.Add(accColumn);

            for (int i = 0; i < followerList.Count; i++)
            {
                DataRow r = table.NewRow();
                // get follower information
                UserDTO follower = userBUS.GetUserInformation(followerList[i].Username);

                r["Name"] = follower.Name;
                r["Email"] = follower.Email;
                r["Account Type"] = follower.AccountType;
                table.Rows.Add(r);
            }


            lvwRequestUser.Items.Clear();

            lvwRequestUser.FullRowSelect = true;

            foreach (DataRow row in table.Rows)
            {
                ListViewItem item = new ListViewItem(row["Name"].ToString());
                item.SubItems.Add(row["Email"].ToString());
                item.SubItems.Add(row["Account Type"].ToString());
                lvwRequestUser.Items.Add(item); //Add this row to the ListView
            }
        }

        private void RequestUserForm_Load(object sender, EventArgs e)
        {
            // friends list
            lvwRequestUser.View = View.Details;

            lvwRequestUser.Columns.Add("Name", 100, HorizontalAlignment.Left);
            lvwRequestUser.Columns.Add("Email", 100, HorizontalAlignment.Left);
            lvwRequestUser.Columns.Add("Account Type", 100, HorizontalAlignment.Left);

            RequestUserForm_ReLoad();
        }
    }
}
