using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HealthcareFamily
{
    public partial class SignUpFirstStepForm : Form
    {
        public SignUpFirstStepForm()
        {
            InitializeComponent();
        }

        bool checkedOK()
        {
            return true; 
        }

        private void cmdNext_Click(object sender, EventArgs e)
        {
            String userName;
            String password;
            String passwordAgain;
            String accountType;
            String email;
            
            userName = txtUserName.Text;
            password = txtPassword.Text;
            passwordAgain = txtPasswordAgain.Text;
            accountType = cboAccountType.SelectedItem.ToString();
            email = txtEmail.Text; 

            if (checkedOK() && password.Equals(passwordAgain))
            {
                this.Hide();    

                var frm = new SignUpSecondStepForm();
                frm.ShowDialog();
            }
            else 
            {
                MessageBox.Show("error", "oop!!!", MessageBoxButtons.OK);
            }
        }

        private void SignUpFirstStepForm_Load(object sender, EventArgs e)
        {
            if (FormControl.closedSignUpSecondStepForm)
                this.Close();
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