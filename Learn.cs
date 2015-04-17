using MouseKeyboardActivityMonitor;
using MouseKeyboardActivityMonitor.WinApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlovniFotbal
{
    public partial class Learn : Form
    {

        List<TempSave> Position = new List<TempSave>();

        readonly private string HelperDefault = "Nápověda: ";
        readonly private string[] HelperSteps = { 
            "Zapněte výukový režim",
            "Klikněte na {0} znak",
            "Klikněte na tlačítko Odeslat",
            "Výukový program můžete zavřít"
        };
        private MouseHookListener _mouseListener;
        private int maxDress = 13, actualDress = 1;
        private bool setSendButton = false;
        private string LogFile = "";
        public Learn()
        {
            InitializeComponent();
            _mouseListener = new MouseHookListener(new GlobalHooker());
            _mouseListener.Enabled = true;
            _mouseListener.MouseMove += _ListenerMouseMove;
            _mouseListener.MouseClick += _ListenerMouseClick;
            label1.Text = string.Format("Pozice myši: x={0:0000}; y={1:0000}", 0, 0);
            helper.Text = HelperDefault + HelperSteps[0];
        }

        private void _AddPosition(string position)
        {
            TempSave _tSave = new TempSave();
            _tSave.position = position;

            Position.Add(_tSave);
        }

        private void _ListenerMouseClick(object sender, MouseEventArgs e)
        {
            if (button1.Enabled == true)
            {
                return;
            }

            if (actualDress == 1)
            {
                // Save
                actualDress++;
            }

            if (actualDress != maxDress)
            {
                helper.Text = string.Format(HelperDefault + HelperSteps[1], actualDress);
                _AddPosition(String.Format("{0:0000};{1:0000}", e.X, e.Y));
                actualDress++;
                if (actualDress == maxDress)
                {
                    helper.Text = HelperDefault + HelperSteps[2];
                }
                return;
            }

            if (setSendButton == false)
            {
                helper.Text = HelperDefault + HelperSteps[3];
                _AddPosition(String.Format("{0:0000};{1:0000}", e.X, e.Y));
                setSendButton = true;

                SaveFileDialog data = new SaveFileDialog();
                data.Title = "Uložt konfigurační soubor";
                data.Filter = "Data (*.data)|*.data";

                if (data.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    File.WriteAllText(data.FileName, "");
                    foreach (TempSave _tSave in Position)
                    {
                        File.AppendAllText(data.FileName, _tSave.position + Environment.NewLine);
                    }
                    MessageBox.Show("Data byla uložena");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Data nebyly uloženy, spusťte výukový program znova");
                    this.Close();
                }
            }
        }

        private void _ListenerMouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = string.Format("Pozice myši: x={0:0000}; y={1:0000}", e.X, e.Y);
        }

        private void Learn_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\SlovniFotbal_Vyuka.data", "");
            LogFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\SlovniFotbal_Vyuka.data";
            helper.Text = string.Format(HelperDefault + HelperSteps[1], actualDress);
        }
    }

    public class TempSave
    {
        public string position;
    }
}
