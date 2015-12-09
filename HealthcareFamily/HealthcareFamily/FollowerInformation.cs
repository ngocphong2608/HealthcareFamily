using System;
using System.Collections.Generic;
using System.Text;

namespace HealthcareFamily
{
    class FollowerInformation
    {
        String mUsername;
        String mPassword;
        String mName;
        String mAge;
        String mGender;
        String mEmail; 
        String mRelationship;

        List<HealthcareInformation> mHeathInformation; 

        public FollowerInformation(
            String username, String password, String name,
            String age, String gender, String email, String relationship)
        {
            mUsername = username;
            mPassword = password;
            mName = name;
            mAge = age;
            mGender = gender;
            mEmail = email;
            mRelationship = relationship;
        }

        public void setHeath()
        {

        }
    }
}
