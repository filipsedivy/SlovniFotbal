using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SlovniFotbal.Core.UI
{
    public partial class SelectFile : UserControl
    {
        public String NazevSouboru
        {
            get { return Path.GetFileName(cesta); }
        }

        public String CestaSouboru
        {
            get { return cesta; }
            set { cesta = value; }
        }

        public Button VyberSouboru
        {
            get { return selectFile; }
            set { selectFile = value; }
        }


        public OpenFileDialog DialogoveOkno
        {
            get { return dialog; }
            set { dialog = value; }
        }

        private string cesta = "";
        private OpenFileDialog dialog = new OpenFileDialog();

        public SelectFile()
        {
            InitializeComponent();
        }

        public void InitClass()
        {
            fileName.Text = Path.GetFileName(cesta);
        }

        private void selectFile_Click(object sender, EventArgs e)
        {
            dialog.Title = "Vyberte soubor";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                cesta = dialog.FileName;
                fileName.Text = Path.GetFileName(dialog.FileName);
            }
        }
    }
}
