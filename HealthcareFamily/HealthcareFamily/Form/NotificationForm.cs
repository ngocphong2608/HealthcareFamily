﻿using System;
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
using HealthcareFamilyGUI.BUS_Webservice;

namespace HealthcareFamilyGUI
{
    public partial class NotificationForm : MetroForm
    {
        public NotificationForm()
        {
            InitializeComponent();
        }

        HF_BUS_WebserviceSoapClient bus;
        public NotificationForm(NotificationFormArguments arg)
        {
            InitializeComponent();
            Arguments = arg;
            bus = new HF_BUS_WebserviceSoapClient();
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

            
            List<NotificationDTO> notiList = new List<NotificationDTO>(bus.GetListNotification(Arguments.Username));

            for (int i = 0; i < notiList.Count; i++)
            {
                DataRow r = table.NewRow();
                r["Date"] = notiList[i].Time.ToString();
                r["People"] = notiList[i].FollowerUsername;
                r["Description"] = notiList[i].Detail;
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
