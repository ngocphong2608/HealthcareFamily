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
                app.Time = dr["Time"].ToString();
                ListAppointment.Add(app);
            }

            return ListAppointment;
        }
        public void CreateAppointmentSchedule(AppointmentScheduleDTO app)
        {
            String query = "SET DATEFORMAT DMY\n";
            query += "INSERT INTO APPOINTMENT_SCHEDULE VALUES(";
            query += "'" + app.Username + "', ";
            query += "'" + app.Time + "', ";
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
                app.Time = dr["Time"].ToString();
                ListAppointment.Add(app);
            }

            return ListAppointment;
        }

        public void DeleteAppointmentSchedule(AppointmentScheduleDTO appDTO)
        {
            string query = "SET DATEFORMAT DMY ";
            query += "DELETE APPOINTMENT_SCHEDULE WHERE ";
            query += "(Username ='" + appDTO.Username + "' ";
            query += "AND Partner_Username='" + appDTO.PartnerUsername + "' ";
            query += "AND Time='" + appDTO.Time + "') ";
            query += "OR (Username ='" + appDTO.PartnerUsername + "' ";
            query += "AND Partner_Username='" + appDTO.Username + "' ";
            query += "AND Time='" + appDTO.Time + "') ";

            DataProvider.ExecuteNonQuery(query);
        }
    }
}
