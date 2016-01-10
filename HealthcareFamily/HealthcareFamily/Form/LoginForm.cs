using HealthcareFamilyBUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using HealthcareFamilyGUI.FormArguments;

namespace HealthcareFamilyGUI
{
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void cmdSignIn_Click(object sender, EventArgs e)
        {
            // doi tuong login
            String username = txtUserName.Text;
            String password = txtPassword.Text;
            UserBUS userBUS = new UserBUS();

            if (userBUS.SignIn(username, password))
            {
                this.Hide();

                // main form arguments
                MainProgramFormArguments arg = new MainProgramFormArguments();
                arg.Username = username;

                var frm = new MainProgramForm(arg);
                frm.Closed += (s, args) => this.Close();

                frm.Show();
            }
            else
            {
                MetroMessageBox.Show(this, "Wrong username or password :(", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void cmdSignUp_Click(object sender, EventArgs e)
        {
            
            
            this.Hide();

            var frm = new SignUpFirstStepForm();
            frm.ShowDialog();

            //this.Close();
            this.Show();
        }

        
    }
}
