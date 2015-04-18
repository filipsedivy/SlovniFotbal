using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlovniFotbal.Core
{
    /// <summary>
    /// Třída pro práci s myší
    /// </summary>
    class Mouse
    {
        /// <summary>
        /// Tlačítko, jakým má myš kliknout
        /// </summary>
        public enum Type
        {
            Left,
            Right,
            Middle
        }

        /// <summary>
        /// Nastavení pozice kurzoru
        /// </summary>
        /// <param name="X">Poloha myši - X</param>
        /// <param name="Y">Poloha myši - Y</param>
        /// <returns>Zda-li byla nastavena poloha</returns>
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll", EntryPoint = "SetCursorPos")]
        [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)]
        public static extern bool SetCursorPos(int X, int Y);

        /// <summary>
        /// Vytvoření akce myši
        /// </summary>
        /// <param name="dwFlags">Typ kliknutí</param>
        /// <param name="dx">Poloha myši - X</param>
        /// <param name="dy">Poloha myši - Y</param>
        /// <param name="cButtons">Programovací tlačítka</param>
        /// <param name="dwExtraInfo">Doplňující informace</param>
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        /// <summary>
        /// Kliknutí myši v určité poloze
        /// </summary>
        /// <param name="button">Typ kliknutí</param>
        /// <param name="x">Poloha myši - X</param>
        /// <param name="y">Poloha myši - Y</param>
        public void Click(Type button, int x, int y)
        {
            SetCursorPos(x, y);

            switch (button)
            {
                case Type.Left:
                    mouse_event(0x02, x, y, 0, 0);
                    mouse_event(0x04, x, y, 0, 0);
                    break;

                case Type.Right:
                    mouse_event(0x08, x, y, 0, 0);
                    mouse_event(0x10, x, y, 0, 0);
                    break;

                case Type.Middle:
                    mouse_event(0x20, x, y, 0, 0);
                    mouse_event(0x40, x, y, 0, 0);
                    break;
            }
        }
    }
}
