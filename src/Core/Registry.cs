using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinRegistry = Microsoft.Win32;

namespace SlovniFotbal.Core
{
    class Registry
    {
        /// <summary>
        /// Cesta k registrům
        /// </summary>
        private struct Paths
        {
            public static string full = "HKEY_CURRENT_USER\\Software\\SlovniFotbal";
            public static string sub = "Software\\SlovniFotbal";
        }

        /// <summary>
        /// Nastavení klíče
        /// </summary>
        /// <param name="name">Jméno</param>
        /// <param name="value">Hodnota</param>
        public void setKey(string name, string value)
        {
            RegistryKey key = WinRegistry.Registry.CurrentUser.CreateSubKey(Paths.sub, RegistryKeyPermissionCheck.ReadWriteSubTree);
            key.SetValue(name, value, RegistryValueKind.String);
            key.Close();
        }

        /// <summary>
        /// Ověření existence klíče
        /// </summary>
        /// <param name="name">Jméno</param>
        /// <returns>bool</returns>
        public bool existsKey(string name)
        {
            if (WinRegistry.Registry.GetValue(Paths.full, name, null) == null) return false;
            return true;
        }

        /// <summary>
        /// Vrácení klíče z registrů
        /// </summary>
        /// <param name="name">Jméno</param>
        /// <param name="defaultValue">Výchozí hodnota</param>
        /// <returns>Vrácení hodnoty klíče</returns>
        public string getKey(string name, string defaultValue = null)
        {
            if (!existsKey(name)) return defaultValue;
            using (RegistryKey registryKey = WinRegistry.Registry.CurrentUser.OpenSubKey(Paths.sub, true))
            {
                return (string)registryKey.GetValue(name);
            }
        }

        /// <summary>
        /// Vrácení hodnoty jako čísla
        /// </summary>
        /// <param name="name">Jméno</param>
        /// <param name="defaultValue">Výchozí hodnota</param>
        /// <param name="min">Minimální rozsah</param>
        /// <param name="max">Maximální rozsah</param>
        /// <returns>Vrácení čísla</returns>
        public int getInt(string name, int defaultValue, int min = 0, int max = 0)
        {
            if (!existsKey(name)) return defaultValue;
            string key = getKey(name);
            int number;
            bool result = Int32.TryParse(key, out number);

            if (min != 0)
            {
                if (number < min) return defaultValue;
                else return number;
            }

            if (max != 0)
            {
                if (number > max) return defaultValue;
                else return number;
            }

            return number;
        }
    }
}
