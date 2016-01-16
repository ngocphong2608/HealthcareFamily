using HealthcareFamilyDAL;
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
            if (appList != null)
                return appList;
            return new List<AppointmentScheduleDTO>();
        }
        public void InsertAppoitmentShedule(AppointmentScheduleDTO app)
        {
            appDAL.InsertAppoitmentShedule(app);
        }
    }
}
