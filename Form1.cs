using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Slovní_fotbal.Core;
using System.Reflection;
using SKGL;

namespace Slovní_fotbal
{
    public partial class Form1 : Form
    {
        // == Aplikční jádro! ==
        private Boot boot = new Boot(); // Bootovací jádro ( FirstBootSequence -> FBS )
        private Vyhledavac vyhledavac = new Vyhledavac();
        private Pamet pamet = new Pamet();
        private Sifrovani sifrovano = new Sifrovani();
        private Licence licence = new Licence();
        private Mys mys = new Mys();

        public Form1()
        {
            InitializeComponent();

            boot.DetectLibs();
            if (licence.isValid(licence.getKey("licence")))
            {
                tab.TabPages.Remove(tabLicence);
            }
        }

        private void run_Click(object sender, EventArgs e)
        {
            vyhledavac.VyhledatSlova(licence.getKey("dictonary"), letters.Text, listBox1);
        }

        private void learnMode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Learn learn = new Learn();
            learn.Show();
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

        private int GetLetterPosition(string letter)
        {
            string _letter = letter.ToLower();
            char[] _letters = letters.Text.ToLower().ToCharArray();
            int dress = 0;
            foreach (char _let in _letters)
            {
                if (_let.ToString() == _letter)
                {
                    return dress + 1;
                }
                dress++;
            }
            return 0;
        }

        private void Testing_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!licence.isFull())
            {
                MessageBox.Show("Licence není platná");
                Environment.Exit(0);
            }

            foreach (var Item in listBox1.Items)
            {
                char[] slovo = Item.ToString().ToCharArray();

                foreach (char _pismeno in slovo)
                {
                    int getLetter = GetLetterPosition(_pismeno.ToString());
                    string[] _Pozice = GetPosition(false, getLetter).Split(";".ToCharArray());
                    int X = int.Parse(_Pozice[0]);
                    int Y = int.Parse(_Pozice[1]);
                    mys.Klikni(Mys.Tlacitko.Leve, X, Y);
                    System.Threading.Thread.Sleep(200);
                }
                string[] _PoziceBu = GetPosition(true, 0).Split(";".ToCharArray());
                //LeftMouseClick(int.Parse(_PoziceBu[0]), int.Parse(_PoziceBu[1]));
                mys.Klikni(Mys.Tlacitko.Leve, int.Parse(_PoziceBu[0]), int.Parse(_PoziceBu[1]));
                System.Threading.Thread.Sleep(100);
            }
        }

        private void tab_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Name == "tabSetting")
            {
                uiNastaveni.RedrawNastaveni();
            }
        }

        private void spustit_Click(object sender, EventArgs e)
        {
            if (!File.Exists(licence.getKey("dictonary")))
            {
                MessageBox.Show("Nemáte zvolen slovník!", "Chyba aplikace");
                tab.SelectedTab = tabSetting;
                return;
            }
        }

        private void validateLicence_Click(object sender, EventArgs e)
        {
            if (licence.isValid(licenceKey.Text))
            {
                tab.SelectedTab = tabProgram;
                tab.TabPages.Remove(tabLicence);
                licence.setKey("licence", licenceKey.Text);
                MessageBox.Show("Licence byla aktivována\n\nProgram bude restartován!");
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                this.Close();
            }
            else
            {
                MessageBox.Show("Licenční klíč je neplatný");
            }
        }
    }
}
