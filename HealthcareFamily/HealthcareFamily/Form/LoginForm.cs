using HealthcareFamilyBUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HealthcareFamilyGUI
{
    public partial class LoginForm : Form
    {

        private String usrTesting = "";
        private String passTesting = "";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void cmdSignIn_Click(object sender, EventArgs e)
        {
            //String userName;
            //String password;

            //// doi tuong login
            //userName = txtUserName.Text;
            //password = txtPassword.Text; 

            //if (usrTesting.Equals(userName)
            //    && password.Equals(password))
            //{
            //    this.Hide();

            //    var frm = new MainProgramForm();
            //    frm.Closed += (s, args) => this.Close();


            //    // set user name to title bar in main menu

            //    frm.Text = "admin - username:admin";


            //    frm.Show();
            //}
            //else
            //{
            //    //this.Hide();

            //    var frm = new LoginFailForm();
            //    frm.ShowDialog();
                
            //}

            // doi tuong login
            String userName = txtUserName.Text;
            String password = txtPassword.Text;
            UserBUS userBUS = new UserBUS();

            if (userBUS.SignIn(userName, password))
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
                //this.Hide();

                var frm = new LoginFailForm();
                frm.ShowDialog();

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
