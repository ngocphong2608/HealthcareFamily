using HealthcareFamilyBUS;
using HealthcareFamilyDAL;
using HealthcareFamilyDTO;
using HeathcareFamilyDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeathcareFamilyBUS
{
    public class AppointmentScheduleBUS
    {
        AppointmentScheduleDAL appDAL;
        public AppointmentScheduleBUS()
        {
            appDAL = new AppointmentScheduleDAL();
        }
        // return: list appointment where username = username or username = partner
        public List<AppointmentScheduleDTO> GetListAppointmentSchedule(String username)
        {
            List<AppointmentScheduleDTO> appList = appDAL.GetListAppointmentSchedule(username);
            if (appList == null)
                return new List<AppointmentScheduleDTO>();

            appList.Sort((x, y) => y.Time.CompareTo(x.Time));
            return appList;
        }

        public List<AppointmentScheduleDTO> GetListAppointmentSchedule(string username, string follower)
        {
            List<AppointmentScheduleDTO> appList = appDAL.GetListAppointmentSchedule(username, follower);
            if (appList != null)
                return appList;
            return new List<AppointmentScheduleDTO>();
        }
        public void CreateAppointmentSchedule(string username, string doctorEmail, string time, string detail)
        {
            UserBUS userBUS = new UserBUS();
            UserDTO doctor = userBUS.GetUserInformationByEmail(doctorEmail);

            AppointmentScheduleDAL appDAL = new AppointmentScheduleDAL();
            AppointmentScheduleDTO app = new AppointmentScheduleDTO();
            app.Username = username;
            app.PartnerUsername = doctor.Username;
            app.Time = time;
            app.Detail = detail;

            appDAL.CreateAppointmentSchedule(app);
        }
    }
}
