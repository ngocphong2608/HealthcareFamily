using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HealthcareFamily
{
    public partial class MainProgramForm : Form
    {
        public MainProgramForm()
        {
            InitializeComponent();
        }

        private void cmdAddUser_Click(object sender, EventArgs e)
        {
            var frm = new UserFindingForm();
            frm.Show();
        }

        private void MainProgramForm_Load(object sender, EventArgs e)
        {
            /// load from database 
            
            //

            

            txtName.Text = "admin";
            txtAge.Text = "20";

            lvwUserList.View = View.Details;

            lvwUserList.Columns.Add("Name", 100, HorizontalAlignment.Left);
            lvwUserList.Columns.Add("Relationship", 100, HorizontalAlignment.Left);
            lvwUserList.Columns.Add("Status", 100, HorizontalAlignment.Left);

            DataTable table = new DataTable();

            DataColumn countColumn = new DataColumn(
                "Name", Type.GetType("System.String"));
            table.Columns.Add(countColumn);

            DataColumn idColumn = new DataColumn(
                "Relationship", Type.GetType("System.String"));
            table.Columns.Add(idColumn);

            DataColumn nameColumn = new DataColumn(
                "Status", Type.GetType("System.String"));
            table.Columns.Add(nameColumn);

            // add 1 family
            for (int i = 0; i < 1; i++)
            {
                DataRow r = table.NewRow();
                r["Name"] = "admin1";
                r["Relationship"] = "family";
                r["Status"] = "online";
                table.Rows.Add(r);
            }
            
            // add 1 doctor
            for (int i = 0; i < 1; i++)
            {
                DataRow r = table.NewRow();
                r["Name"] = "doctor1";
                r["Relationship"] = "doctor";
                r["Status"] = "online";
                table.Rows.Add(r);
            }

            lvwUserList.Items.Clear();

            lvwUserList.FullRowSelect = true;

            foreach (DataRow row in table.Rows)
            {
                ListViewItem item = new ListViewItem(row["Name"].ToString());
                item.SubItems.Add(row["Relationship"].ToString());
                item.SubItems.Add(row["Status"].ToString());
                lvwUserList.Items.Add(item); //Add this row to the ListView
            }

        }

        private void lvwUserList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            MessageBox.Show("abc");
        }

        private void lvwUserList_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            MessageBox.Show("abc");
        }

        private void lvwUserList_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void lvwUserList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var senderList = (ListView)sender;
        
            var clickedItem = senderList.HitTest(e.Location).Item;
            if (clickedItem != null)
            {
                String Relationship = clickedItem.SubItems[1].Text;

                if (Relationship.Equals("doctor"))
                {
                    // need bring data to next form
                    var frm = new DoctorInformationForm();
                    frm.Show();
                }
                else
                {
                    // need bring data to next form
                    var frm = new FamilyInformationForm();
                    frm.Show();
                }
            }
        }

        private void cmdProfile_Click(object sender, EventArgs e)
        {
            var frm = new FamilyInformationForm();
            frm.Show();
        }

        private void cmdRefesh_Click(object sender, EventArgs e)
        {
            // load data, again
        }
    }
}
