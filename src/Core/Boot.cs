using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlovniFotbal.Core
{
    class Boot
    {

        private Registry _registry;

        /// <summary>
        /// Externí knihovny
        /// </summary>
        private string[] Libs = new string[]{ 
            "MouseKeyboardActivityMonitor"      // Knihovna na práci s myší
        };

        /// <summary>
        /// Inicializace knihoven
        /// </summary>
        public Boot()
        {
            _registry = new Registry();

            DefaultRegistry();
        }

        /// <summary>
        /// Detekce existence knihoven
        /// </summary>
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

        /// <summary>
        /// Nastavení výchozích hodnot v registrech
        /// </summary>
        private void DefaultRegistry()
        {
            if (!_registry.existsKey("reloadTime"))
            {
                _registry.setKey("reloadTime", "150");
            }

            if (!_registry.existsKey("dictonary"))
            {
                _registry.setKey("dictonary", "");
            }

            if (!_registry.existsKey("position"))
            {
                _registry.setKey("position", "");
            }

        }

    }
}
