using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeathcareFamilyDTO
{
    public class NotificationDTO
    {
        // username ?
        public DateTime Time { get; set; }
        public string FollowerUsername { get; set; }
        public string Detail { get; set; }
    }
}
