using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using HealthcareFamilyGUI.FormArguments;
using HealthcareFamilyDTO;
using HealthcareFamilyBUS;
using HeathcareFamilyBUS;
using HeathcareFamilyDTO;

namespace HealthcareFamilyGUI
{
    public partial class DoctorInformationForm : MetroForm
    {
        public DoctorInformationForm()
        {
            InitializeComponent();
        }
        public DoctorInformationForm(UserInformationFormArguments arg)
        {
            InitializeComponent();
            Arguments = arg;
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DoctorInformationForm_ReLoad()
        {
            // load database

            UserBUS userBUS = new UserBUS();
            UserDTO userDTO = userBUS.GetUserInformation(Arguments.FollowerUsername);

            AppointmentScheduleBUS app = new AppointmentScheduleBUS();
            List<AppointmentScheduleDTO> appList = app.GetListAppointmentSchedule(Arguments.Username, Arguments.FollowerUsername);

            //

            txtName.Text = userDTO.Name;
            txtGender.Text = userDTO.Gender;
            txtEmail.Text = userDTO.Email;
            txtCurrentName.Text = userDTO.Name;
            txtUsername.Text = userDTO.Username;

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
            arg.DoctorUsername = Arguments.FollowerUsername;

            Form frm = new CreateMeetingForm(arg);
            frm.ShowDialog();

            DoctorInformationForm_ReLoad();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
