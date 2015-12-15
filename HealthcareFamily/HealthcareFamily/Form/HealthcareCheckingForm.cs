using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HealthcareFamilyDTO
{
    public partial class HealthcareCheckingForm : Form
    {
        public HealthcareCheckingForm()
        {
            InitializeComponent();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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


            this.DialogResult = DialogResult.OK;
        }
    }
}
