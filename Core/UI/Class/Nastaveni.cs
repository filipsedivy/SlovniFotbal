using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlovniFotbal.Core.UI.Class
{
    class Nastaveni
    {

        public Label message
        {
            get { return _message; }
            set { _message = value; }
        }

        public NumericUpDown reload
        {
            get { return _reload; }
            set { _reload = value; }
        }

        public VyberSoubor slovnik
        {
            get { return _slovnik; }
            set { _slovnik = value; }
        }

        public VyberSoubor pozice
        {
            get { return _pozice; }
            set { _pozice = value; }
        }

        private Label _message;
        private NumericUpDown _reload;
        private VyberSoubor _slovnik;
        private VyberSoubor _pozice;
        private Licence licence = new Licence();

        public void InitClass()
        {
            _reload.Value = licence.getInt("reloadTime", 120, 20, 5000);
            _slovnik.CestaSouboru = licence.getKey("dictonary");
            _pozice.CestaSouboru = licence.getKey("position");
        }

        public void settingSave()
        {
            licence.setKey("reloadTime", _reload.Value.ToString());
            licence.setKey("dictonary", _slovnik.CestaSouboru);
            licence.setKey("position", _pozice.CestaSouboru);
            settingMessage("Nastavení bylo uloženo");
        }

        public void settingMessage(string text)
        {
            if (_message.Visible == false)
            {
                _message.Visible = true;
            }
            _message.Text = text;
        }

    }
}
