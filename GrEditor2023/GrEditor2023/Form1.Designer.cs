namespace GrEditor2023
{
    partial class frmGrEditor
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbPlatno = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsSouradniceMysi = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbColor1 = new System.Windows.Forms.PictureBox();
            this.pbColor2 = new System.Windows.Forms.PictureBox();
            this.pbSelectBlack = new System.Windows.Forms.PictureBox();
            this.pbSelectBlue = new System.Windows.Forms.PictureBox();
            this.pbSelectGreen = new System.Windows.Forms.PictureBox();
            this.pbSelectWhite = new System.Windows.Forms.PictureBox();
            this.gbNastroje = new System.Windows.Forms.GroupBox();
            this.rbEllipse = new System.Windows.Forms.RadioButton();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSouborUlozit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSouborOtevrit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmKonec = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatno)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectWhite)).BeginInit();
            this.gbNastroje.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPlatno
            // 
            this.pbPlatno.BackColor = System.Drawing.Color.White;
            this.pbPlatno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPlatno.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pbPlatno.Location = new System.Drawing.Point(141, 12);
            this.pbPlatno.Name = "pbPlatno";
            this.pbPlatno.Size = new System.Drawing.Size(484, 337);
            this.pbPlatno.TabIndex = 0;
            this.pbPlatno.TabStop = false;
            this.pbPlatno.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPlatno_MouseDown);
            this.pbPlatno.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbPlatno_MouseMove);
            this.pbPlatno.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPlatno_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSouradniceMysi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 378);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(710, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsSouradniceMysi
            // 
            this.tsSouradniceMysi.Name = "tsSouradniceMysi";
            this.tsSouradniceMysi.Size = new System.Drawing.Size(43, 17);
            this.tsSouradniceMysi.Text = "x: 0 y:0";
            // 
            // pbColor1
            // 
            this.pbColor1.BackColor = System.Drawing.Color.Black;
            this.pbColor1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbColor1.Location = new System.Drawing.Point(642, 18);
            this.pbColor1.Name = "pbColor1";
            this.pbColor1.Size = new System.Drawing.Size(38, 33);
            this.pbColor1.TabIndex = 3;
            this.pbColor1.TabStop = false;
            // 
            // pbColor2
            // 
            this.pbColor2.BackColor = System.Drawing.Color.White;
            this.pbColor2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbColor2.Location = new System.Drawing.Point(664, 29);
            this.pbColor2.Name = "pbColor2";
            this.pbColor2.Size = new System.Drawing.Size(38, 33);
            this.pbColor2.TabIndex = 4;
            this.pbColor2.TabStop = false;
            // 
            // pbSelectBlack
            // 
            this.pbSelectBlack.BackColor = System.Drawing.Color.Black;
            this.pbSelectBlack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbSelectBlack.Location = new System.Drawing.Point(655, 68);
            this.pbSelectBlack.Name = "pbSelectBlack";
            this.pbSelectBlack.Size = new System.Drawing.Size(38, 33);
            this.pbSelectBlack.TabIndex = 5;
            this.pbSelectBlack.TabStop = false;
            this.pbSelectBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbSelectBlack_MouseDown);
            // 
            // pbSelectBlue
            // 
            this.pbSelectBlue.BackColor = System.Drawing.Color.Blue;
            this.pbSelectBlue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbSelectBlue.Location = new System.Drawing.Point(655, 107);
            this.pbSelectBlue.Name = "pbSelectBlue";
            this.pbSelectBlue.Size = new System.Drawing.Size(38, 33);
            this.pbSelectBlue.TabIndex = 6;
            this.pbSelectBlue.TabStop = false;
            this.pbSelectBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbSelectBlack_MouseDown);
            // 
            // pbSelectGreen
            // 
            this.pbSelectGreen.BackColor = System.Drawing.Color.Lime;
            this.pbSelectGreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbSelectGreen.Location = new System.Drawing.Point(655, 146);
            this.pbSelectGreen.Name = "pbSelectGreen";
            this.pbSelectGreen.Size = new System.Drawing.Size(38, 33);
            this.pbSelectGreen.TabIndex = 7;
            this.pbSelectGreen.TabStop = false;
            this.pbSelectGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbSelectBlack_MouseDown);
            // 
            // pbSelectWhite
            // 
            this.pbSelectWhite.BackColor = System.Drawing.Color.White;
            this.pbSelectWhite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbSelectWhite.Location = new System.Drawing.Point(655, 185);
            this.pbSelectWhite.Name = "pbSelectWhite";
            this.pbSelectWhite.Size = new System.Drawing.Size(38, 33);
            this.pbSelectWhite.TabIndex = 8;
            this.pbSelectWhite.TabStop = false;
            this.pbSelectWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbSelectBlack_MouseDown);
            // 
            // gbNastroje
            // 
            this.gbNastroje.Controls.Add(this.rbEllipse);
            this.gbNastroje.Controls.Add(this.rbRectangle);
            this.gbNastroje.Controls.Add(this.rbLine);
            this.gbNastroje.Location = new System.Drawing.Point(8, 24);
            this.gbNastroje.Name = "gbNastroje";
            this.gbNastroje.Size = new System.Drawing.Size(101, 116);
            this.gbNastroje.TabIndex = 9;
            this.gbNastroje.TabStop = false;
            this.gbNastroje.Text = "Výběr nástroje";
            // 
            // rbEllipse
            // 
            this.rbEllipse.AutoSize = true;
            this.rbEllipse.Location = new System.Drawing.Point(16, 78);
            this.rbEllipse.Name = "rbEllipse";
            this.rbEllipse.Size = new System.Drawing.Size(53, 17);
            this.rbEllipse.TabIndex = 2;
            this.rbEllipse.Text = "Elipsa";
            this.rbEllipse.UseVisualStyleBackColor = true;
            this.rbEllipse.Click += new System.EventHandler(this.rbLine_Click);
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Location = new System.Drawing.Point(16, 55);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(69, 17);
            this.rbRectangle.TabIndex = 1;
            this.rbRectangle.Text = "Obdelník";
            this.rbRectangle.UseVisualStyleBackColor = true;
            this.rbRectangle.Click += new System.EventHandler(this.rbLine_Click);
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Checked = true;
            this.rbLine.Location = new System.Drawing.Point(16, 32);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(62, 17);
            this.rbLine.TabIndex = 0;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Úsečka";
            this.rbLine.UseVisualStyleBackColor = true;
            this.rbLine.CheckedChanged += new System.EventHandler(this.rbLine_CheckedChanged);
            this.rbLine.Click += new System.EventHandler(this.rbLine_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(710, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSouborUlozit,
            this.tsmSouborOtevrit,
            this.toolStripSeparator1,
            this.tsmKonec});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItem1.Text = "Soubor";
            // 
            // tsmSouborUlozit
            // 
            this.tsmSouborUlozit.Name = "tsmSouborUlozit";
            this.tsmSouborUlozit.Size = new System.Drawing.Size(180, 22);
            this.tsmSouborUlozit.Text = "Uložit";
            this.tsmSouborUlozit.Click += new System.EventHandler(this.tsmSouborUlozit_Click);
            // 
            // tsmSouborOtevrit
            // 
            this.tsmSouborOtevrit.Name = "tsmSouborOtevrit";
            this.tsmSouborOtevrit.Size = new System.Drawing.Size(180, 22);
            this.tsmSouborOtevrit.Text = "Načíst";
            this.tsmSouborOtevrit.Click += new System.EventHandler(this.tsmSouborOtevrit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmKonec
            // 
            this.tsmKonec.Name = "tsmKonec";
            this.tsmKonec.Size = new System.Drawing.Size(180, 22);
            this.tsmKonec.Text = "Konec";
            this.tsmKonec.Click += new System.EventHandler(this.tsmKonec_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmGrEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 400);
            this.Controls.Add(this.gbNastroje);
            this.Controls.Add(this.pbSelectWhite);
            this.Controls.Add(this.pbSelectGreen);
            this.Controls.Add(this.pbSelectBlue);
            this.Controls.Add(this.pbSelectBlack);
            this.Controls.Add(this.pbColor1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pbPlatno);
            this.Controls.Add(this.pbColor2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmGrEditor";
            this.Text = "Grafický editor";
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatno)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectWhite)).EndInit();
            this.gbNastroje.ResumeLayout(false);
            this.gbNastroje.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlatno;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsSouradniceMysi;
        private System.Windows.Forms.PictureBox pbColor1;
        private System.Windows.Forms.PictureBox pbColor2;
        private System.Windows.Forms.PictureBox pbSelectBlack;
        private System.Windows.Forms.PictureBox pbSelectBlue;
        private System.Windows.Forms.PictureBox pbSelectGreen;
        private System.Windows.Forms.PictureBox pbSelectWhite;
        private System.Windows.Forms.GroupBox gbNastroje;
        private System.Windows.Forms.RadioButton rbEllipse;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmSouborUlozit;
        private System.Windows.Forms.ToolStripMenuItem tsmSouborOtevrit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmKonec;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

