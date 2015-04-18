using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlovniFotbal.Core;
using System.IO;

namespace SlovniFotbal.Core
{
    class Automaticky
    {
        Licence licence = new Licence();
        Mouse _mouse;

        public Automaticky()
        {
            _mouse = new Mouse();
        }

        public void klikat(string pismena, ListBox slova)
        {
            if (!File.Exists(licence.getKey("dictonary")))
            {
                MessageBox.Show("Soubor slovníku nebyl nalezen", "Soubor nenalezen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(licence.getKey("position")))
            {
                MessageBox.Show("Soubor pozicí nebyl nalezen", "Soubor nenalezen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            char[] _pismena = pismena.ToArray();

            foreach (var Item in slova.Items)
            {
                char[] slovo = Item.ToString().ToArray();

                foreach (char pismeno in slovo)
                {
                    int getLetter = PozicePismena(pismeno.ToString());
                    string[] _pozice = GetPosition(false, getLetter).Split(";".ToCharArray());
                    _mouse.Click(Mouse.Type.Left, int.Parse(_pozice[0]), int.Parse(_pozice[1]));
                    System.Threading.Thread.Sleep(licence.getInt("reloadTime", 120, 50, 5000));
                }
                string[] _PoziceBu = GetPosition(true, 0).Split(";".ToCharArray());
                _mouse.Click(Mouse.Type.Left, int.Parse(_PoziceBu[0]), int.Parse(_PoziceBu[1]));
                System.Threading.Thread.Sleep(licence.getInt("reloadTime", 120, 50, 5000));
            }

        }

        private string GetPosition(bool button, int dress = 0)
        {
            string[] Lines = File.ReadAllLines(licence.getKey("position"));
            if (button == true)
            {
                return Lines[11];
            }
            else
            {
                return Lines[dress - 1];
            }
        }

        private int PozicePismena(string pismena)
        {
            char[] _opis = pismena.ToLower().ToArray();
            int dress = 0;
            foreach (char _letter in _opis)
            {
                if (_letter.ToString() == pismena.ToLower())
                {
                    return dress + 1;
                }
                dress++;
            }
            return 0;
        }

    }
}
