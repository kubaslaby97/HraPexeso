
namespace HraPexeso
{
    partial class frmHlavni
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
            this.lblRadky = new System.Windows.Forms.Label();
            this.numRadky = new System.Windows.Forms.NumericUpDown();
            this.numSloupce = new System.Windows.Forms.NumericUpDown();
            this.lblSloupce = new System.Windows.Forms.Label();
            this.btnSpustit = new System.Windows.Forms.Button();
            this.grpVelikostPole = new System.Windows.Forms.GroupBox();
            this.grpVlastnostiOkna = new System.Windows.Forms.GroupBox();
            this.rbPohybliva = new System.Windows.Forms.RadioButton();
            this.rbPevna = new System.Windows.Forms.RadioButton();
            this.lblChovaniOkna = new System.Windows.Forms.Label();
            this.lblTlacitka = new System.Windows.Forms.Label();
            this.txtTitulek = new System.Windows.Forms.TextBox();
            this.lblTitulek = new System.Windows.Forms.Label();
            this.chkMinimalizace = new System.Windows.Forms.CheckBox();
            this.chkMaximalizace = new System.Windows.Forms.CheckBox();
            this.lblCasZakryti = new System.Windows.Forms.Label();
            this.lblVelikostKarty = new System.Windows.Forms.Label();
            this.numCasZakryti = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numVelikostKarty = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numRadky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSloupce)).BeginInit();
            this.grpVelikostPole.SuspendLayout();
            this.grpVlastnostiOkna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCasZakryti)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVelikostKarty)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRadky
            // 
            this.lblRadky.AutoSize = true;
            this.lblRadky.Location = new System.Drawing.Point(16, 25);
            this.lblRadky.Name = "lblRadky";
            this.lblRadky.Size = new System.Drawing.Size(69, 13);
            this.lblRadky.TabIndex = 0;
            this.lblRadky.Text = "Počet řádků:";
            // 
            // numRadky
            // 
            this.numRadky.Location = new System.Drawing.Point(19, 41);
            this.numRadky.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numRadky.Name = "numRadky";
            this.numRadky.Size = new System.Drawing.Size(143, 20);
            this.numRadky.TabIndex = 1;
            this.numRadky.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numSloupce
            // 
            this.numSloupce.Location = new System.Drawing.Point(19, 92);
            this.numSloupce.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numSloupce.Name = "numSloupce";
            this.numSloupce.Size = new System.Drawing.Size(143, 20);
            this.numSloupce.TabIndex = 3;
            this.numSloupce.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // lblSloupce
            // 
            this.lblSloupce.AutoSize = true;
            this.lblSloupce.Location = new System.Drawing.Point(16, 76);
            this.lblSloupce.Name = "lblSloupce";
            this.lblSloupce.Size = new System.Drawing.Size(78, 13);
            this.lblSloupce.TabIndex = 2;
            this.lblSloupce.Text = "Počet sloupců:";
            // 
            // btnSpustit
            // 
            this.btnSpustit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpustit.Location = new System.Drawing.Point(323, 247);
            this.btnSpustit.Name = "btnSpustit";
            this.btnSpustit.Size = new System.Drawing.Size(78, 29);
            this.btnSpustit.TabIndex = 4;
            this.btnSpustit.Text = "Spustit hru";
            this.btnSpustit.UseVisualStyleBackColor = true;
            this.btnSpustit.Click += new System.EventHandler(this.btnSpustit_Click);
            // 
            // grpVelikostPole
            // 
            this.grpVelikostPole.Controls.Add(this.lblRadky);
            this.grpVelikostPole.Controls.Add(this.numRadky);
            this.grpVelikostPole.Controls.Add(this.numSloupce);
            this.grpVelikostPole.Controls.Add(this.lblSloupce);
            this.grpVelikostPole.Location = new System.Drawing.Point(12, 12);
            this.grpVelikostPole.Name = "grpVelikostPole";
            this.grpVelikostPole.Size = new System.Drawing.Size(175, 129);
            this.grpVelikostPole.TabIndex = 5;
            this.grpVelikostPole.TabStop = false;
            this.grpVelikostPole.Text = "Velikost herního pole";
            // 
            // grpVlastnostiOkna
            // 
            this.grpVlastnostiOkna.Controls.Add(this.rbPohybliva);
            this.grpVlastnostiOkna.Controls.Add(this.rbPevna);
            this.grpVlastnostiOkna.Controls.Add(this.lblChovaniOkna);
            this.grpVlastnostiOkna.Controls.Add(this.lblTlacitka);
            this.grpVlastnostiOkna.Controls.Add(this.txtTitulek);
            this.grpVlastnostiOkna.Controls.Add(this.lblTitulek);
            this.grpVlastnostiOkna.Controls.Add(this.chkMinimalizace);
            this.grpVlastnostiOkna.Controls.Add(this.chkMaximalizace);
            this.grpVlastnostiOkna.Location = new System.Drawing.Point(193, 13);
            this.grpVlastnostiOkna.Name = "grpVlastnostiOkna";
            this.grpVlastnostiOkna.Size = new System.Drawing.Size(208, 223);
            this.grpVlastnostiOkna.TabIndex = 6;
            this.grpVlastnostiOkna.TabStop = false;
            this.grpVlastnostiOkna.Text = "Vlastnosti herního okna";
            // 
            // rbPohybliva
            // 
            this.rbPohybliva.AutoSize = true;
            this.rbPohybliva.Checked = true;
            this.rbPohybliva.Location = new System.Drawing.Point(18, 185);
            this.rbPohybliva.Name = "rbPohybliva";
            this.rbPohybliva.Size = new System.Drawing.Size(110, 17);
            this.rbPohybliva.TabIndex = 7;
            this.rbPohybliva.TabStop = true;
            this.rbPohybliva.Text = "Pohyblivá velikost";
            this.rbPohybliva.UseVisualStyleBackColor = true;
            // 
            // rbPevna
            // 
            this.rbPevna.AutoSize = true;
            this.rbPevna.Location = new System.Drawing.Point(18, 162);
            this.rbPevna.Name = "rbPevna";
            this.rbPevna.Size = new System.Drawing.Size(95, 17);
            this.rbPevna.TabIndex = 6;
            this.rbPevna.Text = "Pevná velikost";
            this.rbPevna.UseVisualStyleBackColor = true;
            // 
            // lblChovaniOkna
            // 
            this.lblChovaniOkna.AutoSize = true;
            this.lblChovaniOkna.Location = new System.Drawing.Point(15, 146);
            this.lblChovaniOkna.Name = "lblChovaniOkna";
            this.lblChovaniOkna.Size = new System.Drawing.Size(78, 13);
            this.lblChovaniOkna.TabIndex = 5;
            this.lblChovaniOkna.Text = "Chování okna:";
            // 
            // lblTlacitka
            // 
            this.lblTlacitka.AutoSize = true;
            this.lblTlacitka.Location = new System.Drawing.Point(15, 76);
            this.lblTlacitka.Name = "lblTlacitka";
            this.lblTlacitka.Size = new System.Drawing.Size(77, 13);
            this.lblTlacitka.TabIndex = 4;
            this.lblTlacitka.Text = "Tlačítka okna:";
            // 
            // txtTitulek
            // 
            this.txtTitulek.Location = new System.Drawing.Point(18, 41);
            this.txtTitulek.Name = "txtTitulek";
            this.txtTitulek.Size = new System.Drawing.Size(173, 20);
            this.txtTitulek.TabIndex = 3;
            this.txtTitulek.Text = "Pexeso";
            // 
            // lblTitulek
            // 
            this.lblTitulek.AutoSize = true;
            this.lblTitulek.Location = new System.Drawing.Point(15, 25);
            this.lblTitulek.Name = "lblTitulek";
            this.lblTitulek.Size = new System.Drawing.Size(69, 13);
            this.lblTitulek.TabIndex = 2;
            this.lblTitulek.Text = "Titulek okna:";
            // 
            // chkMinimalizace
            // 
            this.chkMinimalizace.AutoSize = true;
            this.chkMinimalizace.Checked = true;
            this.chkMinimalizace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMinimalizace.Location = new System.Drawing.Point(18, 115);
            this.chkMinimalizace.Name = "chkMinimalizace";
            this.chkMinimalizace.Size = new System.Drawing.Size(89, 17);
            this.chkMinimalizace.TabIndex = 1;
            this.chkMinimalizace.Text = "Minimalizovat";
            this.chkMinimalizace.UseVisualStyleBackColor = true;
            // 
            // chkMaximalizace
            // 
            this.chkMaximalizace.AutoSize = true;
            this.chkMaximalizace.Checked = true;
            this.chkMaximalizace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMaximalizace.Location = new System.Drawing.Point(18, 92);
            this.chkMaximalizace.Name = "chkMaximalizace";
            this.chkMaximalizace.Size = new System.Drawing.Size(92, 17);
            this.chkMaximalizace.TabIndex = 0;
            this.chkMaximalizace.Text = "Maximalizovat";
            this.chkMaximalizace.UseVisualStyleBackColor = true;
            // 
            // lblCasZakryti
            // 
            this.lblCasZakryti.AutoSize = true;
            this.lblCasZakryti.Location = new System.Drawing.Point(16, 26);
            this.lblCasZakryti.Name = "lblCasZakryti";
            this.lblCasZakryti.Size = new System.Drawing.Size(135, 13);
            this.lblCasZakryti.TabIndex = 7;
            this.lblCasZakryti.Text = "Čas na zakrytí karty (v ms):";
            // 
            // lblVelikostKarty
            // 
            this.lblVelikostKarty.AutoSize = true;
            this.lblVelikostKarty.Location = new System.Drawing.Point(16, 76);
            this.lblVelikostKarty.Name = "lblVelikostKarty";
            this.lblVelikostKarty.Size = new System.Drawing.Size(130, 13);
            this.lblVelikostKarty.TabIndex = 8;
            this.lblVelikostKarty.Text = "Velikost karty (v pixelech):";
            // 
            // numCasZakryti
            // 
            this.numCasZakryti.Location = new System.Drawing.Point(19, 42);
            this.numCasZakryti.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numCasZakryti.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCasZakryti.Name = "numCasZakryti";
            this.numCasZakryti.Size = new System.Drawing.Size(143, 20);
            this.numCasZakryti.TabIndex = 4;
            this.numCasZakryti.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numVelikostKarty);
            this.groupBox1.Controls.Add(this.numCasZakryti);
            this.groupBox1.Controls.Add(this.lblCasZakryti);
            this.groupBox1.Controls.Add(this.lblVelikostKarty);
            this.groupBox1.Location = new System.Drawing.Point(12, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 129);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nastavení herní karty";
            // 
            // numVelikostKarty
            // 
            this.numVelikostKarty.Location = new System.Drawing.Point(19, 92);
            this.numVelikostKarty.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numVelikostKarty.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numVelikostKarty.Name = "numVelikostKarty";
            this.numVelikostKarty.Size = new System.Drawing.Size(143, 20);
            this.numVelikostKarty.TabIndex = 9;
            this.numVelikostKarty.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // frmHlavni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 288);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpVlastnostiOkna);
            this.Controls.Add(this.grpVelikostPole);
            this.Controls.Add(this.btnSpustit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHlavni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nastavení hry Pexeso";
            ((System.ComponentModel.ISupportInitialize)(this.numRadky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSloupce)).EndInit();
            this.grpVelikostPole.ResumeLayout(false);
            this.grpVelikostPole.PerformLayout();
            this.grpVlastnostiOkna.ResumeLayout(false);
            this.grpVlastnostiOkna.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCasZakryti)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVelikostKarty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRadky;
        private System.Windows.Forms.NumericUpDown numRadky;
        private System.Windows.Forms.NumericUpDown numSloupce;
        private System.Windows.Forms.Label lblSloupce;
        private System.Windows.Forms.Button btnSpustit;
        private System.Windows.Forms.GroupBox grpVelikostPole;
        private System.Windows.Forms.GroupBox grpVlastnostiOkna;
        private System.Windows.Forms.Label lblTitulek;
        private System.Windows.Forms.CheckBox chkMinimalizace;
        private System.Windows.Forms.CheckBox chkMaximalizace;
        private System.Windows.Forms.RadioButton rbPohybliva;
        private System.Windows.Forms.RadioButton rbPevna;
        private System.Windows.Forms.Label lblChovaniOkna;
        private System.Windows.Forms.Label lblTlacitka;
        private System.Windows.Forms.TextBox txtTitulek;
        private System.Windows.Forms.Label lblCasZakryti;
        private System.Windows.Forms.Label lblVelikostKarty;
        private System.Windows.Forms.NumericUpDown numCasZakryti;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numVelikostKarty;
    }
}

