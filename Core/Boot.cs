using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slovní_fotbal.Core
{
    class Boot
    {

        private Licence licence = new Licence();
        private string[] Libs = new string[]{ 
            "MouseKeyboardActivityMonitor"      // Kihovna na práci s myší
        };


        public Boot()
        {
            DefaultRegistry();
        }

        public void DetectLibs()
        {
            foreach (string lib in Libs)
            {
                if (!File.Exists(string.Format("{0}\\{1}.dll", Application.StartupPath, lib)))
                {
                    MessageBox.Show(string.Format("Knihovna {0}.dll nebyla nalezena\nAplikace bude ukončena", lib), 
                        "Chyba aplikace",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    Environment.Exit(1);
                    return;
                }
            }
        }

        private void DefaultRegistry()
        {
            if (!licence.keyExists("licence"))
            {
                licence.setKey("licence", "");
            }

            if (!licence.keyExists("reloadTime"))
            {
                licence.setKey("reloadTime", "150");
            }

            if (!licence.keyExists("dictonary"))
            {
                licence.setKey("dictonary", "");
            }

            if (!licence.keyExists("position"))
            {
                licence.setKey("position", "");
            }

        }

    }
}
