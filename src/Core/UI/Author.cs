using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SlovniFotbal.Core.UI
{
    public partial class Author : UserControl
    {
        public Author()
        {
            InitializeComponent();

            label5.Text = Application.ProductVersion;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://filipsedivy.cz");
        }

        private void showGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/filipsedivy/SlovniFotbal");
        }
    }
}
