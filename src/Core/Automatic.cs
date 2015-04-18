using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlovniFotbal.Core
{
    class Automatic
    {
        Mouse _mouse;
        Registry _registry;

        /// <summary>
        /// Inicializace knihoven
        /// </summary>
        public Automatic()
        {
            _mouse = new Mouse();
            _registry = new Registry();
        }

        /// <summary>
        /// Automatické klikání na písmena z ListBoxu
        /// </summary>
        /// <param name="letters">Písmena</param>
        /// <param name="words">ListBox</param>
        public void Click(string letters, ListBox words)
        {
            if (!File.Exists(_registry.getKey("dictonary")))
            {
                MessageBox.Show("Soubor slovníku nebyl nalezen", "Soubor nenalezen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(_registry.getKey("position")))
            {
                MessageBox.Show("Soubor pozicí nebyl nalezen", "Soubor nenalezen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            char[] _letters = letters.ToArray();

            foreach (var item in words.Items)
            {
                char[] word = item.ToString().ToArray();

                foreach (char letter in word)
                {
                    int letterPosition = LetterPosition(letter.ToString());
                    string[] _position = GetPosition(false, letterPosition).Split(";".ToCharArray());

                    _mouse.Click(Mouse.Type.Left, int.Parse(_position[0]), int.Parse(_position[1]));
                    System.Threading.Thread.Sleep(_registry.getInt("reloadTime", 120, 50, 5000));
                }

                string[] buttonPosition = GetPosition(true, 0).Split(";".ToCharArray());
                _mouse.Click(Mouse.Type.Left, int.Parse(buttonPosition[0]), int.Parse(buttonPosition[1]));
                System.Threading.Thread.Sleep(_registry.getInt("reloadTime", 120, 50, 5000));
            }
        }

        /// <summary>
        /// Vrátí pozici buď tlačítka nebo drezu
        /// </summary>
        /// <param name="button">Tlačítko</param>
        /// <param name="dress">Číslo drezu</param>
        /// <returns>Pozice z dat</returns>
        private string GetPosition(bool button, int dress = 0)
        {
            string[] Lines = File.ReadAllLines(_registry.getKey("position"));
            if (button == true)
                return Lines[11];
            return Lines[dress - 1];
        }

        /// <summary>
        /// Vrátí pozici písmen
        /// </summary>
        /// <param name="letters">Písmena</param>
        /// <returns>Vrátí počet písmen</returns>
        private int LetterPosition(string letters)
        {
            int dress = 0;
            foreach (char _letter in letters.ToLower().ToArray())
            {
                if (_letter.ToString() == letters.ToLower()) return dress + 1;
                dress++;
            }
            return 0;
        }
    }
}
