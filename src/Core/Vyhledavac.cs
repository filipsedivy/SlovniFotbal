using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlovniFotbal.Core
{
    class Vyhledavac
    {

        private string Pismena;

        public void VyhledatSlova(string Soubor, string Pismena, ListBox Vypis)
        {
            this.Pismena = Pismena;

            if (!File.Exists(Soubor))
            {
                throw new SlovniFotbalException("Slovník nebyl nalezen");
            }

            if (Pismena.Length <= 3)
            {
                throw new SlovniFotbalException("Počet písmen musí být více než 3");
            }

            Vypis.Items.Clear();
            List<string> slovnik = new List<string>(File.ReadAllLines(Soubor));
            var vysledek = from string word in slovnik
                           where IsValidAnswer(word, this.Pismena)
                           orderby word.Length descending
                           select word;

            foreach (var result in vysledek)
            {
                Vypis.Items.Add(result);
            }


        }

        private static bool IsValidAnswer(string word, string letters)
        {
            foreach (var letter in word)
            {
                if (letters.IndexOf(letter) == -1)
                {
                    return false;
                }

                letters = letters.Remove(letters.IndexOf(letter), 1);
            }

            return true;
        }

    }
}
