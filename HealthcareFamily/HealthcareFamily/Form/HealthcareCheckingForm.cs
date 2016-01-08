using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace HealthcareFamilyGUI
{
    public partial class HealthcareCheckingForm : MetroForm
    {
        public HealthcareCheckingForm()
        {
            InitializeComponent();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {

            String heartBeat;
            String emotion;
            String date;

            heartBeat = txtHeartBeat.Text;
            emotion = txtEmotion.Text;

            // get current time 
            date = DateTime.Now.Date.ToString();


            this.Close();
        }
    }
}
