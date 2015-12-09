using System;
using System.Collections.Generic;
using System.Text;

namespace HealthcareFamily.Data
{
    class LoginInformation
    {
        String mUsername;
        String mPassword; 

        public LoginInformation(String username, String password)
        {
            mUsername = username;
            mPassword = password; 
        }
    }
}
