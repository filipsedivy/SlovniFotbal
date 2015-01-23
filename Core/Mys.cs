using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slovní_fotbal.Core
{
    class Mys
    {
        public enum Tlacitko
        {
            Leve,
            Prave
        };

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll", EntryPoint = "SetCursorPos")]
        [return: System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)]
        public static extern bool SetCursorPos(int X, int Y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        public void Klikni(Tlacitko btn, int x, int y)
        {
            NastavitKursor(x, y);
            Kliknuti(btn, x, y);
        }

        private void NastavitKursor(int x, int y)
        {
            SetCursorPos(x, y);
        }

        private void Kliknuti(Tlacitko tlacitko, int x, int y)
        {
            if (tlacitko == Tlacitko.Leve)
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);
            }
        }
    }
}
