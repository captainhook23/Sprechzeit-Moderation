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
        public string numberOfChars { get; set; }
        public string timeOfSounds { get; set; }
        public string sumOfTime { get; set; } 
        public string speakTimeInSec { get; set; }
        public string sumOfTimeInMinAndSec { get; set; }

        public CalculateTimeBeingUsed timeBeingUsed = new CalculateTimeBeingUsed();               
        public CalculateTimeBeingUsedForm()
        {
            InitializeComponent();
            numberOfChars = textBoxNumberOfChars.Text;
            timeOfSounds = textBoxTimeOfSounds.Text;
            sumOfTimeInMinAndSec = textBoxSumOfTimeInMinAndSec.Text;
            sumOfTime = textBoxSumOfTime.Text;
            speakTimeInSec = textBoxSpeakTimeInSeconds.Text;
        }
        private void buttonCalculateTime_Click(object sender, EventArgs e)
        {
            timeBeingUsed.GetCalculatedTimeOutput();            
        }
        private void textBoxTimeOfSounds_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                timeBeingUsed.GetCalculatedTimeOutput();
            }
        }
        private void textBoxNumberOfChars_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                timeBeingUsed.GetCalculatedTimeOutput();
            }
        }
    }
}

