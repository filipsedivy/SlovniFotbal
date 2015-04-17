using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SlovniFotbal.Core
{
    class Pamet
    {
        public bool ZapnutyFlash()
        {
            int pocetProcesu_Flash = 0;
            Process[] processList = Process.GetProcesses();
            foreach (Process theProcess in processList)
            {
                if (Regex.IsMatch(theProcess.ProcessName, @"FlashPlayerPlugin"))
                {
                    pocetProcesu_Flash++;
                }
            }

            if (pocetProcesu_Flash == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
