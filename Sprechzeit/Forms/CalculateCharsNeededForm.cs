using Sprechzeit.CalculateOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Sprechzeit.Forms
{
    public partial class CalculateCharsNeededForm : Form
    {

        double timeInSec;
        double timeInMin;
        double timeOfSounds;
        public CalculateCharsNeededForm()
        {
            InitializeComponent();
        }

        private void buttonCalculateCharsNeeded_Click(object sender, EventArgs e)
        {
            CalculateChars();
        }

        private void textBoxTimeOfSounds_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalculateChars();
            }
        }

        private void textBoxSumTimeInMin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalculateChars();
            }
        }

        private void textBoxSumTimeInSec_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalculateChars();
            }
        }

        private void CheckInput()
        {
            double value = 0.0;
            if (textBoxTimeOfSounds.Text != string.Empty && textBoxSumTimeInMin.Text != string.Empty && textBoxSumTimeInSec.Text != string.Empty)
            {
                if (!double.TryParse(textBoxTimeOfSounds.Text, out value) || !double.TryParse(textBoxSumTimeInMin.Text, out value) || !double.TryParse(textBoxSumTimeInSec.Text, out value))
                {
                    MessageBox.Show("No Digit");
                }
                else
                {
                    timeInSec = Convert.ToDouble(textBoxSumTimeInSec.Text);
                    timeInMin = Convert.ToDouble(textBoxSumTimeInMin.Text);
                    timeOfSounds = Convert.ToDouble(textBoxTimeOfSounds.Text);
                }
            }

            else if (textBoxTimeOfSounds.Text == string.Empty || textBoxSumTimeInMin.Text == string.Empty || textBoxSumTimeInSec.Text == string.Empty)
            {
                if (textBoxSumTimeInMin.Text == string.Empty)
                {
                    textBoxSumTimeInMin.Text = "0";
                    timeInMin = Convert.ToDouble(textBoxSumTimeInMin.Text);
                }
                if (textBoxSumTimeInSec.Text == string.Empty)
                {
                    textBoxSumTimeInSec.Text = "0";
                    timeInSec = Convert.ToDouble(textBoxSumTimeInSec.Text);
                }
                if (textBoxTimeOfSounds.Text == string.Empty)
                {
                    textBoxTimeOfSounds.Text = "0";
                    timeOfSounds = Convert.ToDouble(textBoxTimeOfSounds.Text);
                }
                if (!double.TryParse(textBoxTimeOfSounds.Text, out value) || !double.TryParse(textBoxSumTimeInMin.Text, out value) || !double.TryParse(textBoxSumTimeInSec.Text, out value))
                {
                    MessageBox.Show("No Digit");
                }
                else
                {
                    timeInSec = Convert.ToDouble(textBoxSumTimeInSec.Text);
                    timeInMin = Convert.ToDouble(textBoxSumTimeInMin.Text);
                    timeOfSounds = Convert.ToDouble(textBoxTimeOfSounds.Text);
                }
            }
        }

        private void DoOutput()
        {
            CalculateCharsNeeded calcChar = new CalculateCharsNeeded(timeInMin, timeInSec, timeOfSounds);

            string resultSpeakTime = Convert.ToString(calcChar.getTimeInSeconds());
            textBoxSpeakTimeInSeconds.Text = resultSpeakTime;

            int resultCharsNeeded = Convert.ToInt32(calcChar.getCharsNeeded());
            string resultCharsNeededFullNumber = Convert.ToString(resultCharsNeeded);
            textBoxNumberOfChars.Text = resultCharsNeededFullNumber;
        }

        public void CalculateChars()
        {
            CheckInput();
            DoOutput();
        }
    }
}
