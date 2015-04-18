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
using SlovniFotbal.Core;
using System.Reflection;

namespace SlovniFotbal
{
    public partial class Base : Form
    {
        private Boot _boot;
        private Search _search;
        private Registry _registry;
        private Automatic _automatic;

        public Base()
        {
            InitializeComponent();

            // Inicializace jednotlivých komponent
            _boot = new Boot(); // FBS - First Boot Sequence
            _boot.DetectLibs(); // Detekce knihoven

            _search = new Search(); // Vyhledávač slov
            _registry = new Registry(); // Práce s registrama
            _automatic = new Automatic(); // Automatické práce
        }

        private void learnMode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Learn learn = new Learn();
            learn.Show();
        }

        private void Testing_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _automatic.Click(labels.Text, listBox2);
        }

        private void tab_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Name == "tabSetting")
            {
                uiNastaveni.RedrawSetting();
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
                _search.SearchWords(_registry.getKey("dictonary"), labels.Text, listBox2);
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
                _automatic.Click(labels.Text, listBox2);
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
