using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        double numberOfChars;
        double timeOfSounds;

        public CalculateTimeBeingUsedForm()
        {
            InitializeComponent();
        }

        private void buttonCalculateTime_Click(object sender, EventArgs e)
        {
            CalculateTime();
        }

        private void textBoxTimeOfSounds_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalculateTime();
            }
        }

        private void textBoxNumberOfChars_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalculateTime();
            }
        }

        private void CheckInput()
        {
            double value = 0.0;
            if (textBoxNumberOfChars.Text != string.Empty && textBoxTimeOfSounds.Text != string.Empty)
            {
                if (!double.TryParse(textBoxNumberOfChars.Text, out value) || !double.TryParse(textBoxTimeOfSounds.Text, out value))
                {
                    MessageBox.Show("No Digit");
                }
                else
                {
                    numberOfChars = Convert.ToDouble(textBoxNumberOfChars.Text);
                    timeOfSounds = Convert.ToDouble(textBoxTimeOfSounds.Text);
                }
            }
            else if (textBoxNumberOfChars.Text == string.Empty || textBoxTimeOfSounds.Text == string.Empty)
            {
                if (textBoxNumberOfChars.Text == string.Empty)
                {
                    textBoxNumberOfChars.Text = "0";
                    numberOfChars = Convert.ToDouble(textBoxNumberOfChars.Text);
                }
                if (textBoxTimeOfSounds.Text == string.Empty)
                {
                    textBoxTimeOfSounds.Text = "0";
                    timeOfSounds = Convert.ToDouble(textBoxTimeOfSounds.Text);
                }
                if (!double.TryParse(textBoxNumberOfChars.Text, out value) || !double.TryParse(textBoxTimeOfSounds.Text, out value))
                {
                    MessageBox.Show("No Digit");
                }
                else
                {
                    numberOfChars = Convert.ToDouble(textBoxNumberOfChars.Text);
                    timeOfSounds = Convert.ToDouble(textBoxTimeOfSounds.Text);
                }
            }
        } //MessageBox bearbeiten (Negative Zahlen)

        private void DoOutput()
        {
            CalculateTimeBeingUsed calcTime = new CalculateTimeBeingUsed(numberOfChars, timeOfSounds);

            double resultSpeakTime = Math.Round(calcTime.getTalkTime(), 2);
            string resultSpeakTimeRounded = Convert.ToString(resultSpeakTime);
            textBoxSpeakTimeInSeconds.Text = resultSpeakTimeRounded;

            double resultSumOfTime = Math.Round(calcTime.getFullSumOfTimeInSec(), 2);
            string resultSumOfTimeRounded = Convert.ToString(resultSumOfTime);
            textBoxSumOfTime.Text = resultSumOfTimeRounded;

            if (calcTime.getFullSumOfTimeInSec() <= 59)
            {
                string resultSumOfTimeJustInSec = Convert.ToString(calcTime.getFullSumOfTimeInSec());
                textBoxSumOfTimeInMinAndSec.Text = resultSumOfTimeJustInSec + " Sek";
            }
            else
            {
                string resultSumOfTimeInMin = Convert.ToString(((int)calcTime.getSumOfTimeInMin()));
                string resultSumOfTimeInSec = Convert.ToString(((int)calcTime.getSumOfTimeInSec()));
                textBoxSumOfTimeInMinAndSec.Text = resultSumOfTimeInMin + " Min " + resultSumOfTimeInSec + " Sek";
            }
        }

        private void CalculateTime()
        {
            CheckInput();
            DoOutput();
        }
    }
}

