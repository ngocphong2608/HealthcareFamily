using System;
using System.Collections.Generic;
using System.Text;

namespace HealthcareFamily
{
    class UserInformation
    {
        public string mUsername { get ; set; }
        public string mPassword { get; set; }
        public string mName { get; set; }
        public string mBirthday { get; set; }
        public string mGender { get; set; }
        public string mEmail { get; set; }
        public string mAccountType { get; set; }

        public List<FollowerInformation> mFollower { get; set; }

        public List<HealthcareInformation> mHeathInfo { get; set; }

        public UserInformation(String username, String password, String name, 
            String birth, String gender, String email, String accountType)
        {
            mUsername = username;
            mPassword = password;
            mName = name;
            mBirthday = birth;
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
