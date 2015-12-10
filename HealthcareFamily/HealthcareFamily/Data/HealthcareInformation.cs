using System;
using System.Collections.Generic;
using System.Text;

namespace HealthcareFamily
{
    class HealthcareInformation
    {
        public int mHeartBeat { get; set; }
        public string mEmotion { get; set; }
        public string mTime { get; set; }

        public HealthcareInformation(int heartBeat, String emotion, String time)
        {
            mHeartBeat = heartBeat;
            mEmotion = emotion;
            mTime = time; 
        }
    }
}
