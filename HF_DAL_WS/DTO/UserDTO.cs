using System;
using System.Collections.Generic;
using System.Text;

namespace HealthcareFamilyDTO
{
    public class UserDTO
    {
        public string Username { get ; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public bool IsOnline { get; set; }
        public byte[] Avatar { get; set; }
        public string AccountType { get; set; }

        public List<FollowerDTO> Followers { get; set; }

        public List<HealthcareDTO> HeathInfo { get; set; }
    }
}
