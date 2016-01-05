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
    public partial class SignUpSecondStepForm : MetroForm
    {
        public SignUpSecondStepForm()
        {
            InitializeComponent();
        }



        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cmdFinish_Click(object sender, EventArgs e)
        {
            String fullname;
            String gender;
            String birthday;

            fullname = txtFullName.Text;
            gender = cboGender.SelectedItem.ToString();
            birthday = dtpBirthday.ToString();

            //  xu li database
            ///


            ////

            if (true)
            {
                MetroMessageBox.Show(this, "Please login to start the App :)", "Finish"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
            
            //Environment.Exit(0);

            //var frm = new LoginForm();
            //frm.Closed += (s, args) => this.Close();
            //frm.Show();
            //frm.Focus();
        }
    }
}
