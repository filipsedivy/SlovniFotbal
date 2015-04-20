using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace SlovniFotbal.Core.UI
{
    public partial class Author : UserControl
    {
        public Author()
        {
            InitializeComponent();

            licence.Text = Application.ProductVersion;
        }

        private void OpenBrowser(object sender, EventArgs e)
        {
            string url = "";
            switch ((sender as LinkLabel).Name)
            {
                case "showGitHub":
                    url = "https://github.com/filipsedivy/SlovniFotbal";
                    break;

                case "ownWebsite":
                    url = "http://filipsedivy.cz";
                    break;
            }

            Process.Start(url);
        }
    }
}
