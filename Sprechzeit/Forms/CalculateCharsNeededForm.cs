using Sprechzeit.CalculateOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprechzeit.Forms
{
    public partial class CalculateCharsNeededForm : Form
    {
        double timeInSec;
        double timeInMin;
        double timeOfSounds;
        double value = 0.0;
        public CalculateCharsNeededForm()
        {
            InitializeComponent();
        }

        private void buttonCalculateCharsNeeded_Click(object sender, EventArgs e)
        {
            GetCalculatedChars();
        }

        private void textBoxTimeOfSounds_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetCalculatedChars();
            }
        }

        private void textBoxSumTimeInMin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetCalculatedChars();
            }
        }

        private void textBoxSumTimeInSec_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetCalculatedChars();
            }
        }

        private void GetTextBoxInputs()
        {
            if (textBoxSumTimeInMin.Text != string.Empty && textBoxSumTimeInSec.Text != string.Empty && textBoxTimeOfSounds.Text != string.Empty)
            {
                if (!double.TryParse(textBoxSumTimeInMin.Text, out value) || !double.TryParse(textBoxSumTimeInSec.Text, out value) || !double.TryParse(textBoxTimeOfSounds.Text, out value))
                {
                    MessageBox.Show("No Digit");
                }
                else
                {
                    timeInMin = Convert.ToDouble(textBoxSumTimeInMin.Text);
                    timeInSec = Convert.ToDouble(textBoxSumTimeInSec.Text);
                    timeOfSounds = Convert.ToDouble(textBoxTimeOfSounds.Text);
                }
            }
            else if (textBoxSumTimeInMin.Text == string.Empty || textBoxSumTimeInSec.Text == string.Empty || textBoxTimeOfSounds.Text == string.Empty)
            {
                if (textBoxSumTimeInMin.Text == string.Empty)
                {
                    timeInMin = 0;
                    textBoxSumTimeInMin.Text = Convert.ToString(timeInMin);
                }
                if (textBoxSumTimeInSec.Text == string.Empty)
                {
                    timeInSec = 0;
                    textBoxSumTimeInSec.Text = Convert.ToString(timeInSec);
                }
                if (textBoxTimeOfSounds.Text == string.Empty)
                {
                    timeOfSounds = 0;
                    textBoxTimeOfSounds.Text = Convert.ToString(timeOfSounds);
                }
                if (!double.TryParse(textBoxSumTimeInMin.Text, out value) || !double.TryParse(textBoxSumTimeInSec.Text, out value) || !double.TryParse(textBoxTimeOfSounds.Text, out value))
                {
                    MessageBox.Show("No Digit");
                }
                else
                {
                    timeInMin = Convert.ToDouble(textBoxSumTimeInMin.Text);
                    timeInSec = Convert.ToDouble(textBoxSumTimeInSec.Text);
                    timeOfSounds = Convert.ToDouble(textBoxTimeOfSounds.Text);
                }
            }
        }

        private void GetResultOfSpeakTime()
        {
            CalculateCharsNeeded calcChar = new CalculateCharsNeeded(timeInMin, timeInSec, timeOfSounds);
            double resultSpeakTime = calcChar.getTimeInSeconds();
            if (resultSpeakTime < 0)
            {
                textBoxSpeakTimeInSeconds.Text = "Error";
            }
            else
            {
                string speakTime = Convert.ToString(resultSpeakTime);
                textBoxSpeakTimeInSeconds.Text = speakTime;
            }
        }

        private void GetResultOfCharsNeeded()
        {
            CalculateCharsNeeded calcChar = new CalculateCharsNeeded(timeInMin, timeInSec, timeOfSounds);
            int resultCharsNeeded = Convert.ToInt32(calcChar.getCharsNeeded());
            if (resultCharsNeeded < 0)
            {
                textBoxNumberOfChars.Text = "Error";
            }
            else
            {
                string resultCharsNeededFullNumber = Convert.ToString(resultCharsNeeded);
                textBoxNumberOfChars.Text = resultCharsNeededFullNumber;
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
