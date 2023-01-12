using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Sprechzeit
{
    public partial class CalculateTimeBeingUsedForm : Form
    {
        double countNumberOfChars;
        double timeOfSounds;
        double value = 0.0;
        public CalculateTimeBeingUsedForm()
        {
            InitializeComponent();
        }

        private void buttonCalculateTime_Click(object sender, EventArgs e)
        {
            GetCalculatedTimeOutput();
        }

        private void textBoxTimeOfSounds_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetCalculatedTimeOutput();
            }
        }

        private void textBoxNumberOfChars_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetCalculatedTimeOutput();
            }
        }

        private void GetTextBoxInputs()
        {
            if (textBoxNumberOfChars.Text != string.Empty && textBoxTimeOfSounds.Text != string.Empty)
            {
                if (!double.TryParse(textBoxNumberOfChars.Text, out value) || !double.TryParse(textBoxTimeOfSounds.Text, out value))
                {
                    MessageBox.Show("No Digit");
                }
                else
                {
                    countNumberOfChars = Convert.ToDouble(textBoxNumberOfChars.Text);
                    timeOfSounds = Convert.ToDouble(textBoxTimeOfSounds.Text);
                }
            }
            else if (textBoxNumberOfChars.Text == string.Empty || textBoxTimeOfSounds.Text == string.Empty)
            {
                if (textBoxNumberOfChars.Text == string.Empty)
                {
                    countNumberOfChars = 0;
                    textBoxNumberOfChars.Text = Convert.ToString(countNumberOfChars);
                }
                if (textBoxTimeOfSounds.Text == string.Empty)
                {
                    timeOfSounds = 0;
                    textBoxTimeOfSounds.Text = Convert.ToString(timeOfSounds);
                }
                if (!double.TryParse(textBoxNumberOfChars.Text, out value) || !double.TryParse(textBoxTimeOfSounds.Text, out value))
                {
                    MessageBox.Show("No Digit");
                }
                else
                {
                    countNumberOfChars = Convert.ToDouble(textBoxNumberOfChars.Text);
                    timeOfSounds = Convert.ToDouble(textBoxTimeOfSounds.Text);
                }
            }
        }

        private void GetResultOfSpeakTime()
        {
            CalculateTimeBeingUsed calcTime = new CalculateTimeBeingUsed(countNumberOfChars, timeOfSounds);
            double resultSpeakTime = Math.Round(calcTime.GetTalkTime(), 2);
            string resultSpeakTimeRounded = Convert.ToString(resultSpeakTime);
            textBoxSpeakTimeInSeconds.Text = resultSpeakTimeRounded;
        }

        private void GetSumOfTime()
        {
            CalculateTimeBeingUsed calcTime = new CalculateTimeBeingUsed(countNumberOfChars, timeOfSounds);
            double resultSumOfTime = Math.Round(calcTime.GetFullSumOfTimeInSec(), 2);
            string resultSumOfTimeRounded = Convert.ToString(resultSumOfTime);
            textBoxSumOfTime.Text = resultSumOfTimeRounded;
        }

        private void GetDetailedSumOfTime()
        {
            CalculateTimeBeingUsed calcTime = new CalculateTimeBeingUsed(countNumberOfChars, timeOfSounds);

            if (calcTime.GetFullSumOfTimeInSec() <= 59)
            {
                string resultSumOfTimeJustInSec = Convert.ToString(Math.Round(calcTime.GetFullSumOfTimeInSec()));
                textBoxSumOfTimeInMinAndSec.Text = resultSumOfTimeJustInSec + " Sek";
            }
            else
            {
                string resultSumOfTimeInMin = Convert.ToString(((int)calcTime.GetSumOfTimeInMin()));
                string resultSumOfTimeInSec = Convert.ToString(((int)calcTime.GetSumOfTimeInSec()));
                textBoxSumOfTimeInMinAndSec.Text = resultSumOfTimeInMin + " Min " + resultSumOfTimeInSec + " Sek";
            }
        }

        private void GetCalculatedTimeOutput()
        {
            GetTextBoxInputs();
            GetResultOfSpeakTime();
            GetSumOfTime();
            GetDetailedSumOfTime();
        }
    }
}

