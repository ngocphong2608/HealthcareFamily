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
            String query = "SELECT * FROM HEATHCARE_FORMATION WHERE USERNAME='" + username + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            List<HealthcareDTO> ListHealth = new List<HealthcareDTO>();

            foreach (DataRow dr in dt.Rows)
            {
                HealthcareDTO health = new HealthcareDTO();
                health.Emotion = dr["Emotion"].ToString();
                health.HeartBeat = dr["HearthBeat"].ToString();
                health.Time = DateTime.Parse(dr["Time"].ToString());
                ListHealth.Add(health);
            }

            return ListHealth;
        }
    }
}
