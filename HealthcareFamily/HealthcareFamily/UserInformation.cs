using System;
using System.Collections.Generic;
using System.Text;

namespace HealthcareFamily
{
    class UserInformation
    {
        String mUsername;
        String mPassword;
        String mName;
        String mAge;
        String mGender;
        String mEmail;

        List<FollowerInformation> mFollower;
        List<HealthcareInformation> mHeathInfo;

        public UserInformation(String username, String password, String name, 
            String age, String gender, String email)
        {
            mUsername = username;
            mPassword = password;
            mName = name;
            mAge = age;
            mGender = gender;
            mEmail = email; 
        }

        public void setFollower()
        {

        }

        public void addFollower()
        {

        }

        public void addHealth()
        {

        }

        public void setHeath()
        {

        }
    }
}
