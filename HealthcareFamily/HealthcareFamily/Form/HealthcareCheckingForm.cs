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
            HeartBeat = txtHeartBeat.Text;
            Emotion = cbEmotion.SelectedItem.ToString();

            if (HeartBeat == "")
            {
                MetroMessageBox.Show(this, "Have you input your heart beat yet?", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Emotion == "")
            {
                MetroMessageBox.Show(this, "Have you input your emotion yet?", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // get current time 
            Date = DateTime.Now;

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void HealthcareCheckingForm_Load(object sender, EventArgs e)
        {
            cbEmotion.SelectedIndex = 0;
        }
    }
}
