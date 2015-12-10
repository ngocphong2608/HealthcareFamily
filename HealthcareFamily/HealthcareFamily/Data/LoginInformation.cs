using System;
using System.Collections.Generic;
using System.Text;

namespace HealthcareFamily.Data
{
    class LoginInformation
    {
        public string mUsername { get; set; }
        public string mPassword { get; set; }

        public LoginInformation(String username, String password)
        {
            mUsername = username;
            mPassword = password; 
        }
    }
}
