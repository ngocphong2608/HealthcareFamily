using System;
using System.Collections.Generic;
using System.Text;

namespace HealthcareFamilyDTO
{
    public class UserInformationDTO
    {
        public string Username { get ; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        // avatar

        public string AccountType { get; set; }

        public List<FollowerInformationDTO> Followers { get; set; }

        public List<HealthcareInformationDTO> HeathInfo { get; set; }

        public UserInformationDTO(String username, String password, String name, 
            DateTime birth, String gender, String email, String accountType)
        {
            Username = username;
            Password = password;
            Name = name;
            Birthday = birth;
            Gender = gender;
            Email = email;
            AccountType = accountType;
        }

        public UserInformationDTO() { }
    }
}
