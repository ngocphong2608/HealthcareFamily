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
        AppointmentScheduleDAL app;
        public AppointmentScheduleBUS()
        {
            app = new AppointmentScheduleDAL();
        }
        // return: list appointment where username = username or username = partner
        public List<AppointmentScheduleDTO> GetListAppointmentSchedule(string username)
        {
            return app.GetListAppointmentSchedule(username);
        }
    }
}
