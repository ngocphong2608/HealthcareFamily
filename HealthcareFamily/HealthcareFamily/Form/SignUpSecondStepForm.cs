using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using HealthcareFamilyBUS;

namespace HealthcareFamilyGUI
{
    public partial class SignUpSecondStepForm : MetroForm
    {
        public SignUpSecondStepForm()
        {
            InitializeComponent();
        }

        public SignUpSecondStepForm(UserController user)
        {
            InitializeComponent();
            userControler = user;
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
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
            UserBUS userBUS = new UserBUS();

            bool success = userBUS.SignUp(userControler.Username, userControler.Password, fullname, birthday, gender, userControler.Email, userControler.AccountType);
            ////

            if (success)
            {
                MetroMessageBox.Show(this, "Please login to start the App :)", "Finish"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MetroMessageBox.Show(this, "Something wrong, please contact admin to get more information", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
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
