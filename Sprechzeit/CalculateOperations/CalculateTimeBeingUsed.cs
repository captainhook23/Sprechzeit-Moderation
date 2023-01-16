using Sprechzeit.Config;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprechzeit
{
    public class CalculateTimeBeingUsed
    {     
        double m_CountOfChars;
        double m_TimeOfSounds;
        double factor; //Config Datei
        SpeakFlowConfig speakFlow = new SpeakFlowConfig();
        public CalculateTimeBeingUsed(double countOfChar, double timeOfSounds)
        {
            setCountOfChars(countOfChar);
            setTimeOfSounds(timeOfSounds);
        }

        private void setTimeOfSounds(double value)
        {
            m_TimeOfSounds = value;
        }

        private void setCountOfChars(double value)
        {
            m_CountOfChars = value;
        }

        public double getTalkTime()
        {
            factor = speakFlow.GetSpeakFlow();
            return m_CountOfChars / factor;
        }

        public double getFullSumOfTimeInSec()
        {
            return m_TimeOfSounds + getTalkTime();
        }

        public double getSumOfTimeInMin()
        {
            return ((m_TimeOfSounds + getTalkTime()) / 60);
        }

        public double getSumOfTimeInSec()
        {
            if (m_CountOfChars + m_TimeOfSounds <= 59)
            {
                return getFullSumOfTimeInSec();
            }
            else
            {
                return getSumOfTimeInMin() % ((int)getSumOfTimeInMin()) * 60;
            }
        }
    }
}
