using System;
using System.Collections.Generic;
using System.Text;

namespace HealthcareFamily.Data
{
    class SignUpInformation
    {
        String mUsername;
        String mPassword;
        String mAccountType;
        String mEmail;
        String mName;
        String mGender;
        String mBirthday; 

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
