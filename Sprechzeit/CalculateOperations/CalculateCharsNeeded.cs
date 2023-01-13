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
        private double timeInSec;
        private double timeInMin;
        private double timeOfSounds;
        private double factor = 13.25; //Config Datei

        public CalculateCharsNeededForm charsNeededForm;
        public CalculateCharsNeeded()
        {
        }
        private void GetTextBoxInputs()
        {
            double value;
            if (charsNeededForm.timeInMin != string.Empty && charsNeededForm.timeInSec != string.Empty && charsNeededForm.timeOfSounds != string.Empty)
            {
                if (!double.TryParse(charsNeededForm.timeInMin, out value) || !double.TryParse(charsNeededForm.timeInSec, out value) || !double.TryParse(charsNeededForm.timeOfSounds, out value))
                {
                    MessageBox.Show("No Digit");
                }
                else
                {
                    timeInMin = Convert.ToDouble(charsNeededForm.timeInMin);
                    timeInSec = Convert.ToDouble(charsNeededForm.timeInSec);
                    timeOfSounds = Convert.ToDouble(charsNeededForm.timeOfSounds);
                }
            }
            else if (charsNeededForm.timeInMin == string.Empty || charsNeededForm.timeInSec == string.Empty || charsNeededForm.timeOfSounds == string.Empty)
            {
                if (charsNeededForm.timeInMin == string.Empty)
                {
                    timeInMin = 0;
                    charsNeededForm.timeInMin = Convert.ToString(timeInMin);
                }
                if (charsNeededForm.timeInSec == string.Empty)
                {
                    timeInSec = 0;
                    charsNeededForm.timeInSec = Convert.ToString(timeInSec);
                }
                if (charsNeededForm.timeOfSounds == string.Empty)
                {
                    timeOfSounds = 0;
                    charsNeededForm.timeOfSounds = Convert.ToString(timeOfSounds);
                }
                if (!double.TryParse(charsNeededForm.timeInMin, out value) || !double.TryParse(charsNeededForm.timeInSec, out value) || !double.TryParse(charsNeededForm.timeOfSounds, out value))
                {
                    MessageBox.Show("No Digit");
                }
                else
                {
                    timeInMin = Convert.ToDouble(charsNeededForm.timeInMin);
                    timeInSec = Convert.ToDouble(charsNeededForm.timeInSec);
                    timeOfSounds = Convert.ToDouble(charsNeededForm.timeOfSounds);
                }
            }
        }
        private double GetTimeInSeconds()
        {
            return (timeInMin * 60) + timeInSec - timeOfSounds;
        }
        private double GetCharsNeeded()
        {
            return GetTimeInSeconds() * factor;
        }
        private void GetResultOfSpeakTime()
        {
            double resultSpeakTime = GetTimeInSeconds();
            if (resultSpeakTime < 0)
            {
                charsNeededForm.speakTimeInSeconds = "Error";
            }
            else
            {
                string speakTime = Convert.ToString(resultSpeakTime);
                charsNeededForm.speakTimeInSeconds = speakTime;
            }
        }
        private void GetResultOfCharsNeeded()
        {
            int resultCharsNeeded = Convert.ToInt32(GetCharsNeeded());
            if (resultCharsNeeded < 0)
            {
                charsNeededForm.numberOfChars = "Error";
            }
            else
            {
                string resultCharsNeededFullNumber = Convert.ToString(resultCharsNeeded);
                charsNeededForm.numberOfChars = resultCharsNeededFullNumber;
            }
        }
        public void GetCalculatedChars()
        {
            GetTextBoxInputs();
            GetResultOfSpeakTime();
            GetResultOfCharsNeeded();
        }
    }
}
