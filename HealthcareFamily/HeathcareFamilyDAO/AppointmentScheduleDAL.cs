using HealthcareFamilyDAL;
using HeathcareFamilyDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeathcareFamilyDAL
{
    public class AppointmentScheduleDAL
    {
        public List<AppointmentScheduleDTO> GetListAppointmentSchedule(string username)
        {
            String query = "SELECT * FROM APPOINTMENT_SCHEDULE WHERE USERNAME='" + username + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            List<AppointmentScheduleDTO> ListAppointment = new List<AppointmentScheduleDTO>();

            foreach (DataRow dr in dt.Rows)
            {
                AppointmentScheduleDTO app = new AppointmentScheduleDTO();
                app.Detail = dr["Detail"].ToString();
                app.PartnerUsername = dr["PartnerUsername"].ToString();
                app.Time = DateTime.Parse(dr["Time"].ToString());
                ListAppointment.Add(app);
            }

            return ListAppointment;
        }
    }
}
