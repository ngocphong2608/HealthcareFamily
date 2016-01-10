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

namespace HealthcareFamilyGUI
{
    public partial class NotificationForm : MetroForm
    {
        public NotificationForm()
        {
            InitializeComponent();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NotificationForm_Load(object sender, EventArgs e)
        {
            lvwNotification.View = View.Details;

            lvwNotification.Columns.Add("Date", 100, HorizontalAlignment.Left);
            lvwNotification.Columns.Add("People", 100, HorizontalAlignment.Left);
            lvwNotification.Columns.Add("Description", 100, HorizontalAlignment.Left);

            DataTable table = new DataTable();

            DataColumn countColumn = new DataColumn(
                "Date", Type.GetType("System.String"));
            table.Columns.Add(countColumn);

            DataColumn peopleColumn = new DataColumn(
                "People", Type.GetType("System.String"));
            table.Columns.Add(peopleColumn);

            DataColumn nameColumn = new DataColumn(
                "Description", Type.GetType("System.String"));
            table.Columns.Add(nameColumn);

            for (int i = 0; i < 1; i++)
            {
                DataRow r = table.NewRow();
                r["Date"] = "2/3/2015";
                r["People"] = "admin1";
                r["Description"] = "update new status";
                table.Rows.Add(r);
            }

            for (int i = 0; i < 1; i++)
            {
                DataRow r = table.NewRow();
                r["Date"] = "21/3/2015";
                r["People"] = "doctor2";
                r["Description"] = "create meeting with you";
                table.Rows.Add(r);
            }

            lvwNotification.Items.Clear();

            lvwNotification.FullRowSelect = true;

            foreach (DataRow row in table.Rows)
            {
                ListViewItem item = new ListViewItem(row["Date"].ToString());
                item.SubItems.Add(row["People"].ToString());
                item.SubItems.Add(row["Description"].ToString());
                lvwNotification.Items.Add(item); //Add this row to the ListView
            }
        }
    }
}
