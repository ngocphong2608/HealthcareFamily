using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using HealthcareFamilyGUI.FormArguments;
using System.IO;
using System.Reflection;
using HealthcareFamilyGUI.BUS_Webservice;

namespace HealthcareFamilyGUI
{
    public partial class MainProgramForm : MetroForm
    {
        public MainProgramForm()
        {
            bus = new HF_BUS_WebserviceSoapClient();
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

        HF_BUS_WebserviceSoapClient bus;
        public MainProgramForm(MainProgramFormArguments arg)
        {
            bus = new HF_BUS_WebserviceSoapClient();
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
            SearchingPeopleFormArguments arg = new SearchingPeopleFormArguments();
            arg.Username = Arguments.Username;

            Form frm = new SearchingPeopleForm(arg);
            frm.Show();
        }

        private void MainProgramForm_ReLoad()
        {
            /// load from database 
            

            UserDTO userDTO = bus.GetUserInformation(Arguments.Username);
            List<FollowerDTO> followerList = new List<FollowerDTO>(bus.GetAllFollowerIsFriend(Arguments.Username));
            //
            
            this.Text = "Home";

            // user avatar
            if (userDTO.Avatar != null)
            {
                MemoryStream ms = new MemoryStream(userDTO.Avatar);
                ptbAvatar.Image = Image.FromStream(ms);
                ptbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
                ptbAvatar.Refresh();
            }

            // user name
            txtName.Text = userDTO.Name;

            // user age
            txtAge.Text = Convert.ToString(DateTime.Now.Year - userDTO.Birthday.Year);

            DataTable table = new DataTable();

            DataColumn countColumn = new DataColumn(
                "Name", Type.GetType("System.String"));
            table.Columns.Add(countColumn);

            DataColumn idColumn = new DataColumn(
                "Relationship", Type.GetType("System.String"));
            table.Columns.Add(idColumn);

            DataColumn emailColumn = new DataColumn(
                "Email", Type.GetType("System.String"));
            table.Columns.Add(emailColumn);

            DataColumn nameColumn = new DataColumn(
                "Status", Type.GetType("System.String"));
            table.Columns.Add(nameColumn);

            for (int i = 0; i < followerList.Count; i++)
            {
                DataRow r = table.NewRow();
                // get follower information
                UserDTO follower = bus.GetUserInformation(followerList[i].FollowerUsername);

                r["Name"] = follower.Name;
                r["Relationship"] = followerList[i].Relationship;
                r["Email"] = bus.GetUserInformation(followerList[i].FollowerUsername).Email;
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
                item.SubItems.Add(row["Email"].ToString());
                item.SubItems.Add(row["Status"].ToString());
                lvwUserList.Items.Add(item); //Add this row to the ListView
            }
        }

        private void MainProgramForm_Load(object sender, EventArgs e)
        {
            // friends list
            lvwUserList.View = View.Details;

            lvwUserList.Columns.Add("Name", 100, HorizontalAlignment.Left);
            lvwUserList.Columns.Add("Relationship", 50, HorizontalAlignment.Left);
            lvwUserList.Columns.Add("Email", 100, HorizontalAlignment.Left);
            lvwUserList.Columns.Add("Status", 100, HorizontalAlignment.Left);

            MainProgramForm_ReLoad();
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

        }

        private void cmdProfile_Click(object sender, EventArgs e)
        {
            UserInformationFormArguments arg = new UserInformationFormArguments();
            arg.Username = Arguments.Username;

            UserDTO userDTO = bus.GetUserInformation(Arguments.Username);

            if (userDTO.AccountType.CompareTo("Family") == 0)
            {
                var frm = new PersonalFamilyInformationForm(arg);
                frm.Show();
            }
            else if (userDTO.AccountType.CompareTo("Doctor") == 0)
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
                    bus.SignOut(Arguments.Username);

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
                bus.SignOut(Arguments.Username);

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
            var result = MetroMessageBox.Show(this, "You are in danger, right? Would you like to notify all people in your list?", "Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // load friend list
                List<FollowerDTO> followerList = new List<FollowerDTO>(bus.GetAllFollowerIsFriend(Arguments.Username));

                // send notifycation to each friend
                DateTime Time = DateTime.Now;
                foreach (FollowerDTO follower in followerList)
                {
                    // set notification
                    bus.SetNotification(Arguments.Username, follower.FollowerUsername, Time, "Your friend are in danger!!!");
                }
            }
        }

        private void cmdMeeting_Click(object sender, EventArgs e)
        {
            MeetingFormArguments arg = new MeetingFormArguments();
            arg.Username = Arguments.Username;
            Form frm = new MeetingForm(arg);
            frm.Show();
        }

        private void lvwUserList_MouseClick(object sender, MouseEventArgs e)
        {
            var senderList = (ListView)sender;

            var clickedItem = senderList.HitTest(e.Location).Item;
            if (clickedItem != null)
            {
                String Relationship = clickedItem.SubItems[1].Text;

                UserInformationFormArguments arg = new UserInformationFormArguments();

                UserDTO follower = bus.GetUserInformationByEmail(clickedItem.SubItems[2].Text);
                arg.FollowerUsername = follower.Username;
                arg.Username = Arguments.Username;

                if (follower.AccountType.Equals("Doctor"))
                {
                    // need bring data to next form
                    var frm = new DoctorInformationForm(arg);
                    frm.Show();
                }
                else if (follower.AccountType.Equals("Family"))
                {
                    // need bring data to next form
                    var frm = new FamilyInformationForm(arg);
                    frm.Show();
                }
            }
        }

        private void cmdRequestNewUser_Click(object sender, EventArgs e)
        {
            UserInformationFormArguments arg = new UserInformationFormArguments();
            arg.Username = Arguments.Username;

            Form frm = new RequestUserForm(arg);

            frm.ShowDialog();

            MainProgramForm_ReLoad();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog fop = new OpenFileDialog();
            fop.Filter = "[JPG,JPEG]|*.jpg";

            if (fop.ShowDialog() == DialogResult.OK)
            {
                // load image
                FileStream fs = new FileStream(@fop.FileName, FileMode.Open, FileAccess.Read);

                byte[] img = new byte[fs.Length];
                fs.Read(img, 0, Convert.ToInt32(fs.Length));

                // save image
                bus.UpdateAvatar(Arguments.Username, img);

                // show image
                MemoryStream ms = new MemoryStream(img);
                ptbAvatar.Image = Image.FromStream(ms);
                ptbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
                ptbAvatar.Refresh();
            }
        }
    }
}
