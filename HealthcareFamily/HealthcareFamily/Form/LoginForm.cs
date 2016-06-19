
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
using HealthcareFamilyGUI.BUS_Webservice;

namespace HealthcareFamilyGUI
{
    public partial class LoginForm : MetroForm
    {
        HF_BUS_WebserviceSoapClient bus;
        public LoginForm()
        {
            bus = new HF_BUS_WebserviceSoapClient();
            InitializeComponent();
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            //txtUserName.Focus(s)
            
        }

        private void cmdSignIn_Click(object sender, EventArgs e)
        {
            // doi tuong login
            String username = txtUserName.Text;
            String password = txtPassword.Text;

            if (bus.SignIn(username, password))
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
