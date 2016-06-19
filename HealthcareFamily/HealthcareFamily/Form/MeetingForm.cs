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
using MetroFramework;
using HealthcareFamilyGUI.BUS_Webservice;

namespace HealthcareFamilyGUI
{
    public partial class MeetingForm : MetroForm
    {
        public MeetingForm()
        {
            InitializeComponent();
        }

        HF_BUS_WebserviceSoapClient bus;
        public MeetingForm(MeetingFormArguments arg)
        {
            InitializeComponent();
            Arguments = arg;
            bus = new HF_BUS_WebserviceSoapClient();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdCreateMeeting_Click(object sender, EventArgs e)
        {
            CreateMeetingFormArguments arg = new CreateMeetingFormArguments();
            arg.Username = Arguments.Username;
            
            Form frm = new CreateMeetingForm(arg);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                // refresh listview
                MeetingForm_ReLoad();
            }
        }
        private void MeetingForm_ReLoad()
        {
            // load from database
            UserDTO userDTO = bus.GetUserInformation(Arguments.Username);

            List<AppointmentScheduleDTO> appList = new List<AppointmentScheduleDTO>(bus.GetListAppointmentScheduleByUsername(Arguments.Username));

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

        private void MeetingForm_Load(object sender, EventArgs e)
        {
            // list view
            lvwMeeting.View = View.Details;

            lvwMeeting.Columns.Add("Partner", 100, HorizontalAlignment.Left);
            lvwMeeting.Columns.Add("Date", 100, HorizontalAlignment.Left);
            lvwMeeting.Columns.Add("Description", 100, HorizontalAlignment.Left);

            MeetingForm_ReLoad();
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

                MeetingForm_ReLoad();
                
            } else
            {
                MetroMessageBox.Show(this, "Please choose an meeting!", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
