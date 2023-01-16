using Sprechzeit.Config;
using Sprechzeit.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprechzeit.CalculateOperations
{
    public class CalculateCharsNeeded
    {
        double m_TimeInMin;
        double m_TimeInSec;
        double m_TimeOfSounds;
        double factor; //Config Datei
        SpeakFlowConfig speakFlow = new SpeakFlowConfig();

        public CalculateCharsNeeded(double timeInMin, double timeInSec, double timeOfSounds)
        {
            setTimeInMinutes(timeInMin);
            setTimeInSeconds(timeInSec);
            setTimeOfSounds(timeOfSounds);
        }
        private void setTimeInMinutes(double value)
        {
            m_TimeInMin = value;
        }

        private void setTimeInSeconds(double value)
        {
            m_TimeInSec = value;
        }

        private void setTimeOfSounds(double value)
        {
            m_TimeOfSounds = value;
        }

        public double getTimeInSeconds()
        {
            return (m_TimeInMin * 60) + m_TimeInSec - m_TimeOfSounds;
        }

        public double getCharsNeeded()
        {
            factor = speakFlow.GetSpeakFlow();
            return getTimeInSeconds() * factor;
        }
    }
}
