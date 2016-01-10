using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;


namespace HealthcareFamilyGUI
{
    public partial class SearchingPeopleForm : MetroForm
    {
        public SearchingPeopleForm()
        {
            InitializeComponent();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
           
            this.Hide();

            var frm = new SearchingRelationshipForm();
            frm.ShowDialog();

            this.Show();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchingPeopleForm_Load(object sender, EventArgs e)
        {

            // cai cho nay khi nao ong search xong thi no moi hien ra danh sach ket qua
            // tui chi lam demo cho no hien ra thoi 
            lvwPeopleList.View = View.Details;

            lvwPeopleList.Columns.Add("Name", 100, HorizontalAlignment.Left);
            lvwPeopleList.Columns.Add("Email", 100, HorizontalAlignment.Left);

            DataTable table = new DataTable();

            DataColumn countColumn = new DataColumn(
                "Name", Type.GetType("System.String"));
            table.Columns.Add(countColumn);

            DataColumn nameColumn = new DataColumn(
                "Email", Type.GetType("System.String"));
            table.Columns.Add(nameColumn);

            for (int i = 0; i < 1; i++)
            {
                DataRow r = table.NewRow();
                r["Name"] = "admin1";
                r["Email"] = "abc@gmail.com";
                table.Rows.Add(r);
            }

            for (int i = 0; i < 1; i++)
            {
                DataRow r = table.NewRow();
                r["Name"] = "admin2";
                r["Email"] = "bcd@gmail.com";
                table.Rows.Add(r);
            }

            lvwPeopleList.Items.Clear();

            lvwPeopleList.FullRowSelect = true;

            foreach (DataRow row in table.Rows)
            {
                ListViewItem item = new ListViewItem(row["Name"].ToString());
                item.SubItems.Add(row["Email"].ToString());
                lvwPeopleList.Items.Add(item); //Add this row to the ListView
            }
        }
    }
}
