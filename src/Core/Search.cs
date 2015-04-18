using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlovniFotbal.Core.Exceptions;

namespace SlovniFotbal.Core
{
    class Search
    {
        /// <summary>
        /// Vyhledání slov s následným zápisem do ListBoxu
        /// </summary>
        /// <param name="file">Souobr se slovy</param>
        /// <param name="letters">Písmena</param>
        /// <param name="dump">ListBox</param>
        public void SearchWords(string file, string letters, ListBox dump)
        {
            if (!File.Exists(file))
            {
                throw new DictonaryNotFoundException("Slovník nebyl nalezen");
            }

            if (letters.Length <= 3)
            {
                throw new TextShortException("Alespoň 3 písmena");
            }

            dump.Items.Clear();
            List<string> dictonary = new List<string>(File.ReadAllLines(file));
            var _result = from string word in dictonary
                          where IsValidAnswer(word, letters)
                          orderby word.Length descending
                          select word;

            foreach (var result in _result)
            {
                dump.Items.Add(_result);
            }
        }

        /// <summary>
        /// Vrácení zda-li je možné z písmen složit slovo
        /// </summary>
        /// <param name="word">Slovo</param>
        /// <param name="letters">Písena</param>
        /// <returns>bool</returns>
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
