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

namespace Sprechzeit.Forms
{
    public partial class CalculateCharsNeededForm : Form
    {
        public string timeInMin { get; set; }
        public string timeInSec { get;  set; }
        public string timeOfSounds { get;  set; }
        public string speakTimeInSeconds { get; set; }
        public string numberOfChars { get; set; }
       
        CalculateCharsNeeded charsNeeded = new CalculateCharsNeeded();

        public CalculateCharsNeededForm()
        {
            InitializeComponent();
            timeInSec = textBoxSumTimeInSec.Text;
            timeInMin = textBoxSumTimeInMin.Text;
            timeOfSounds = textBoxTimeOfSounds.Text;
            speakTimeInSeconds= textBoxSpeakTimeInSeconds.Text;
            numberOfChars = textBoxNumberOfChars.Text;            
        }

        private void buttonCalculateCharsNeeded_Click(object sender, EventArgs e)
        {
            charsNeeded.GetCalculatedChars();
        }

        private void textBoxTimeOfSounds_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                charsNeeded.GetCalculatedChars();
            }
        }

        private void textBoxSumTimeInMin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                charsNeeded.GetCalculatedChars();
            }
        }

        private void textBoxSumTimeInSec_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                charsNeeded.GetCalculatedChars();
            }
        }
    }
}
