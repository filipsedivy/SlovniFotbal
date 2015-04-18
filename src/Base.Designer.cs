namespace SlovniFotbal
{
    partial class Base
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base));
            this.tab = new System.Windows.Forms.TabControl();
            this.tabProgram = new System.Windows.Forms.TabPage();
            this.countWords = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.labels = new System.Windows.Forms.MaskedTextBox();
            this.spustit = new System.Windows.Forms.Button();
            this.tabSetting = new System.Windows.Forms.TabPage();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.actionHelper = new System.Windows.Forms.ToolStripStatusLabel();
            this.actionProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.uiNastaveni = new SlovniFotbal.Core.UI.Setting();
            this.autor = new SlovniFotbal.Core.UI.Author();
            this.tab.SuspendLayout();
            this.tabProgram.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabSetting.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabProgram);
            this.tab.Controls.Add(this.tabSetting);
            this.tab.Controls.Add(this.tabAbout);
            this.tab.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(487, 232);
            this.tab.TabIndex = 13;
            this.tab.Selected += new System.Windows.Forms.TabControlEventHandler(this.tab_Selected);
            // 
            // tabProgram
            // 
            this.tabProgram.Controls.Add(this.countWords);
            this.tabProgram.Controls.Add(this.listBox2);
            this.tabProgram.Controls.Add(this.tableLayoutPanel1);
            this.tabProgram.Controls.Add(this.spustit);
            this.tabProgram.Location = new System.Drawing.Point(4, 22);
            this.tabProgram.Name = "tabProgram";
            this.tabProgram.Padding = new System.Windows.Forms.Padding(3);
            this.tabProgram.Size = new System.Drawing.Size(479, 206);
            this.tabProgram.TabIndex = 2;
            this.tabProgram.Text = "Program";
            this.tabProgram.UseVisualStyleBackColor = true;
            // 
            // countWords
            // 
            this.countWords.Location = new System.Drawing.Point(326, 140);
            this.countWords.Name = "countWords";
            this.countWords.Size = new System.Drawing.Size(147, 20);
            this.countWords.TabIndex = 3;
            this.countWords.Text = "Nalezených slov: 0";
            this.countWords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(329, 3);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(147, 134);
            this.listBox2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.13043F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.86957F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labels, 1, 0);
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
            // labels
            // 
            this.labels.Location = new System.Drawing.Point(95, 3);
            this.labels.Mask = ">AAAAAAAAA";
            this.labels.Name = "labels";
            this.labels.Size = new System.Drawing.Size(103, 20);
            this.labels.TabIndex = 1;
            // 
            // spustit
            // 
            this.spustit.Location = new System.Drawing.Point(6, 114);
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
            this.tabSetting.Size = new System.Drawing.Size(479, 206);
            this.tabSetting.TabIndex = 1;
            this.tabSetting.Text = "Nastavení";
            this.tabSetting.UseVisualStyleBackColor = true;
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.autor);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(479, 206);
            this.tabAbout.TabIndex = 3;
            this.tabAbout.Text = "Informace";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionHelper,
            this.actionProgress});
            this.statusBar.Location = new System.Drawing.Point(0, 235);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(487, 22);
            this.statusBar.SizingGrip = false;
            this.statusBar.TabIndex = 14;
            this.statusBar.Text = "status";
            // 
            // actionHelper
            // 
            this.actionHelper.Name = "actionHelper";
            this.actionHelper.Size = new System.Drawing.Size(205, 17);
            this.actionHelper.Text = "Zadejte písmena, a klikněte na Spustit";
            // 
            // actionProgress
            // 
            this.actionProgress.Name = "actionProgress";
            this.actionProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // uiNastaveni
            // 
            this.uiNastaveni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiNastaveni.Location = new System.Drawing.Point(3, 3);
            this.uiNastaveni.Name = "uiNastaveni";
            this.uiNastaveni.Size = new System.Drawing.Size(473, 200);
            this.uiNastaveni.TabIndex = 0;
            // 
            // autor
            // 
            this.autor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autor.Location = new System.Drawing.Point(3, 3);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(473, 200);
            this.autor.TabIndex = 0;
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 257);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Base";
            this.Text = "Slovní fotbal";
            this.tab.ResumeLayout(false);
            this.tabProgram.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabSetting.ResumeLayout(false);
            this.tabAbout.ResumeLayout(false);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabProgram;
        private System.Windows.Forms.TabPage tabSetting;
        private Core.UI.Setting uiNastaveni;
        private System.Windows.Forms.TabPage tabAbout;
        private Core.UI.Author autor;
        private System.Windows.Forms.Button spustit;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel actionHelper;
        private System.Windows.Forms.ToolStripProgressBar actionProgress;
        private System.Windows.Forms.Label countWords;
        private System.Windows.Forms.MaskedTextBox labels;
    }
}

