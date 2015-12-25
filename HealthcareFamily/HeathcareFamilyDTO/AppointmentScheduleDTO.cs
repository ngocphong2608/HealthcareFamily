using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeathcareFamilyDTO
{
    public class AppointmentScheduleDTO
    {
        public string Username { get; set; }
        public string PartnerUsername { get; set; }
        public string Detail { get; set; }
        public DateTime Time { get; set; }
    }
}
