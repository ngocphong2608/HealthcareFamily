using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HealthcareFamily
{
    public partial class DoctorInformationForm : Form
    {
        public DoctorInformationForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DoctorInformationForm_Load(object sender, EventArgs e)
        {

            // load from database
            txtName.Text = "doctor1";
            txtGender.Text = "male";
            txtEmail.Text = "abc@gmail.com";
        }
    }
}
