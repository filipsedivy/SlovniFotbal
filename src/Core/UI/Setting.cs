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
    public partial class Setting : UserControl
    {
        public Label uiMessage;
        private Class.Setting _setting;

        /// <summary>
        /// Základní inicializace
        /// </summary>
        public Setting()
        {
            InitializeComponent();

            _setting = new Class.Setting();
            RedrawSetting();
        }

        /// <summary>
        /// Vykreslení nastavení
        /// </summary>
        public void RedrawSetting()
        {
            message.Visible = false;

            // == Setting constants ==
            _setting.message = message;
            _setting.reload = numericUpDown1;
            _setting.dictonary = dictonaryFile;
            _setting.position = mouseFile;
            mouseFile.DialogoveOkno.Filter = "Data (*.data)|*.data";
            dictonaryFile.DialogoveOkno.Filter = "Textový soubor (*.txt)|*.txt";

            // == UI Init Class ==
            _setting.Init();
            mouseFile.InitClass();
            dictonaryFile.InitClass();
        }

        private void saveSetting_Click(object sender, EventArgs e)
        {
            _setting.saveSetting();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Learn learn = new Learn();
            learn.Show();
        }
    }
}
