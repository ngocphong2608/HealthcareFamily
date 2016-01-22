using HealthcareFamilyBUS;
using HealthcareFamilyDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using HealthcareFamilyGUI.FormArguments;
using HeathcareFamilyBUS;
using HeathcareFamilyDTO;
using HealthcareFamilyGUI;

namespace HealthcareFamilyGUI
{
    public partial class FamilyInformationForm : MetroForm
    {
        public FamilyInformationForm()
        {
            InitializeComponent();
        }

        public FamilyInformationForm(UserInformationFormArguments arg)
        {
            Arguments = arg;
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtCheckHeathCare_Click(object sender, EventArgs e)
        {
            var frm = new HealthcareCheckingForm();
            frm.Show();
        }

        private void FamilyInformationForm_Load(object sender, EventArgs e)
        {
            // sharing button
            SharingInfoBUS sharingBUS = new SharingInfoBUS();
            SharingInfoDTO sharingDTO = sharingBUS.GetSharingInfo(Arguments.Username, Arguments.FollowerUsername);
            if (sharingDTO.IsPermitAccessInfo == true)
            {
                cmdPrivacy.Text = "Privacy - Disabled";
            }
            else
                cmdPrivacy.Text = "Privacy - Enabled";

            // capture object from parent form
            //
            UserBUS userBUS = new UserBUS();
            HealthcareBUS healthcareBUS = new HealthcareBUS();

            UserDTO user = userBUS.GetUserInformation(Arguments.FollowerUsername);

            txtUsername.Text = user.Username;
            txtCurrentName.Text = user.Name;
            txtFullname.Text = user.Name;
            txtRelationship.Text = user.AccountType;
            txtEmail.Text = user.Email;

            // check if user share information
            sharingDTO = sharingBUS.GetSharingInfo(Arguments.FollowerUsername, Arguments.Username);

            if (sharingDTO != null && sharingDTO.IsPermitAccessInfo == false)
                return;

            List<HealthcareDTO> healthcareList = healthcareBUS.GetListHealthcareInformation(Arguments.FollowerUsername);

            if (healthcareList.Count > 0)
            {
                txtHeartBeat.Text = healthcareList[0].HeartBeat;
                txtEmotion.Text = healthcareList[0].Emotion;
            }

            lvwHeathcareInfo.View = View.Details;

            lvwHeathcareInfo.Columns.Add("Date", 100, HorizontalAlignment.Left);
            lvwHeathcareInfo.Columns.Add("Heartbeat", 100, HorizontalAlignment.Left);
            lvwHeathcareInfo.Columns.Add("Emotion", 100, HorizontalAlignment.Left);

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

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTextButton1_Click_1(object sender, EventArgs e)
        {
            if (cmdPrivacy.Text == "Privacy - Enabled")
            {
                cmdPrivacy.Text = "Privacy - Disabled";

                SharingInfoBUS sharingBUS = new SharingInfoBUS();
                sharingBUS.UpdateSharingInfo(Arguments.Username, Arguments.FollowerUsername, true);
            }
            else if (cmdPrivacy.Text == "Privacy - Disabled")
            {
                cmdPrivacy.Text = "Privacy - Enabled";

                SharingInfoBUS sharingBUS = new SharingInfoBUS();
                sharingBUS.UpdateSharingInfo(Arguments.Username, Arguments.FollowerUsername, false);
            }
                
        }
    }
}
