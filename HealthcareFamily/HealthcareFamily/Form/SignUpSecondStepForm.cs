using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

using HealthcareFamilyGUI.FormArguments;
using HealthcareFamilyGUI.BUS_Webservice;

namespace HealthcareFamilyGUI
{
    public partial class SignUpSecondStepForm : MetroForm
    {
        public SignUpSecondStepForm()
        {
            InitializeComponent();
        }

        HF_BUS_WebserviceSoapClient bus = new HF_BUS_WebserviceSoapClient();
        public SignUpSecondStepForm(SignUpSecondStepFromArguments user)
        {
            InitializeComponent();
            userControler = user;
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cmdFinish_Click(object sender, EventArgs e)
        {
            String fullname;
            String gender;
            DateTime birthday;

            fullname = txtFullName.Text;
            gender = cboGender.SelectedItem.ToString();
            birthday = dtpBirthday.Value;

            if (fullname == "")
            {
                MetroMessageBox.Show(this, "Please type your full name", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (gender == "")
            {
                MetroMessageBox.Show(this, "Please select your gender", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //  xu li database
            ///
            bool success = bus.SignUp(userControler.Username.ToLower(), userControler.Password, fullname, birthday, gender, userControler.Email, userControler.AccountType);
            ////

            if (success)
            {
                this.DialogResult = DialogResult.OK;
                MetroMessageBox.Show(this, "Please login to start the App :)", "Finish"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MetroMessageBox.Show(this, "Something wrong, please contact admin to get more information", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.Cancel;
            }

            
            this.Close();
            
            //Environment.Exit(0);

            //var frm = new LoginForm();
            //frm.Closed += (s, args) => this.Close();
            //frm.Show();
            //frm.Focus();
        }

        private void SignUpSecondStepForm_Load(object sender, EventArgs e)
        {
            cboGender.SelectedIndex = 0;
        }
    }
}
