using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using HealthcareFamilyBUS;
using HealthcareFamilyDTO;
using HealthcareFamilyGUI.FormArguments;
using HeathcareFamilyBUS;
using System.IO;
using System.Reflection;

namespace HealthcareFamilyGUI
{
    public partial class MainProgramForm : MetroForm
    {
        public MainProgramForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            foreach (var scrn in Screen.AllScreens)
            {
                if (scrn.Bounds.Contains(this.Location))
                {
                    this.Location = new Point(scrn.Bounds.Right - this.Width, scrn.Bounds.Top);
                    return;
                }
            }
        }

        public MainProgramForm(MainProgramFormArguments arg)
        {
            Arguments = arg;
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            foreach (var scrn in Screen.AllScreens)
            {
                if (scrn.Bounds.Contains(this.Location))
                {
                    this.Location = new Point(scrn.Bounds.Right - this.Width, scrn.Bounds.Top);
                    return;
                }
            }
        }

        private void cmdAddUser_Click(object sender, EventArgs e)
        {
            Form frm = new SearchingPeopleForm();
            frm.Show();
        }

        private void MainProgramForm_Load(object sender, EventArgs e)
        {
            
            /// load from database 
            UserBUS userBUS = new UserBUS();
            FollowerBUS followerBUS = new FollowerBUS();

            UserDTO userDTO = userBUS.GetUserInformation(Arguments.Username);
            List<FollowerDTO> followerList = followerBUS.GetListFollower(Arguments.Username);
            //

            this.Text = "Home";            

            // user name
            txtName.Text = userDTO.Name;

            // user age
            txtAge.Text = Convert.ToString(DateTime.Now.Year - userDTO.Birthday.Year);

            // friends list
            lvwUserList.View = View.Details;

            lvwUserList.Columns.Add("Name", 100, HorizontalAlignment.Left);
            lvwUserList.Columns.Add("Relationship", 100, HorizontalAlignment.Left);
            lvwUserList.Columns.Add("Status", 100, HorizontalAlignment.Left);

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
            

            lvwUserList.Items.Clear();

            lvwUserList.FullRowSelect = true;

            foreach (DataRow row in table.Rows)
            {
                ListViewItem item = new ListViewItem(row["Name"].ToString());
                item.SubItems.Add(row["Relationship"].ToString());
                item.SubItems.Add(row["Status"].ToString());
                lvwUserList.Items.Add(item); //Add this row to the ListView
            }

        }

        private void lvwUserList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            MessageBox.Show("abc");
        }

        private void lvwUserList_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            MessageBox.Show("abc");
        }

        private void lvwUserList_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void lvwUserList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var senderList = (ListView)sender;
        
            var clickedItem = senderList.HitTest(e.Location).Item;
            if (clickedItem != null)
            {
                String Relationship = clickedItem.SubItems[1].Text;

                if (Relationship.Equals("doctor"))
                {
                    // need bring data to next form
                    var frm = new DoctorInformationForm();
                    frm.Show();
                }
                else
                {
                    // need bring data to next form
                    var frm = new FamilyInformationForm();
                    frm.Show();
                }
            }
        }

        private void cmdProfile_Click(object sender, EventArgs e)
        {
            UserInformationFormArguments arg = new UserInformationFormArguments();
            arg.Username = Arguments.Username;

            UserBUS userBUS = new UserBUS();
            UserDTO userDTO = userBUS.GetUserInformation(Arguments.Username);

            if (userDTO.AccountType.CompareTo("Family") == 0)
            {
                var frm = new PersonalFamilyInformationForm(arg);
                frm.Show();
            } else if (userDTO.AccountType.CompareTo("Doctor") == 0)
            {
                var frm = new PersonalDoctorInformationForm(arg);
                frm.Show();
            }
            else
            {
                // account doest exist
                MetroMessageBox.Show(this, "Account type doesn't exist!", "Error", MessageBoxButtons.OK);
            }
        }

        private void cmdRefesh_Click(object sender, EventArgs e)
        {
            // load data, again
        }

        bool flag = false; 

        private void MainProgramForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!flag)
            {
                if (MetroMessageBox.Show(this, "Do you want to logout and exit?", "Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    // Cancel the Closing event from closing the form.
                    e.Cancel = true;

                    // sign out
                    UserBUS user = new UserBUS();
                    user.SignOut(Arguments.Username);

                    // Call method to save file...
                }
            }
        }

        private void cmdLogout_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Do you want to logout and exit?", "Message",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                flag = true;

                // update database 

                this.Close();
 
            }
        }

        private void cmdNotification_Click(object sender, EventArgs e)
        {
            NotificationFormArguments arg = new NotificationFormArguments();
            arg.Username = Arguments.Username;

            Form frm = new NotificationForm(arg);
            frm.Show();
        }

        private void cmdEmergency_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "You are in danger, right? Would you like to notify all people in your list?", "Message", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void cmdMeeting_Click(object sender, EventArgs e)
        {
            Form frm = new MeetingForm();
            frm.Show();
        }

        private void lvwUserList_MouseClick(object sender, MouseEventArgs e)
        {
            var senderList = (ListView)sender;

            var clickedItem = senderList.HitTest(e.Location).Item;
            if (clickedItem != null)
            {
                String Relationship = clickedItem.SubItems[1].Text;

                if (Relationship.Equals("doctor"))
                {
                    // need bring data to next form
                    var frm = new DoctorInformationForm();
                    frm.Show();
                }
                else
                {
                    // need bring data to next form
                    var frm = new FamilyInformationForm();
                    frm.Show();
                }
            }
        }
    }
}
