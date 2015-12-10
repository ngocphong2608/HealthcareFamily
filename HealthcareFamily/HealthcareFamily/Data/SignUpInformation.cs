using System;
using System.Collections.Generic;
using System.Text;

namespace HealthcareFamily.Data
{
    class SignUpInformation
    {
        public string mUsername { get; set; }
        public string mPassword { get; set; }
        public string mName { get; set; }
        public string mBirthday { get; set; }
        public string mGender { get; set; }
        public string mEmail { get; set; }
        public string mAccountType { get; set; }

        public SignUpInformation(String username, String password, String accountType, 
            String email, String name, String gender, String birthday)
        {
            mUsername = username;
            mPassword = password;
            mAccountType = accountType;
            mEmail = email;
            mName = name;
            mGender = gender;
            mBirthday = birthday; 
        }
    }
}
