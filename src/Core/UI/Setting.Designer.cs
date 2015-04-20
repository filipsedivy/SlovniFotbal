namespace SlovniFotbal.Core.UI
{
    partial class Setting
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
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.saveSetting = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mouseFile = new SlovniFotbal.Core.UI.SelectFile();
            this.dictonaryFile = new SlovniFotbal.Core.UI.SelectFile();
            this.prodlevaLayout = new System.Windows.Forms.TableLayoutPanel();
            this.timeUnit = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.mainLayout.SuspendLayout();
            this.prodlevaLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 3;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.91525F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.08475F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.mainLayout.Controls.Add(this.label1, 0, 0);
            this.mainLayout.Controls.Add(this.saveSetting, 0, 4);
            this.mainLayout.Controls.Add(this.message, 1, 4);
            this.mainLayout.Controls.Add(this.label2, 0, 1);
            this.mainLayout.Controls.Add(this.label4, 0, 2);
            this.mainLayout.Controls.Add(this.button1, 1, 3);
            this.mainLayout.Controls.Add(this.mouseFile, 1, 2);
            this.mainLayout.Controls.Add(this.dictonaryFile, 1, 1);
            this.mainLayout.Controls.Add(this.prodlevaLayout, 1, 0);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 5;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.mainLayout.Size = new System.Drawing.Size(366, 163);
            this.mainLayout.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prodleva mezi kliknutím";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // saveSetting
            // 
            this.saveSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveSetting.Location = new System.Drawing.Point(3, 114);
            this.saveSetting.Name = "saveSetting";
            this.saveSetting.Size = new System.Drawing.Size(154, 23);
            this.saveSetting.TabIndex = 1;
            this.saveSetting.Text = "Uložit nastavení";
            this.saveSetting.UseVisualStyleBackColor = true;
            this.saveSetting.Click += new System.EventHandler(this.saveSetting_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.message.Location = new System.Drawing.Point(163, 111);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(126, 52);
            this.message.TabIndex = 2;
            this.message.Text = "Zpráva";
            this.message.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.message.Visible = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Slovník";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pozice myši";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(163, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 21);
            this.button1.TabIndex = 10;
            this.button1.Text = "Naučit pozice myši";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mouseFile
            // 
            this.mouseFile.CestaSouboru = "";
            this.mouseFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mouseFile.Location = new System.Drawing.Point(163, 60);
            this.mouseFile.Name = "mouseFile";
            this.mouseFile.Size = new System.Drawing.Size(126, 21);
            this.mouseFile.TabIndex = 11;
            // 
            // dictonaryFile
            // 
            this.dictonaryFile.CestaSouboru = "";
            this.dictonaryFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dictonaryFile.Location = new System.Drawing.Point(163, 33);
            this.dictonaryFile.Name = "dictonaryFile";
            this.dictonaryFile.Size = new System.Drawing.Size(126, 21);
            this.dictonaryFile.TabIndex = 12;
            // 
            // prodlevaLayout
            // 
            this.prodlevaLayout.ColumnCount = 2;
            this.prodlevaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.prodlevaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.prodlevaLayout.Controls.Add(this.timeUnit, 1, 0);
            this.prodlevaLayout.Controls.Add(this.numericUpDown1, 0, 0);
            this.prodlevaLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prodlevaLayout.Location = new System.Drawing.Point(163, 3);
            this.prodlevaLayout.Name = "prodlevaLayout";
            this.prodlevaLayout.RowCount = 1;
            this.prodlevaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.prodlevaLayout.Size = new System.Drawing.Size(126, 24);
            this.prodlevaLayout.TabIndex = 13;
            // 
            // timeUnit
            // 
            this.timeUnit.AutoSize = true;
            this.timeUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeUnit.Location = new System.Drawing.Point(54, 0);
            this.timeUnit.Name = "timeUnit";
            this.timeUnit.Size = new System.Drawing.Size(69, 24);
            this.timeUnit.TabIndex = 5;
            this.timeUnit.Text = "ms";
            this.timeUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown1.Location = new System.Drawing.Point(3, 3);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainLayout);
            this.Name = "Setting";
            this.Size = new System.Drawing.Size(366, 163);
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            this.prodlevaLayout.ResumeLayout(false);
            this.prodlevaLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveSetting;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label timeUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private SelectFile mouseFile;
        private SelectFile dictonaryFile;
        private System.Windows.Forms.TableLayoutPanel prodlevaLayout;
    }
}
