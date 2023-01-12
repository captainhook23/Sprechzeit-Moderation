using Sprechzeit.Config;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprechzeit
{
    public class CalculateTimeBeingUsed
    {
        double m_CountOfChars;
        double m_TimeOfSounds;
        double factor; //Config Datei
        public CalculateTimeBeingUsed(double countOfChar, double timeOfSounds)
        {
            SetCountOfChars(countOfChar);
            SetTimeOfSounds(timeOfSounds);
        }  
       
        private void SetTimeOfSounds (double value)
        {
            m_TimeOfSounds = value;
        }

        private void SetCountOfChars(double value)
        {
            m_CountOfChars= value;
        }

        public double GetTalkTime()
        {
            factor = SpeakFlowConfig.GetInstance(this).GetSpeakFlow();
            return m_CountOfChars / factor;
        }

        public double GetFullSumOfTimeInSec()
        {
            return m_TimeOfSounds + GetTalkTime();
        }

        public double GetSumOfTimeInMin()
        {
            return ((m_TimeOfSounds + GetTalkTime()) / 60);
        }

        public double GetSumOfTimeInSec()
        {
            if(m_CountOfChars + m_TimeOfSounds <= 59)
            {
                return GetFullSumOfTimeInSec();
            }
            else
            {
                return GetSumOfTimeInMin() % ((int)GetSumOfTimeInMin()) * 60;
            }
        }
    }
}
