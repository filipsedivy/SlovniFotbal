namespace Slovní_fotbal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.run = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.letters = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Testing = new System.Windows.Forms.LinkLabel();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabProgram = new System.Windows.Forms.TabPage();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.spustit = new System.Windows.Forms.Button();
            this.tabSetting = new System.Windows.Forms.TabPage();
            this.tabLicence = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.licenceKey = new System.Windows.Forms.MaskedTextBox();
            this.validateLicence = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.actionProgress = new System.Windows.Forms.ProgressBar();
            this.actionHelper = new System.Windows.Forms.Label();
            this.uiNastaveni = new Slovní_fotbal.Core.UI.Nastaveni();
            this.autor = new Slovní_fotbal.Core.UI.Autor();
            this.tab.SuspendLayout();
            this.tabProgram.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabSetting.SuspendLayout();
            this.tabLicence.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(8, 58);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(230, 27);
            this.run.TabIndex = 0;
            this.run.Text = "Spustit";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Písmena";
            // 
            // letters
            // 
            this.letters.Location = new System.Drawing.Point(62, 34);
            this.letters.Name = "letters";
            this.letters.Size = new System.Drawing.Size(178, 20);
            this.letters.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(246, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(173, 56);
            this.listBox1.TabIndex = 6;
            // 
            // Testing
            // 
            this.Testing.AutoSize = true;
            this.Testing.Location = new System.Drawing.Point(244, 65);
            this.Testing.Name = "Testing";
            this.Testing.Size = new System.Drawing.Size(47, 13);
            this.Testing.TabIndex = 12;
            this.Testing.TabStop = true;
            this.Testing.Text = "Zapnout";
            this.Testing.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Testing_LinkClicked);
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabProgram);
            this.tab.Controls.Add(this.tabSetting);
            this.tab.Controls.Add(this.tabLicence);
            this.tab.Controls.Add(this.tabAbout);
            this.tab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tab.Location = new System.Drawing.Point(0, 114);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(487, 226);
            this.tab.TabIndex = 13;
            this.tab.Selected += new System.Windows.Forms.TabControlEventHandler(this.tab_Selected);
            // 
            // tabProgram
            // 
            this.tabProgram.Controls.Add(this.actionHelper);
            this.tabProgram.Controls.Add(this.actionProgress);
            this.tabProgram.Controls.Add(this.listBox2);
            this.tabProgram.Controls.Add(this.tableLayoutPanel1);
            this.tabProgram.Controls.Add(this.spustit);
            this.tabProgram.Location = new System.Drawing.Point(4, 22);
            this.tabProgram.Name = "tabProgram";
            this.tabProgram.Padding = new System.Windows.Forms.Padding(3);
            this.tabProgram.Size = new System.Drawing.Size(479, 200);
            this.tabProgram.TabIndex = 2;
            this.tabProgram.Text = "Program";
            this.tabProgram.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(329, 3);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(147, 194);
            this.listBox2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.13043F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.86957F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.95238F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.71429F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.52381F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(317, 84);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Písmena";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox1.Location = new System.Drawing.Point(95, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 1;
            // 
            // spustit
            // 
            this.spustit.Location = new System.Drawing.Point(6, 169);
            this.spustit.Name = "spustit";
            this.spustit.Size = new System.Drawing.Size(150, 23);
            this.spustit.TabIndex = 0;
            this.spustit.Text = "Spustit";
            this.spustit.UseVisualStyleBackColor = true;
            this.spustit.Click += new System.EventHandler(this.spustit_Click);
            // 
            // tabSetting
            // 
            this.tabSetting.Controls.Add(this.uiNastaveni);
            this.tabSetting.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabSetting.Location = new System.Drawing.Point(4, 22);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabSetting.Size = new System.Drawing.Size(479, 200);
            this.tabSetting.TabIndex = 1;
            this.tabSetting.Text = "Nastavení";
            this.tabSetting.UseVisualStyleBackColor = true;
            // 
            // tabLicence
            // 
            this.tabLicence.BackColor = System.Drawing.Color.White;
            this.tabLicence.Controls.Add(this.groupBox1);
            this.tabLicence.Controls.Add(this.label5);
            this.tabLicence.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabLicence.Location = new System.Drawing.Point(4, 22);
            this.tabLicence.Name = "tabLicence";
            this.tabLicence.Padding = new System.Windows.Forms.Padding(3);
            this.tabLicence.Size = new System.Drawing.Size(479, 200);
            this.tabLicence.TabIndex = 4;
            this.tabLicence.Text = "Licence";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.licenceKey);
            this.groupBox1.Controls.Add(this.validateLicence);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(146, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 115);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aktivace licence";
            // 
            // licenceKey
            // 
            this.licenceKey.Location = new System.Drawing.Point(6, 44);
            this.licenceKey.Mask = ">LLLLL-LLLLL-LLLLL-LLLLL";
            this.licenceKey.Name = "licenceKey";
            this.licenceKey.Size = new System.Drawing.Size(196, 20);
            this.licenceKey.TabIndex = 2;
            this.licenceKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // validateLicence
            // 
            this.validateLicence.Location = new System.Drawing.Point(6, 70);
            this.validateLicence.Name = "validateLicence";
            this.validateLicence.Size = new System.Drawing.Size(196, 23);
            this.validateLicence.TabIndex = 3;
            this.validateLicence.Text = "Aktivovat plnou verzi";
            this.validateLicence.UseVisualStyleBackColor = true;
            this.validateLicence.Click += new System.EventHandler(this.validateLicence_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Licenční klíč: ";
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(473, 71);
            this.label5.TabIndex = 0;
            this.label5.Text = resources.GetString("label5.Text");
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.autor);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(479, 200);
            this.tabAbout.TabIndex = 3;
            this.tabAbout.Text = "Informace";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // actionProgress
            // 
            this.actionProgress.Location = new System.Drawing.Point(162, 169);
            this.actionProgress.Name = "actionProgress";
            this.actionProgress.Size = new System.Drawing.Size(161, 23);
            this.actionProgress.Step = 5;
            this.actionProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.actionProgress.TabIndex = 4;
            this.actionProgress.Visible = false;
            // 
            // actionHelper
            // 
            this.actionHelper.BackColor = System.Drawing.SystemColors.Info;
            this.actionHelper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.actionHelper.Location = new System.Drawing.Point(6, 143);
            this.actionHelper.Name = "actionHelper";
            this.actionHelper.Size = new System.Drawing.Size(317, 23);
            this.actionHelper.TabIndex = 5;
            this.actionHelper.Text = "Popis akce";
            this.actionHelper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.actionHelper.Visible = false;
            // 
            // uiNastaveni
            // 
            this.uiNastaveni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiNastaveni.Location = new System.Drawing.Point(3, 3);
            this.uiNastaveni.Name = "uiNastaveni";
            this.uiNastaveni.Size = new System.Drawing.Size(473, 194);
            this.uiNastaveni.TabIndex = 0;
            // 
            // autor
            // 
            this.autor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autor.Location = new System.Drawing.Point(3, 3);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(473, 194);
            this.autor.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 340);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.Testing);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.letters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.run);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Slovní fotbal";
            this.tab.ResumeLayout(false);
            this.tabProgram.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabSetting.ResumeLayout(false);
            this.tabLicence.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox letters;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.LinkLabel Testing;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabProgram;
        private System.Windows.Forms.TabPage tabSetting;
        private Core.UI.Nastaveni uiNastaveni;
        private System.Windows.Forms.TabPage tabAbout;
        private Core.UI.Autor autor;
        private System.Windows.Forms.Button spustit;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabLicence;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox licenceKey;
        private System.Windows.Forms.Button validateLicence;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar actionProgress;
        private System.Windows.Forms.Label actionHelper;
    }
}

