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
        double countNumberOfChars;
        double timeOfSounds;
        double factor; //Config Datei
        public CalculateTimeBeingUsedForm timeBeingUsedForm;
        public CalculateTimeBeingUsed()
        {
        }
        private void GetTextBoxInputs()
        {
            double value = 0.0;
            if (this.timeBeingUsedForm.numberOfChars != string.Empty && this.timeBeingUsedForm.timeOfSounds != string.Empty)
            {
                if (!double.TryParse(timeBeingUsedForm.numberOfChars, out value) || !double.TryParse(timeBeingUsedForm.timeOfSounds, out value))
                {
                    MessageBox.Show("No Digit");
                }
                else
                {
                    countNumberOfChars = Convert.ToDouble(timeBeingUsedForm.numberOfChars);
                    timeOfSounds = Convert.ToDouble(timeBeingUsedForm.timeOfSounds);
                }
            }
            else if (timeBeingUsedForm.numberOfChars == string.Empty || timeBeingUsedForm.timeOfSounds == string.Empty)
            {
                if (timeBeingUsedForm.numberOfChars == string.Empty)
                {
                    countNumberOfChars = 0;
                    timeBeingUsedForm.numberOfChars = Convert.ToString(countNumberOfChars);
                }
                if (timeBeingUsedForm.timeOfSounds == string.Empty)
                {
                    timeOfSounds = 0;
                    timeBeingUsedForm.timeOfSounds = Convert.ToString(timeOfSounds);
                }
                if (!double.TryParse(timeBeingUsedForm.numberOfChars, out value) || !double.TryParse(timeBeingUsedForm.timeOfSounds, out value))
                {
                    MessageBox.Show("No Digit");
                }
                else
                {
                    countNumberOfChars = Convert.ToDouble(timeBeingUsedForm.numberOfChars);
                    timeOfSounds = Convert.ToDouble(timeBeingUsedForm.timeOfSounds);
                }
            }
        }
        private void GetResultOfSpeakTime()
        {
            double resultSpeakTime = Math.Round(GetTalkTime(), 2);
            string resultSpeakTimeRounded = Convert.ToString(resultSpeakTime);
            timeBeingUsedForm.speakTimeInSec = resultSpeakTimeRounded;
        }
        private void GetSumOfTime()
        {
            double resultSumOfTime = Math.Round(GetFullSumOfTimeInSec(), 2);
            string resultSumOfTimeRounded = Convert.ToString(resultSumOfTime);
            timeBeingUsedForm.sumOfTime = resultSumOfTimeRounded;
        }
        private void GetDetailedSumOfTime()
        {
            if (GetFullSumOfTimeInSec() <= 59)
            {
                string resultSumOfTimeJustInSec = Convert.ToString(Math.Round(GetFullSumOfTimeInSec()));
                timeBeingUsedForm.sumOfTimeInMinAndSec = resultSumOfTimeJustInSec + " Sek";
            }
            else
            {
                string resultSumOfTimeInMin = Convert.ToString(((int)GetSumOfTimeInMin()));
                string resultSumOfTimeInSec = Convert.ToString(((int)GetSumOfTimeInSec()));
                timeBeingUsedForm.sumOfTimeInMinAndSec = resultSumOfTimeInMin + " Min " + resultSumOfTimeInSec + " Sek";
            }
        }
        public void GetCalculatedTimeOutput()
        {
            GetTextBoxInputs();
            GetResultOfSpeakTime();
            GetSumOfTime();
            GetDetailedSumOfTime();
        }
        private double GetTalkTime()
        {
            factor = SpeakFlowConfig.GetInstance(this).GetSpeakFlow();
            return countNumberOfChars / factor;
        }
        private double GetFullSumOfTimeInSec()
        {
            return timeOfSounds + GetTalkTime();
        }
        private double GetSumOfTimeInMin()
        {
            return ((timeOfSounds + GetTalkTime()) / 60);
        }
        private double GetSumOfTimeInSec()
        {
            if (countNumberOfChars + timeOfSounds <= 59)
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
