using System;
using System.Collections.Generic;
using System.Text;

namespace HealthcareFamily
{
    class HealthcareInformation
    {
        int mHeartBeat;
        String mEmotion;
        String mTime; 

        public HealthcareInformation(int heartBeat, String emotion, String time)
        {
            mHeartBeat = heartBeat;
            mEmotion = emotion;
            mTime = time; 
        }
    }
}
