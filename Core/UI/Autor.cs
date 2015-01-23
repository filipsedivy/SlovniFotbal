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

namespace Slovní_fotbal.Core.UI
{
    public partial class Autor : UserControl
    {
        Licence licence = new Licence();

        public Autor()
        {
            InitializeComponent();

            label5.Text = Application.ProductVersion;

            if (licence.isFull())
            {
                label7.Text = "Plná verze";
            }
            else
            {
                label7.Text = "Omezená verze";
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://filipsedivy.cz");
        }
    }
}
