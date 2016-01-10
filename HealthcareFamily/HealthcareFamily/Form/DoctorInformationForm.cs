using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace HealthcareFamilyGUI
{
    public partial class DoctorInformationForm : MetroForm
    {
        public DoctorInformationForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DoctorInformationForm_Load(object sender, EventArgs e)
        {

            // load from database
            txtName.Text = "doctor1";
            txtGender.Text = "male";
            txtEmail.Text = "abc@gmail.com";
            txtCurrentName.Text = "doctor1";
            // list view
            lvwMeeting.View = View.Details;

            lvwMeeting.Columns.Add("Date", 100, HorizontalAlignment.Left);
            lvwMeeting.Columns.Add("Description", 100, HorizontalAlignment.Left);

            DataTable table = new DataTable();

            DataColumn countColumn = new DataColumn(
                "Date", Type.GetType("System.String"));
            table.Columns.Add(countColumn);

            DataColumn nameColumn = new DataColumn(
                "Description", Type.GetType("System.String"));
            table.Columns.Add(nameColumn);

            for (int i = 0; i < 1; i++)
            {
                DataRow r = table.NewRow();
                r["Date"] = "2/3/2015";
                r["Description"] = "meet for health 1";
                table.Rows.Add(r);
            }

            for (int i = 0; i < 1; i++)
            {
                DataRow r = table.NewRow();
                r["Date"] = "21/3/2015";
                r["Description"] = "meet for health 2";
                table.Rows.Add(r);
            }

            lvwMeeting.Items.Clear();

            lvwMeeting.FullRowSelect = true;

            foreach (DataRow row in table.Rows)
            {
                ListViewItem item = new ListViewItem(row["Date"].ToString());
                item.SubItems.Add(row["Description"].ToString());
                lvwMeeting.Items.Add(item); //Add this row to the ListView
            }
        }

        private void cmdCreateMeeting_Click(object sender, EventArgs e)
        {
            Form frm = new CreateMeetingAForm();
            frm.Show();
        }
    }
}
