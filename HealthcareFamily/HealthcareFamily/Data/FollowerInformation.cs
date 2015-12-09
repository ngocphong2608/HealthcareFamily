using System;
using System.Collections.Generic;
using System.Text;

namespace HealthcareFamily
{
    class FollowerInformation
    {
        String mUsername;
        String mName;
        String mAge;
        String mGender;
        String mEmail; 
        String mRelationship;
        Boolean mIsPermitAccessInfo;

        List<HealthcareInformation> mHeathInformation; 

        public FollowerInformation(
            String username, 
            String name, 
            String age, 
            String gender, 
            String email, 
            String relationship, 
            Boolean isPermitAccessInfo)
        {
            mUsername = username;
            mName = name;
            mAge = age;
            mGender = gender;
            mEmail = email;
            mRelationship = relationship;
            mIsPermitAccessInfo = isPermitAccessInfo;
        }

        public void setHeathInformation(List<HealthcareInformation> heathInformation)
        {
            mHeathInformation = heathInformation;
        }
    }
}
