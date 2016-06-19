
using BUS.DAL_WS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HeathcareFamilyBUS
{
    public class HealthcareBUS
    {
        HF_DAL_WebserviceSoapClient ws;
        public HealthcareBUS()
        {
            ws = new HF_DAL_WebserviceSoapClient();
        }
        public List<HealthcareDTO> GetListHealthcareInformation(String username)
        {
            List<HealthcareDTO>  healthcareList = new List<HealthcareDTO>( ws.GetListHealthcareInformation(username));
            if (healthcareList == null)
                return new List<HealthcareDTO>();

            healthcareList.Sort((x, y) => y.Time.CompareTo(x.Time));
            return healthcareList;
        }
        public void InsertHealthCareInformation(String username, HealthcareDTO healthcare)
        {
            ws.InsertHealthCareInformation(username, healthcare);
        }
    }
}
