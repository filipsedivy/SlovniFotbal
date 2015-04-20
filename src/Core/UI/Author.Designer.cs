namespace SlovniFotbal.Core.UI
{
    partial class Author
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.licenceLabel = new System.Windows.Forms.Label();
            this.showGitHub = new System.Windows.Forms.LinkLabel();
            this.licence = new System.Windows.Forms.Label();
            this.ownWebsite = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.52113F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.47887F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ownWebsite, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.versionLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.licence, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.licenceLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.showGitHub, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 170);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kontakt";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.versionLabel.Location = new System.Drawing.Point(3, 75);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(75, 25);
            this.versionLabel.TabIndex = 4;
            this.versionLabel.Text = "Verze";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // licenceLabel
            // 
            this.licenceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.licenceLabel.Location = new System.Drawing.Point(3, 50);
            this.licenceLabel.Name = "licenceLabel";
            this.licenceLabel.Size = new System.Drawing.Size(75, 25);
            this.licenceLabel.TabIndex = 6;
            this.licenceLabel.Text = "Licence";
            this.licenceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // showGitHub
            // 
            this.showGitHub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showGitHub.Location = new System.Drawing.Point(84, 50);
            this.showGitHub.Name = "showGitHub";
            this.showGitHub.Size = new System.Drawing.Size(197, 25);
            this.showGitHub.TabIndex = 7;
            this.showGitHub.TabStop = true;
            this.showGitHub.Text = "OpenSource GNU - GitHub";
            this.showGitHub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showGitHub.Click += new System.EventHandler(this.OpenBrowser);
            // 
            // licence
            // 
            this.licence.AutoSize = true;
            this.licence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.licence.Location = new System.Drawing.Point(84, 75);
            this.licence.Name = "licence";
            this.licence.Size = new System.Drawing.Size(197, 25);
            this.licence.TabIndex = 5;
            this.licence.Text = "label5";
            this.licence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ownWebsite
            // 
            this.ownWebsite.AutoSize = true;
            this.ownWebsite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ownWebsite.Location = new System.Drawing.Point(84, 25);
            this.ownWebsite.Name = "ownWebsite";
            this.ownWebsite.Size = new System.Drawing.Size(197, 25);
            this.ownWebsite.TabIndex = 3;
            this.ownWebsite.TabStop = true;
            this.ownWebsite.Text = "http://filipsedivy.cz";
            this.ownWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ownWebsite.Click += new System.EventHandler(this.OpenBrowser);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(84, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filip Šedivý";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Author";
            this.Size = new System.Drawing.Size(284, 170);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label licenceLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel ownWebsite;
        private System.Windows.Forms.Label licence;
        private System.Windows.Forms.LinkLabel showGitHub;
    }
}
