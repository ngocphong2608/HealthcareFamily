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
            return appDAL.GetListAppointmentSchedule(username);
        }
        public void InsertAppoitmentShedule(AppointmentScheduleDTO app)
        {
            appDAL.InsertAppoitmentShedule(app);
        }
    }
}
