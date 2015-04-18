using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlovniFotbal.Core.UI;

namespace SlovniFotbal.Core.UI
{
    public partial class Nastaveni : UserControl
    {
        public Label uiMessage
        {
            get { return message; }
            set { message = value; }
        }

        Class.Nastaveni nastaveni = new Class.Nastaveni();

        public Nastaveni()
        {
            InitializeComponent();

            RedrawNastaveni();
        }

        public void RedrawNastaveni()
        {
            message.Visible = false;

            // == Setting constants ==
            nastaveni.message = message;
            nastaveni.reload = numericUpDown1;
            nastaveni.slovnik = slovnik;
            nastaveni.pozice = poziceMysi;
            poziceMysi.DialogoveOkno.Filter = "Data (*.data)|*.data";
            slovnik.DialogoveOkno.Filter = "Textový soubor (*.txt)|*.txt";

            // == UI Init Class ==
            nastaveni.InitClass();
            slovnik.InitClass();
            poziceMysi.InitClass();
        }

        private void saveSetting_Click(object sender, EventArgs e)
        {
            nastaveni.settingSave();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Learn vyuka = new Learn();
            vyuka.Show();
        }
    }
}
