using System;
using System.Collections.Generic;
using System.Text;

namespace HealthcareFamilyDTO
{
    public class FollowerInformation
    {
        public string mUsername { get; set; }
        public string mName { get; set; }
        public string mBirthday { get; set; }
        public string mGender { get; set; }
        public string mEmail { get; set; }
        public string mRelationship { get; set; }
        public Boolean mIsPermitAccessInfo { get; set; }
        public List<HealthcareInformation> mHeathInformation { get; set; }

        public FollowerInformation(
            String username, 
            String name, 
            String birth, 
            String gender, 
            String email, 
            String relationship, 
            Boolean isPermitAccessInfo)
        {
            mUsername = username;
            mName = name;
            mBirthday = birth;
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
