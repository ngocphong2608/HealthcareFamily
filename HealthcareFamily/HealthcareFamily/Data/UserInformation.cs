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
        int mAccountType;

        List<FollowerInformation> mFollower;
        List<HealthcareInformation> mHeathInfo;

        public UserInformation(String username, String password, String name, 
            String age, String gender, String email, int accountType)
        {
            mUsername = username;
            mPassword = password;
            mName = name;
            mAge = age;
            mGender = gender;
            mEmail = email;
            mAccountType = accountType;
        }

        public void setFollower(List<FollowerInformation> follower)
        {
            mFollower = follower;
        }


        public void setHeath(List<HealthcareInformation> heathInfo)
        {
            mHeathInfo = heathInfo;
        }
    }
}
