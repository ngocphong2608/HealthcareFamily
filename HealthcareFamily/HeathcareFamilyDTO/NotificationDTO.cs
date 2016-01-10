using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeathcareFamilyDTO
{
    public class NotificationDTO
    {
        public string Username { get; set; }
        public DateTime Time { get; set; }
        public string FollowerUsername { get; set; }
        public string Detail { get; set; }
    }
}
