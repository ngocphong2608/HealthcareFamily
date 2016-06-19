using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using HealthcareFamilyGUI.FormArguments;
using MetroFramework;
using HealthcareFamilyGUI.BUS_Webservice;

namespace HealthcareFamilyGUI
{
    public partial class DoctorInformationForm : MetroForm
    {
        public DoctorInformationForm()
        {
            InitializeComponent();
        }

        HF_BUS_WebserviceSoapClient bus;
        public DoctorInformationForm(UserInformationFormArguments arg)
        {
            InitializeComponent();
            Arguments = arg;
            bus = new HF_BUS_WebserviceSoapClient();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DoctorInformationForm_ReLoad()
        {
            // load database


            UserDTO follower = bus.GetUserInformation(Arguments.FollowerUsername);
            UserDTO user = bus.GetUserInformation(Arguments.Username);

            
            List<AppointmentScheduleDTO> appList = new List<AppointmentScheduleDTO>(bus.GetListAppointmentSchedule(Arguments.Username, Arguments.FollowerUsername));

            // privacy
            SharingInfoDTO sharingDTO = bus.GetSharingInfo(Arguments.Username, Arguments.FollowerUsername);


            if (user.AccountType == "Family")
            {
                if (sharingDTO.IsPermitAccessInfo == true)
                {
                    btnPrivacy.Text = "Privacy - Disabled";
                }
                else
                    btnPrivacy.Text = "Privacy - Enabled";
            }
            else if (user.AccountType == "Doctor")
            {
                btnPrivacy.Enabled = false;
            }

            //

            txtName.Text = follower.Name;
            txtGender.Text = follower.Gender;
            txtEmail.Text = follower.Email;
            txtCurrentName.Text = follower.Name;
            txtUsername.Text = follower.Username;

            DataTable table = new DataTable();

            DataColumn partnerColumn = new DataColumn(
                "Partner", Type.GetType("System.String"));
            table.Columns.Add(partnerColumn);

            DataColumn countColumn = new DataColumn(
                "Date", Type.GetType("System.String"));
            table.Columns.Add(countColumn);

            DataColumn nameColumn = new DataColumn(
                "Description", Type.GetType("System.String"));
            table.Columns.Add(nameColumn);

            for (int i = 0; i < appList.Count; i++)
            {
                DataRow r = table.NewRow();
                r["Partner"] = appList[i].PartnerUsername;
                r["Date"] = appList[i].Time;
                r["Description"] = appList[i].Detail;
                table.Rows.Add(r);
            }

            lvwMeeting.Items.Clear();

            lvwMeeting.FullRowSelect = true;

            foreach (DataRow row in table.Rows)
            {
                ListViewItem item = new ListViewItem(row["Partner"].ToString());
                item.SubItems.Add(row["Date"].ToString());
                item.SubItems.Add(row["Description"].ToString());
                lvwMeeting.Items.Add(item); //Add this row to the ListView
            }
        }

        private void DoctorInformationForm_Load(object sender, EventArgs e)
        {
            

            // list view
            lvwMeeting.View = View.Details;

            lvwMeeting.Columns.Add("Partner", 100, HorizontalAlignment.Left);
            lvwMeeting.Columns.Add("Date", 100, HorizontalAlignment.Left);
            lvwMeeting.Columns.Add("Description", 100, HorizontalAlignment.Left);

            DoctorInformationForm_ReLoad();
        }

        private void cmdCreateMeeting_Click(object sender, EventArgs e)
        {
            CreateMeetingFormArguments arg = new CreateMeetingFormArguments();

            arg.Username = Arguments.Username;
            arg.SelectedUsername = Arguments.FollowerUsername;

            Form frm = new CreateMeetingForm(arg);
            frm.ShowDialog();

            DoctorInformationForm_ReLoad();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdDeleteMeeting_Click(object sender, EventArgs e)
        {
            if (lvwMeeting.SelectedItems.Count > 0)
            {
                AppointmentScheduleDTO appDTO = new AppointmentScheduleDTO();

                appDTO.PartnerUsername = lvwMeeting.SelectedItems[0].SubItems[0].Text;
                DateTime dt = DateTime.Parse(lvwMeeting.SelectedItems[0].SubItems[1].Text);
                appDTO.Time = dt.ToShortDateString() + " " + dt.Hour + ":" + dt.Minute + ":" + dt.Second;
                appDTO.Username = Arguments.Username;

                
                bus.DeleteAppointmentSchedule(appDTO);

                DoctorInformationForm_ReLoad();
            }
            else
            {
                MetroMessageBox.Show(this, "Please choose an meeting!", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnPrivacy_Click(object sender, EventArgs e)
        {
            if (btnPrivacy.Text == "Privacy - Enabled")
            {
                btnPrivacy.Text = "Privacy - Disabled";

                bus.UpdateSharingInfo(Arguments.Username, Arguments.FollowerUsername, true);
            }
            else if (btnPrivacy.Text == "Privacy - Disabled")
            {
                btnPrivacy.Text = "Privacy - Enabled";

                bus.UpdateSharingInfo(Arguments.Username, Arguments.FollowerUsername, false);
            }
        }
    }
}
