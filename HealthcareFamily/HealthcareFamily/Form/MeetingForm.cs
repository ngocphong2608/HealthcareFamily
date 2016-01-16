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
using HeathcareFamilyDTO;

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
            // load from database
            UserBUS userBUS = new UserBUS();
            UserDTO userDTO = userBUS.GetUserInformation(Arguments.Username);

            AppointmentScheduleBUS app = new AppointmentScheduleBUS();
            List<AppointmentScheduleDTO> appList = app.GetListAppointmentSchedule(Arguments.Username);

            // list view
            lvwMeeting.View = View.Details;

            lvwMeeting.Columns.Add("Partner", 100, HorizontalAlignment.Left);
            lvwMeeting.Columns.Add("Date", 100, HorizontalAlignment.Left);
            lvwMeeting.Columns.Add("Description", 100, HorizontalAlignment.Left);

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
                r["Date"] = appList[i].Time.ToShortDateString();
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
    }
}
