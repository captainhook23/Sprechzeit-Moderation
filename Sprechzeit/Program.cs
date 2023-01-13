using Sprechzeit.Config;
using Sprechzeit.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprechzeit
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalculateTimeBeingUsedForm());
            //Application.Run(new FactorAlgorythmForm());
            //Application.Run(new CalculateCharsNeededForm());

        }
    }
}
