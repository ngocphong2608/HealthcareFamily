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
    public partial class SignUpFirstStepForm : MetroForm
    {
        public SignUpFirstStepForm()
        {
            InitializeComponent();
        }

        private void cmdNext_Click(object sender, EventArgs e)
        {
            String userName;
            String password;
            String passwordAgain;
            String accountType;
            String email;

            UserBUS user = new UserBUS();

            userName = txtUserName.Text;
            password = txtPassword.Text;
            passwordAgain = txtPasswordAgain.Text;
            accountType = cboAccountType.SelectedItem.ToString();
            email = txtEmail.Text;

            if (userName == "")
            {
                MetroMessageBox.Show(this, "Please choose a username", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (user.GetUserInformation(userName) != null)
            {
                MetroMessageBox.Show(this, "Username existed, please choose another", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (password == "")
            {
                MetroMessageBox.Show(this, "Please choose a password", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (password != passwordAgain)
            {
                MetroMessageBox.Show(this, "Password doesn't match", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (email == "")
            {
                MetroMessageBox.Show(this, "Please choose an email", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (user.IsEmailExisted(email))
            {
                MetroMessageBox.Show(this, "Email existed, please choose another", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (accountType == "")
            {
                MetroMessageBox.Show(this, "Please choose an acccount type", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            UserController userControl = new UserController();
            userControl.Username = userName;
            userControl.Password = password;
            userControl.Email = email;
            userControl.AccountType = accountType;

            this.Hide();

            var frm = new SignUpSecondStepForm(userControl);
            frm.ShowDialog();
        }

        private void SignUpFirstStepForm_Load(object sender, EventArgs e)
        {
            cboAccountType.SelectedIndex = 0;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cboAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}