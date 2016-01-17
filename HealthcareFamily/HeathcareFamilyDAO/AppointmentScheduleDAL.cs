using HealthcareFamilyDAL;
using HeathcareFamilyDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareFamilyDAL
{
    public class AppointmentScheduleDAL
    {
        public List<AppointmentScheduleDTO> GetListAppointmentSchedule(string username)
        {
            String query = "SELECT * FROM APPOINTMENT_SCHEDULE WHERE Username='" + username + "'" + "OR Partner_Username='" + username + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            List<AppointmentScheduleDTO> ListAppointment = new List<AppointmentScheduleDTO>();

            foreach (DataRow dr in dt.Rows)
            {
                AppointmentScheduleDTO app = new AppointmentScheduleDTO();
                app.Detail = dr["Detail"].ToString();
                app.Username = dr["Username"].ToString();
                app.PartnerUsername = dr["Partner_Username"].ToString();
                app.Time = DateTime.Parse(dr["Time"].ToString());
                ListAppointment.Add(app);
            }

            return ListAppointment;
        }
        public void InsertAppoitmentShedule(AppointmentScheduleDTO app)
        {
            String query = "INSERT INTO APPOINTMENT_SCHEDULE VALUES(";
            query += "'" + app.Username + "', ";
            query += "'" + app.Time.ToShortDateString() + "', ";
            query += "'" + app.PartnerUsername + "', ";
            query += "'" + app.Detail + "')";
            DataProvider.ExecuteNonQuery(query);
        }

        public List<AppointmentScheduleDTO> GetListAppointmentSchedule(string username, string follower)
        {
            String query = "SELECT * FROM APPOINTMENT_SCHEDULE WHERE (Username='" + username + "' AND Partner_Username='" + follower + "') ";
            query += "OR (Username='" + follower + "' AND Partner_Username='" + username + "') ";
            DataTable dt = DataProvider.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            List<AppointmentScheduleDTO> ListAppointment = new List<AppointmentScheduleDTO>();

            foreach (DataRow dr in dt.Rows)
            {
                AppointmentScheduleDTO app = new AppointmentScheduleDTO();
                app.Detail = dr["Detail"].ToString();
                app.Username = dr["Username"].ToString();
                app.PartnerUsername = dr["Partner_Username"].ToString();
                app.Time = DateTime.Parse(dr["Time"].ToString());
                ListAppointment.Add(app);
            }

            return ListAppointment;
        }
    }
}
