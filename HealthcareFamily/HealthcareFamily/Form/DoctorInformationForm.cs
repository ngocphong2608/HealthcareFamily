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

        private void DoctorInformationForm_Load(object sender, EventArgs e)
        {
            // load database

            UserBUS userBUS = new UserBUS();
            UserDTO userDTO = userBUS.GetUserInformation(Arguments.Username);

            AppointmentScheduleBUS app = new AppointmentScheduleBUS();
            List<AppointmentScheduleDTO> appList = app.GetListAppointmentSchedule(Arguments.Username);

            //

            txtName.Text = userDTO.Name;
            txtGender.Text = userDTO.Gender;
            txtEmail.Text = userDTO.Email;
            txtCurrentName.Text = userDTO.Name;
            txtUsername.Text = userDTO.Username;

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

        private void cmdCreateMeeting_Click(object sender, EventArgs e)
        {
            Form frm = new CreateMeetingAForm();
            frm.Show();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
