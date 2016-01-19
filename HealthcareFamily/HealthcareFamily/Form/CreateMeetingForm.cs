using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using MetroFramework.Forms;
using HealthcareFamilyGUI.FormArguments;
using HealthcareFamilyBUS;
using HealthcareFamilyDTO;
using HeathcareFamilyBUS;

namespace HealthcareFamilyGUI
{
    public partial class CreateMeetingForm : MetroForm
    {
        public CreateMeetingForm()
        {
            InitializeComponent();
        }
        public CreateMeetingForm(CreateMeetingFormArguments arg)
        {
            InitializeComponent();
            Arguments = arg;
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            string email = cbDoctor.SelectedItem.ToString();
            DateTime date = dtTime.Value;
            string hour = cbHour.SelectedItem.ToString();
            string minute = cbMinute.SelectedItem.ToString();

            string time = date.ToShortDateString() + " " + hour + ":" + minute + ":0";

            AppointmentScheduleBUS appBUS = new AppointmentScheduleBUS();
            appBUS.CreateAppointmentSchedule(Arguments.Username, email, time, txtDetail.Text);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;

            this.Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateMeetingAForm_Load(object sender, EventArgs e)
        {
            cbHour.SelectedIndex = 0;
            cbMinute.SelectedIndex = 0;

            UserBUS userBUS = new UserBUS();

            if (Arguments.DoctorUsername == null)
            {
                FollowerBUS followerBUS = new FollowerBUS();
                List<FollowerDTO> listFollower = followerBUS.GetAllFollower(Arguments.Username);

                foreach (FollowerDTO follower in listFollower)
                {
                    if (follower.Relationship == "Doctor")
                    {
                        UserDTO user = userBUS.GetUserInformation(follower.FollowerUsername);
                        cbDoctor.Items.Add(user.Email);
                    }
                }
                cbDoctor.SelectedIndex = 0;
            }
            else
            {
                UserDTO doctor = userBUS.GetUserInformation(Arguments.DoctorUsername);

                cbDoctor.Items.Add(doctor.Email);

                cbDoctor.SelectedIndex = 0;
            }
        }
    }
}
