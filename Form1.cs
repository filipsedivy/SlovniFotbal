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
        private Automaticky automaticky = new Automaticky();
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

        private void learnMode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Learn learn = new Learn();
            learn.Show();
        }

        private void Testing_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!licence.isFull())
            {
                MessageBox.Show("Licence není platná");
                Environment.Exit(0);
            }

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
            catch (SlovniFotbalException sE)
            {

            }
            finally
            {
                spustit.Enabled = true;
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
