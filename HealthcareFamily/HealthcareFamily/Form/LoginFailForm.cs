using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HealthcareFamilyGUI
{
    public partial class LoginFailForm : Form
    {
        public LoginFailForm()
        {
            InitializeComponent();
        }

        private void cmdLoginAgain_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
