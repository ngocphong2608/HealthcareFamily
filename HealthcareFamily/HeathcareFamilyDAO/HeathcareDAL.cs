using HealthcareFamilyDAL;
using HealthcareFamilyDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareFamilyDAL
{
    public class HealthcareDAL
    {
        public List<HealthcareDTO> GetListHealthcareInformation(string username)
        {
            String query = "SELECT * FROM HEALTHCARE_INFORMATION WHERE USERNAME='" + username + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            List<HealthcareDTO> ListHealth = new List<HealthcareDTO>();

            foreach (DataRow dr in dt.Rows)
            {
                HealthcareDTO health = new HealthcareDTO();
                health.Emotion = dr["Emotion"].ToString();
                health.HeartBeat = dr["HeartBeat"].ToString();
                health.Time = DateTime.Parse(dr["Time"].ToString());
                ListHealth.Add(health);
            }

            return ListHealth;
        }

        public void InsertHealthCareInformation(String username, HealthcareDTO healthcare)
        {
            String query = "set dateformat dmy\n";
            query += "INSERT INTO HEALTHCARE_INFORMATION VALUES(";
            query += "'" + username + "', ";
            query += "'" + healthcare.Time.ToShortDateString() + " " + healthcare.Time.Hour + ":" + healthcare.Time.Minute + ":" + healthcare.Time.Second + "', ";
            query += healthcare.HeartBeat + ", ";
            query += "'" + healthcare.Emotion + "')";
            DataProvider.ExecuteNonQuery(query);
        }
    }
}
