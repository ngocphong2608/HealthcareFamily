using HealthcareFamilyDAL;
using HealthcareFamilyDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeathcareFamilyBUS
{
    public class HealthcareBUS
    {
        HealthcareDAL health;
        public HealthcareBUS()
        {
            health = new HealthcareDAL();
        }
        public List<HealthcareDTO> GetListHealthcareInformation(String username)
        {
            List<HealthcareDTO>  healthcareList = health.GetListHealthcareInformation(username);
            healthcareList.Sort((x, y) => y.Time.CompareTo(x.Time));
            return healthcareList;
        }
        public void InsertHealthCareInformation(String username, HealthcareDTO healthcare)
        {
            health.InsertHealthCareInformation(username, healthcare);
        }
    }
}
