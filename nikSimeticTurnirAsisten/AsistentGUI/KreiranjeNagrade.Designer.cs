namespace AsistentGUI
{
    partial class KreiranjeNagrade
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
            this.btnUnesiNagradu = new System.Windows.Forms.Button();
            this.lblOsvojenoMjesto = new System.Windows.Forms.Label();
            this.lblNazivNagrade = new System.Windows.Forms.Label();
            this.lblIznos = new System.Windows.Forms.Label();
            this.lblIli = new System.Windows.Forms.Label();
            this.lblPostotak = new System.Windows.Forms.Label();
            this.txtOsvojenoMjesto = new System.Windows.Forms.TextBox();
            this.txtNazivNagrade = new System.Windows.Forms.TextBox();
            this.txtIznosNagrade = new System.Windows.Forms.TextBox();
            this.txtPostotakNagrade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUnesiNagradu
            // 
            this.btnUnesiNagradu.Location = new System.Drawing.Point(134, 307);
            this.btnUnesiNagradu.Name = "btnUnesiNagradu";
            this.btnUnesiNagradu.Size = new System.Drawing.Size(75, 23);
            this.btnUnesiNagradu.TabIndex = 0;
            this.btnUnesiNagradu.Text = "Unesi";
            this.btnUnesiNagradu.UseVisualStyleBackColor = true;
            this.btnUnesiNagradu.Click += new System.EventHandler(this.btnUnesiNagradu_Click);
            // 
            // lblOsvojenoMjesto
            // 
            this.lblOsvojenoMjesto.AutoSize = true;
            this.lblOsvojenoMjesto.Location = new System.Drawing.Point(51, 66);
            this.lblOsvojenoMjesto.Name = "lblOsvojenoMjesto";
            this.lblOsvojenoMjesto.Size = new System.Drawing.Size(88, 13);
            this.lblOsvojenoMjesto.TabIndex = 1;
            this.lblOsvojenoMjesto.Text = "Osvojeno mjesto:";
            // 
            // lblNazivNagrade
            // 
            this.lblNazivNagrade.AutoSize = true;
            this.lblNazivNagrade.Location = new System.Drawing.Point(51, 107);
            this.lblNazivNagrade.Name = "lblNazivNagrade";
            this.lblNazivNagrade.Size = new System.Drawing.Size(79, 13);
            this.lblNazivNagrade.TabIndex = 2;
            this.lblNazivNagrade.Text = "Naziv nagrade:";
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(51, 146);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(77, 13);
            this.lblIznos.TabIndex = 3;
            this.lblIznos.Text = "Iznos nagrade:";
            // 
            // lblIli
            // 
            this.lblIli.AutoSize = true;
            this.lblIli.Location = new System.Drawing.Point(131, 198);
            this.lblIli.Name = "lblIli";
            this.lblIli.Size = new System.Drawing.Size(14, 13);
            this.lblIli.TabIndex = 4;
            this.lblIli.Text = "Ili";
            // 
            // lblPostotak
            // 
            this.lblPostotak.AutoSize = true;
            this.lblPostotak.Location = new System.Drawing.Point(51, 244);
            this.lblPostotak.Name = "lblPostotak";
            this.lblPostotak.Size = new System.Drawing.Size(94, 13);
            this.lblPostotak.TabIndex = 5;
            this.lblPostotak.Text = "Postotak nagrade:";
            // 
            // txtOsvojenoMjesto
            // 
            this.txtOsvojenoMjesto.Location = new System.Drawing.Point(164, 66);
            this.txtOsvojenoMjesto.Name = "txtOsvojenoMjesto";
            this.txtOsvojenoMjesto.Size = new System.Drawing.Size(100, 20);
            this.txtOsvojenoMjesto.TabIndex = 6;
            // 
            // txtNazivNagrade
            // 
            this.txtNazivNagrade.Location = new System.Drawing.Point(164, 107);
            this.txtNazivNagrade.Name = "txtNazivNagrade";
            this.txtNazivNagrade.Size = new System.Drawing.Size(100, 20);
            this.txtNazivNagrade.TabIndex = 7;
            // 
            // txtIznosNagrade
            // 
            this.txtIznosNagrade.Location = new System.Drawing.Point(164, 146);
            this.txtIznosNagrade.Name = "txtIznosNagrade";
            this.txtIznosNagrade.Size = new System.Drawing.Size(100, 20);
            this.txtIznosNagrade.TabIndex = 8;
            this.txtIznosNagrade.Text = "0";
            // 
            // txtPostotakNagrade
            // 
            this.txtPostotakNagrade.Location = new System.Drawing.Point(164, 241);
            this.txtPostotakNagrade.Name = "txtPostotakNagrade";
            this.txtPostotakNagrade.Size = new System.Drawing.Size(100, 20);
            this.txtPostotakNagrade.TabIndex = 9;
            this.txtPostotakNagrade.Text = "0";
            // 
            // KreiranjeNagrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 406);
            this.Controls.Add(this.txtPostotakNagrade);
            this.Controls.Add(this.txtIznosNagrade);
            this.Controls.Add(this.txtNazivNagrade);
            this.Controls.Add(this.txtOsvojenoMjesto);
            this.Controls.Add(this.lblPostotak);
            this.Controls.Add(this.lblIli);
            this.Controls.Add(this.lblIznos);
            this.Controls.Add(this.lblNazivNagrade);
            this.Controls.Add(this.lblOsvojenoMjesto);
            this.Controls.Add(this.btnUnesiNagradu);
            this.Name = "KreiranjeNagrade";
            this.Text = "KreiranjeNagrade";
            this.Load += new System.EventHandler(this.KreiranjeNagrade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnesiNagradu;
        private System.Windows.Forms.Label lblOsvojenoMjesto;
        private System.Windows.Forms.Label lblNazivNagrade;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.Label lblIli;
        private System.Windows.Forms.Label lblPostotak;
        private System.Windows.Forms.TextBox txtOsvojenoMjesto;
        private System.Windows.Forms.TextBox txtNazivNagrade;
        private System.Windows.Forms.TextBox txtIznosNagrade;
        private System.Windows.Forms.TextBox txtPostotakNagrade;
    }
}