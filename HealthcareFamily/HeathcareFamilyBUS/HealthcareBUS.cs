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
            return health.GetListHealthcareInformation(username);
        }
    }
}
