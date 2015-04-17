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

namespace Slovní_fotbal
{
    public partial class Base : Form
    {
        // == Aplikční jádro! ==
        private Boot boot = new Boot(); // Bootovací jádro ( FirstBootSequence -> FBS )
        private Vyhledavac vyhledavac = new Vyhledavac();
        private Pamet pamet = new Pamet();
        private Licence licence = new Licence();
        private Sifrovani sifrovano = new Sifrovani();
        private Automaticky automaticky = new Automaticky();
        private Mys mys = new Mys();

        public Base()
        {
            InitializeComponent();

            boot.DetectLibs();
        }

        private void learnMode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Learn learn = new Learn();
            learn.Show();
        }

        private void Testing_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            automaticky.klikat(labels.Text, listBox2);
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
            actionHelper.Visible = true;
            actionHelper.BackColor = System.Drawing.SystemColors.Info;
            actionProgress.Visible = true;
            actionProgress.Style = ProgressBarStyle.Marquee;
            actionProgress.Value = 0;
            spustit.Enabled = false;

            actionHelper.Text = "Probíhá vyhledávání slov";
            try
            {
                vyhledavac.VyhledatSlova(licence.getKey("dictonary"), labels.Text, listBox2);
            }
            catch (SlovniFotbalException sE)
            {
                actionHelper.Text = sE.Message;
                actionHelper.BackColor = System.Drawing.Color.LightCoral;
                actionProgress.Style = ProgressBarStyle.Blocks;
                actionProgress.Value = 100;
            }

            actionHelper.Text = "Probíhá zadávání slov";
            try
            {
                automaticky.klikat(labels.Text, listBox2);
            }
            catch (SlovniFotbalException)
            {

            }
            finally
            {
                spustit.Enabled = true;
            }
        }
    }
}
