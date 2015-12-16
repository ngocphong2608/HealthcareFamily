using HealthcareFamilyBUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HealthcareFamilyDTO
{
    public partial class FamilyInformationForm : Form
    {
        public FamilyInformationForm()
        {
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
            frm.ShowDialog();
        }

        private void FamilyInformationForm_Load(object sender, EventArgs e)
        {

            // capture object from parent form
            //
            UserInformationBUS bus = new UserInformationBUS();

            UserInformation user = bus.LoadUserInformation("admin");

            txtUsername.Text = "admin1";
            txtFullname.Text = "admin - 1";
            txtRelationship.Text = "family";
            txtEmail.Text = "abc@gmail.com";

            txtHeartBeat.Text = "100";
            txtEmotion.Text = "fun";

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

            for (int i = 0; i < 1; i++)
            {
                DataRow r = table.NewRow();
                r["Date"] = "2/3/2015";
                r["Heartbeat"] = "101";
                r["Emotion"] = "crazzy";
                table.Rows.Add(r);
            }

            for (int i = 0; i < 1; i++)
            {
                DataRow r = table.NewRow();
                r["Date"] = "21/3/2015";
                r["Heartbeat"] = "120";
                r["Emotion"] = "fun";
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
    }
}
