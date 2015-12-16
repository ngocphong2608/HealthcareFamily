using HealthcareFamilyDAL;
using HealthcareFamilyDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeathcareFamilyDAL
{
    public class HealthcareInformationDAL
    {
        public List<HealthcareInformationDTO> GetListHealthcareInformation(string username)
        {
            String query = "SELECT * FROM HEATHCARE_FORMATION WHERE USERNAME='" + username + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            List<HealthcareInformationDTO> ListHealth = new List<HealthcareInformationDTO>();

            foreach (DataRow dr in dt.Rows)
            {
                HealthcareInformationDTO health = new HealthcareInformationDTO();
                health.Emotion = dr["Emotion"].ToString();
                health.HeartBeat = dr["HearthBeat"].ToString();
                health.Time = DateTime.Parse(dr["Time"].ToString());
                ListHealth.Add(health);
            }

            return ListHealth;
        }
    }
}
