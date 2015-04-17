using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Slovní_fotbal.Core
{
    class Licence
    {
        protected const string RegistryPath = "HKEY_CURRENT_USER\\Software\\SlovniFotbal";

        public void setKey(string name, string value)
        {
            RegistryKey myKey = Registry.CurrentUser.CreateSubKey("Software\\SlovniFotbal", RegistryKeyPermissionCheck.ReadWriteSubTree);
            myKey.SetValue(name, value, RegistryValueKind.String);
            myKey.Close();
        }

        public string getKey(string key)
        {
            if (keyExists(key))
            {
                using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\SlovniFotbal", true))
                {
                    return (string)registryKey.GetValue(key);
                }
            }
            else
            {
                return "";
            }
        }

        public bool keyExists(string key)
        {
            if (Registry.GetValue(RegistryPath, key, null) == null)
            {
                return false;
            }
            return true;
        }

        public int getInt(string name, int _default, int min = 0, int max = 0)
        {
            string key = "";
            if (!keyExists(name))
            {
                return _default;
            }

            key = getKey(name);
            int number;
            int final = _default;
            bool result = Int32.TryParse(key, out number);

            if (min != 0)
            {
                if (number < min)
                {
                    return _default;
                }
                else
                {
                    final = number;
                }
            }

            if (max != 0)
            {
                if (number > max)
                {
                    return _default;
                }
                else
                {
                    final = number;
                }
            }

            return final;

        }
    }
}
