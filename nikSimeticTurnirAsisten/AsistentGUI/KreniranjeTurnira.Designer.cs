namespace AsistentGUI
{
    partial class KreniranjeTurnira
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
            this.lblAkontacija = new System.Windows.Forms.Label();
            this.lblNazivTima = new System.Windows.Forms.Label();
            this.lblListaTimova = new System.Windows.Forms.Label();
            this.lblNagrada = new System.Windows.Forms.Label();
            this.lstListaTimova = new System.Windows.Forms.ListBox();
            this.lstNagrada = new System.Windows.Forms.ListBox();
            this.btnNapraviTim = new System.Windows.Forms.Button();
            this.btnDodajNagradu = new System.Windows.Forms.Button();
            this.btnIzbrisiTim = new System.Windows.Forms.Button();
            this.btnUrediTim = new System.Windows.Forms.Button();
            this.btnIzbrisiNagradu = new System.Windows.Forms.Button();
            this.btnUrediNagradu = new System.Windows.Forms.Button();
            this.cmbNazivTima = new System.Windows.Forms.ComboBox();
            this.txtAkotancija = new System.Windows.Forms.TextBox();
            this.cmbOdaberiTim = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAkontacija
            // 
            this.lblAkontacija.AutoSize = true;
            this.lblAkontacija.Location = new System.Drawing.Point(36, 68);
            this.lblAkontacija.Name = "lblAkontacija";
            this.lblAkontacija.Size = new System.Drawing.Size(60, 13);
            this.lblAkontacija.TabIndex = 0;
            this.lblAkontacija.Text = "Akontacija:";
            // 
            // lblNazivTima
            // 
            this.lblNazivTima.AutoSize = true;
            this.lblNazivTima.Location = new System.Drawing.Point(36, 115);
            this.lblNazivTima.Name = "lblNazivTima";
            this.lblNazivTima.Size = new System.Drawing.Size(27, 13);
            this.lblNazivTima.TabIndex = 1;
            this.lblNazivTima.Text = "Tim:";
            // 
            // lblListaTimova
            // 
            this.lblListaTimova.AutoSize = true;
            this.lblListaTimova.Location = new System.Drawing.Point(338, 32);
            this.lblListaTimova.Name = "lblListaTimova";
            this.lblListaTimova.Size = new System.Drawing.Size(70, 13);
            this.lblListaTimova.TabIndex = 2;
            this.lblListaTimova.Text = "Lista Timova:";
            // 
            // lblNagrada
            // 
            this.lblNagrada.AutoSize = true;
            this.lblNagrada.Location = new System.Drawing.Point(338, 233);
            this.lblNagrada.Name = "lblNagrada";
            this.lblNagrada.Size = new System.Drawing.Size(51, 13);
            this.lblNagrada.TabIndex = 3;
            this.lblNagrada.Text = "Nagrada:";
            // 
            // lstListaTimova
            // 
            this.lstListaTimova.FormattingEnabled = true;
            this.lstListaTimova.Location = new System.Drawing.Point(341, 63);
            this.lstListaTimova.Name = "lstListaTimova";
            this.lstListaTimova.Size = new System.Drawing.Size(162, 121);
            this.lstListaTimova.TabIndex = 4;
            // 
            // lstNagrada
            // 
            this.lstNagrada.FormattingEnabled = true;
            this.lstNagrada.Location = new System.Drawing.Point(341, 253);
            this.lstNagrada.Name = "lstNagrada";
            this.lstNagrada.Size = new System.Drawing.Size(162, 121);
            this.lstNagrada.TabIndex = 5;
            // 
            // btnNapraviTim
            // 
            this.btnNapraviTim.Location = new System.Drawing.Point(66, 183);
            this.btnNapraviTim.Name = "btnNapraviTim";
            this.btnNapraviTim.Size = new System.Drawing.Size(134, 45);
            this.btnNapraviTim.TabIndex = 6;
            this.btnNapraviTim.Text = "Napravi tim";
            this.btnNapraviTim.UseVisualStyleBackColor = true;
            this.btnNapraviTim.Click += new System.EventHandler(this.btnNapraviTim_Click);
            // 
            // btnDodajNagradu
            // 
            this.btnDodajNagradu.Location = new System.Drawing.Point(63, 355);
            this.btnDodajNagradu.Name = "btnDodajNagradu";
            this.btnDodajNagradu.Size = new System.Drawing.Size(137, 47);
            this.btnDodajNagradu.TabIndex = 8;
            this.btnDodajNagradu.Text = "Dodaj nagradu";
            this.btnDodajNagradu.UseVisualStyleBackColor = true;
            // 
            // btnIzbrisiTim
            // 
            this.btnIzbrisiTim.Location = new System.Drawing.Point(563, 74);
            this.btnIzbrisiTim.Name = "btnIzbrisiTim";
            this.btnIzbrisiTim.Size = new System.Drawing.Size(110, 43);
            this.btnIzbrisiTim.TabIndex = 9;
            this.btnIzbrisiTim.Text = "Izbriši";
            this.btnIzbrisiTim.UseVisualStyleBackColor = true;
            // 
            // btnUrediTim
            // 
            this.btnUrediTim.Location = new System.Drawing.Point(563, 132);
            this.btnUrediTim.Name = "btnUrediTim";
            this.btnUrediTim.Size = new System.Drawing.Size(110, 35);
            this.btnUrediTim.TabIndex = 10;
            this.btnUrediTim.Text = "Uredi";
            this.btnUrediTim.UseVisualStyleBackColor = true;
            // 
            // btnIzbrisiNagradu
            // 
            this.btnIzbrisiNagradu.Location = new System.Drawing.Point(563, 271);
            this.btnIzbrisiNagradu.Name = "btnIzbrisiNagradu";
            this.btnIzbrisiNagradu.Size = new System.Drawing.Size(110, 38);
            this.btnIzbrisiNagradu.TabIndex = 11;
            this.btnIzbrisiNagradu.Text = "Izbriši";
            this.btnIzbrisiNagradu.UseVisualStyleBackColor = true;
            // 
            // btnUrediNagradu
            // 
            this.btnUrediNagradu.Location = new System.Drawing.Point(563, 319);
            this.btnUrediNagradu.Name = "btnUrediNagradu";
            this.btnUrediNagradu.Size = new System.Drawing.Size(110, 37);
            this.btnUrediNagradu.TabIndex = 12;
            this.btnUrediNagradu.Text = "Uredi";
            this.btnUrediNagradu.UseVisualStyleBackColor = true;
            // 
            // cmbNazivTima
            // 
            this.cmbNazivTima.FormattingEnabled = true;
            this.cmbNazivTima.Location = new System.Drawing.Point(93, 115);
            this.cmbNazivTima.Name = "cmbNazivTima";
            this.cmbNazivTima.Size = new System.Drawing.Size(121, 21);
            this.cmbNazivTima.TabIndex = 14;
            // 
            // txtAkotancija
            // 
            this.txtAkotancija.Location = new System.Drawing.Point(112, 68);
            this.txtAkotancija.Name = "txtAkotancija";
            this.txtAkotancija.Size = new System.Drawing.Size(100, 20);
            this.txtAkotancija.TabIndex = 15;
            // 
            // cmbOdaberiTim
            // 
            this.cmbOdaberiTim.FormattingEnabled = true;
            this.cmbOdaberiTim.Location = new System.Drawing.Point(78, 262);
            this.cmbOdaberiTim.Name = "cmbOdaberiTim";
            this.cmbOdaberiTim.Size = new System.Drawing.Size(134, 21);
            this.cmbOdaberiTim.TabIndex = 16;
            this.cmbOdaberiTim.SelectedIndexChanged += new System.EventHandler(this.cmbOdaberiTim_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Odaberi tim: ";
            // 
            // KreniranjeTurnira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 428);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOdaberiTim);
            this.Controls.Add(this.txtAkotancija);
            this.Controls.Add(this.cmbNazivTima);
            this.Controls.Add(this.btnUrediNagradu);
            this.Controls.Add(this.btnIzbrisiNagradu);
            this.Controls.Add(this.btnUrediTim);
            this.Controls.Add(this.btnIzbrisiTim);
            this.Controls.Add(this.btnDodajNagradu);
            this.Controls.Add(this.btnNapraviTim);
            this.Controls.Add(this.lstNagrada);
            this.Controls.Add(this.lstListaTimova);
            this.Controls.Add(this.lblNagrada);
            this.Controls.Add(this.lblListaTimova);
            this.Controls.Add(this.lblNazivTima);
            this.Controls.Add(this.lblAkontacija);
            this.Name = "KreniranjeTurnira";
            this.Text = "KreniranjeTurnira";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAkontacija;
        private System.Windows.Forms.Label lblNazivTima;
        private System.Windows.Forms.Label lblListaTimova;
        private System.Windows.Forms.Label lblNagrada;
        private System.Windows.Forms.ListBox lstListaTimova;
        private System.Windows.Forms.ListBox lstNagrada;
        private System.Windows.Forms.Button btnNapraviTim;
        private System.Windows.Forms.Button btnDodajNagradu;
        private System.Windows.Forms.Button btnIzbrisiTim;
        private System.Windows.Forms.Button btnUrediTim;
        private System.Windows.Forms.Button btnIzbrisiNagradu;
        private System.Windows.Forms.Button btnUrediNagradu;
        private System.Windows.Forms.ComboBox cmbNazivTima;
        private System.Windows.Forms.TextBox txtAkotancija;
        private System.Windows.Forms.ComboBox cmbOdaberiTim;
        private System.Windows.Forms.Label label1;
    }
}