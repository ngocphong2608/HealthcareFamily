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

namespace HealthcareFamilyGUI
{
    public partial class LoginForm : MetroForm
    {

        private String usrTesting = "";
        private String passTesting = "";

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

                var frm = new MainProgramForm();
                frm.Closed += (s, args) => this.Close();

                // set user name to title bar in main menu

                frm.Text = "admin - username:admin";


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
