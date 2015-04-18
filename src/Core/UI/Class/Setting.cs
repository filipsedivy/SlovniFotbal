using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlovniFotbal.Core.UI.Class
{
    class Setting
    {
        public Label message;
        public NumericUpDown reload;
        public SelectFile dictonary;
        public SelectFile position;

        private Registry _registry;

        public Setting()
        {
            _registry = new Registry();
        }

        /// <summary>
        /// Inicializace hodnot
        /// </summary>
        public void Init()
        {
            reload.Value = _registry.getInt("reloadTime", 120, 20, 5000);
            dictonary.CestaSouboru = _registry.getKey("dictonary");
            position.CestaSouboru = _registry.getKey("position");
        }

        /// <summary>
        /// Uložení nastavení
        /// </summary>
        public void saveSetting()
        {
            _registry.setKey("reloadTime", reload.Value.ToString());
            _registry.setKey("dictonary", dictonary.CestaSouboru);
            _registry.setKey("position", position.CestaSouboru);
            settingMessage("Nastavení bylo uloženo");
        }

        /// <summary>
        /// Nastavení hlášky
        /// </summary>
        /// <param name="text">Text hlášky</param>
        public void settingMessage(string text)
        {
            if (message.Visible == false)
                message.Visible = true;
            message.Text = text;
        }
    }
}
