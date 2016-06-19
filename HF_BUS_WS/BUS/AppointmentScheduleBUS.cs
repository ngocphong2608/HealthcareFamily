using BUS.DAL_WS;
using HealthcareFamilyBUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeathcareFamilyBUS
{
    public class AppointmentScheduleBUS
    {
        HF_DAL_WebserviceSoapClient acc;
        public AppointmentScheduleBUS()
        {
            acc = new HF_DAL_WebserviceSoapClient();
        }
        // return: list appointment where username = username or username = partner
        public List<AppointmentScheduleDTO> GetListAppointmentSchedule(String username)
        {
            List<AppointmentScheduleDTO> appList = new List<AppointmentScheduleDTO>(acc.GetListAppointmentScheduleByUsername(username));
            if (appList == null)
                return new List<AppointmentScheduleDTO>();

            foreach (AppointmentScheduleDTO app in appList)
            {
                if (app.PartnerUsername == username)
                {
                    app.PartnerUsername = app.Username;
                }
            }

            appList.Sort((x, y) => y.Time.CompareTo(x.Time));
            return appList;
        }

        public List<AppointmentScheduleDTO> GetListAppointmentSchedule(string username, string follower)
        {
            List<AppointmentScheduleDTO> appList = new List<AppointmentScheduleDTO>(acc.GetListAppointmentSchedule(username, follower));
            if (appList == null)
                return new List<AppointmentScheduleDTO>();

            foreach (AppointmentScheduleDTO app in appList)
            {
                if (app.PartnerUsername == username)
                {
                    app.PartnerUsername = app.Username;
                }
            }

            appList.Sort((x, y) => y.Time.CompareTo(x.Time));
            return appList;
        }
        public void CreateAppointmentSchedule(string username, string doctorEmail, string time, string detail)
        {
            UserBUS userBUS = new UserBUS();
            UserDTO doctor = userBUS.GetUserInformationByEmail(doctorEmail);

            AppointmentScheduleDTO app = new AppointmentScheduleDTO();
            app.Username = username;
            app.PartnerUsername = doctor.Username;
            app.Time = time;
            app.Detail = detail;

            acc.CreateAppointmentSchedule(app);
        }

        public void DeleteAppointmentSchedule(AppointmentScheduleDTO appDTO)
        {
            acc.DeleteAppointmentSchedule(appDTO);
        }
    }
}
