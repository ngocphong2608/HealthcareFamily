using HealthcareFamilyBUS;
using HealthcareFamilyDTO;
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

namespace HealthcareFamilyGUI
{
    public partial class PersonalFamilyInformationForm : MetroForm
    {
        public PersonalFamilyInformationForm()
        {
            InitializeComponent();
        }

        public PersonalFamilyInformationForm(UserInformationFormArguments arg)
        {
            InitializeComponent();
            Arguments = arg;
        }
        public void FormReload()
        {
            // capture object from parent form
            //
            UserBUS userBUS = new UserBUS();
            HealthcareBUS healthcareBUS = new HealthcareBUS();

            UserDTO user = userBUS.GetUserInformation(Arguments.Username);
            List<HealthcareDTO> healthcareList = healthcareBUS.GetListHealthcareInformation(Arguments.Username);

            txtUsername.Text = user.Username;
            txtCurrentName.Text = user.Name;
            txtFullname.Text = user.Name;
            //txtRelationship.Text = user.AccountType;
            txtEmail.Text = user.Email;

            if (healthcareList.Count > 0)
            {
                txtHeartBeat.Text = healthcareList[0].HeartBeat;
                txtEmotion.Text = healthcareList[0].Emotion;
            }

            DataTable table = new DataTable();

            DataColumn countColumn = new DataColumn(
                "Date", Type.GetType("System.String"));
            table.Columns.Add(countColumn);

            DataColumn idColumn = new DataColumn(
                "Heartbeat", Type.GetType("System.String"));
            table.Columns.Add(idColumn);

            DataColumn nameColumn = new DataColumn(
                "Emotion", Type.GetType("System.String"));
            table.Columns.Add(nameColumn);

            for (int i = 0; i < healthcareList.Count; i++)
            {
                DataRow r = table.NewRow();
                r["Date"] = healthcareList[i].Time.ToShortDateString();
                r["Heartbeat"] = healthcareList[i].HeartBeat;
                r["Emotion"] = healthcareList[i].Emotion;
                table.Rows.Add(r);
            }

            lvwHeathcareInfo.Items.Clear();

            lvwHeathcareInfo.FullRowSelect = true;

            foreach (DataRow row in table.Rows)
            {
                ListViewItem item = new ListViewItem(row["Date"].ToString());
                item.SubItems.Add(row["Heartbeat"].ToString());
                item.SubItems.Add(row["Emotion"].ToString());
                lvwHeathcareInfo.Items.Add(item); //Add this row to the ListView
            }
        }

        private void PersonalFamilyInformationForm_Load(object sender, EventArgs e)
        {
            lvwHeathcareInfo.View = View.Details;

            lvwHeathcareInfo.Columns.Add("Date", 100, HorizontalAlignment.Left);
            lvwHeathcareInfo.Columns.Add("Heartbeat", 100, HorizontalAlignment.Left);
            lvwHeathcareInfo.Columns.Add("Emotion", 100, HorizontalAlignment.Left);

            FormReload();
        }

        private void txtCheckHeathCare_Click(object sender, EventArgs e)
        {
            var frm = new HealthcareCheckingForm();
            frm.ShowDialog();

            // insert database
            HealthcareBUS healthCareBUS = new HealthcareBUS();
            HealthcareDTO healthcare = new HealthcareDTO();
            healthcare.Emotion = frm.Emotion;
            healthcare.HeartBeat = frm.HeartBeat;
            healthcare.Time = frm.Date;
            healthCareBUS.InsertHealthCareInformation(Arguments.Username, healthcare);
            FormReload();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
