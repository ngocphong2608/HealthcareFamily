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
using HealthcareFamilyBUS;
using HeathcareFamilyBUS;
using HealthcareFamilyDTO;
using HealthcareFamilyGUI.FormArguments;

namespace HealthcareFamilyGUI
{
    public partial class MeetingForm : MetroForm
    {
        public MeetingForm()
        {
            InitializeComponent();
        }

        public MeetingForm(MeetingFormArguments arg)
        {
            InitializeComponent();
            Arguments = arg;
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdCreateMeeting_Click(object sender, EventArgs e)
        {
            Form frm = new CreateMeetingAForm();
            frm.Show();
        }

        private void MeetingForm_Load(object sender, EventArgs e)
        {
            /// load from database 
            UserBUS userBUS = new UserBUS();
            FollowerBUS followerBUS = new FollowerBUS();

            UserDTO userDTO = userBUS.GetUserInformation(Arguments.Username);
            List<FollowerDTO> followerList = followerBUS.GetListFollower(Arguments.Username);
            //

            // meetting list
            lvwMeeting.View = View.Details;

            lvwMeeting.Columns.Add("Name", 100, HorizontalAlignment.Left);
            lvwMeeting.Columns.Add("Relationship", 100, HorizontalAlignment.Left);
            lvwMeeting.Columns.Add("Status", 100, HorizontalAlignment.Left);

            DataTable table = new DataTable();

            DataColumn countColumn = new DataColumn(
                "Name", Type.GetType("System.String"));
            table.Columns.Add(countColumn);

            DataColumn idColumn = new DataColumn(
                "Relationship", Type.GetType("System.String"));
            table.Columns.Add(idColumn);

            DataColumn nameColumn = new DataColumn(
                "Status", Type.GetType("System.String"));
            table.Columns.Add(nameColumn);

            for (int i = 0; i < followerList.Count; i++)
            {
                DataRow r = table.NewRow();
                // get follower information
                UserDTO follower = userBUS.GetUserInformation(followerList[i].FollowerUsername);

                r["Name"] = follower.Name;
                r["Relationship"] = followerList[i].Relationship;
                if (follower.IsOnline)
                    r["Status"] = "Online";
                else
                    r["Status"] = "Offline";
                table.Rows.Add(r);
            }


            lvwMeeting.Items.Clear();

            lvwMeeting.FullRowSelect = true;

            foreach (DataRow row in table.Rows)
            {
                ListViewItem item = new ListViewItem(row["Name"].ToString());
                item.SubItems.Add(row["Relationship"].ToString());
                item.SubItems.Add(row["Status"].ToString());
                lvwMeeting.Items.Add(item); //Add this row to the ListView
            }
        }
    }
}
