using System;
using System.Collections.Generic;
using System.Text;

namespace HealthcareFamilyDTO
{
    public class FollowerDTO
    {
        public string Username { get; set; }
        public string FollowerUsername { get; set; }
        public string Relationship { get; set; }
        //public Boolean IsPermitAccessInfo { get; set; }
        public Boolean IsUserAccepted { get; set; }
    }
}
