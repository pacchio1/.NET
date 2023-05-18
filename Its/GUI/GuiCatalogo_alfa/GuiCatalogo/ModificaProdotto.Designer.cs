namespace GuiCatalogo
{
    partial class ModificaProdotto
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
            this.pnlRicerca = new System.Windows.Forms.Panel();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodiceRicerca = new System.Windows.Forms.TextBox();
            this.btnCerca = new System.Windows.Forms.Button();
            this.pnlModifica = new System.Windows.Forms.Panel();
            this.btnCancella = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.lblGiacenza = new System.Windows.Forms.Label();
            this.txtPrez = new System.Windows.Forms.TextBox();
            this.lblPrezzo = new System.Windows.Forms.Label();
            this.txtDenom = new System.Windows.Forms.TextBox();
            this.lblDenominazione = new System.Windows.Forms.Label();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.lblCodice = new System.Windows.Forms.Label();
            this.pnlRicerca.SuspendLayout();
            this.pnlModifica.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRicerca
            // 
            this.pnlRicerca.Controls.Add(this.btnCerca);
            this.pnlRicerca.Controls.Add(this.txtCodiceRicerca);
            this.pnlRicerca.Controls.Add(this.label1);
            this.pnlRicerca.Location = new System.Drawing.Point(24, 22);
            this.pnlRicerca.Name = "pnlRicerca";
            this.pnlRicerca.Size = new System.Drawing.Size(299, 54);
            this.pnlRicerca.TabIndex = 0;
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Location = new System.Drawing.Point(116, 6);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(90, 13);
            this.lblTitolo.TabIndex = 1;
            this.lblTitolo.Text = "Modifica Prodotto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "inserisci codice";
            // 
            // txtCodiceRicerca
            // 
            this.txtCodiceRicerca.Location = new System.Drawing.Point(104, 21);
            this.txtCodiceRicerca.Name = "txtCodiceRicerca";
            this.txtCodiceRicerca.Size = new System.Drawing.Size(100, 20);
            this.txtCodiceRicerca.TabIndex = 1;
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(210, 19);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(75, 23);
            this.btnCerca.TabIndex = 2;
            this.btnCerca.Text = "cerca";
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // pnlModifica
            // 
            this.pnlModifica.Controls.Add(this.btnCancella);
            this.pnlModifica.Controls.Add(this.btnSalva);
            this.pnlModifica.Controls.Add(this.txtGia);
            this.pnlModifica.Controls.Add(this.lblGiacenza);
            this.pnlModifica.Controls.Add(this.txtPrez);
            this.pnlModifica.Controls.Add(this.lblPrezzo);
            this.pnlModifica.Controls.Add(this.txtDenom);
            this.pnlModifica.Controls.Add(this.lblDenominazione);
            this.pnlModifica.Controls.Add(this.txtCodice);
            this.pnlModifica.Controls.Add(this.lblCodice);
            this.pnlModifica.Location = new System.Drawing.Point(24, 93);
            this.pnlModifica.Name = "pnlModifica";
            this.pnlModifica.Size = new System.Drawing.Size(246, 234);
            this.pnlModifica.TabIndex = 2;
            // 
            // btnCancella
            // 
            this.btnCancella.Location = new System.Drawing.Point(135, 195);
            this.btnCancella.Name = "btnCancella";
            this.btnCancella.Size = new System.Drawing.Size(75, 23);
            this.btnCancella.TabIndex = 24;
            this.btnCancella.Text = "cancella";
            this.btnCancella.UseVisualStyleBackColor = true;
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(26, 195);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(75, 23);
            this.btnSalva.TabIndex = 23;
            this.btnSalva.Text = " salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(110, 149);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(100, 20);
            this.txtGia.TabIndex = 22;
            // 
            // lblGiacenza
            // 
            this.lblGiacenza.AutoSize = true;
            this.lblGiacenza.Location = new System.Drawing.Point(29, 152);
            this.lblGiacenza.Name = "lblGiacenza";
            this.lblGiacenza.Size = new System.Drawing.Size(50, 13);
            this.lblGiacenza.TabIndex = 21;
            this.lblGiacenza.Text = "giacenza";
            // 
            // txtPrez
            // 
            this.txtPrez.Location = new System.Drawing.Point(110, 110);
            this.txtPrez.Name = "txtPrez";
            this.txtPrez.Size = new System.Drawing.Size(100, 20);
            this.txtPrez.TabIndex = 20;
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.Location = new System.Drawing.Point(29, 113);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(33, 13);
            this.lblPrezzo.TabIndex = 19;
            this.lblPrezzo.Text = "prezo";
            // 
            // txtDenom
            // 
            this.txtDenom.Location = new System.Drawing.Point(110, 61);
            this.txtDenom.Name = "txtDenom";
            this.txtDenom.Size = new System.Drawing.Size(100, 20);
            this.txtDenom.TabIndex = 18;
            // 
            // lblDenominazione
            // 
            this.lblDenominazione.AutoSize = true;
            this.lblDenominazione.Location = new System.Drawing.Point(29, 64);
            this.lblDenominazione.Name = "lblDenominazione";
            this.lblDenominazione.Size = new System.Drawing.Size(78, 13);
            this.lblDenominazione.TabIndex = 17;
            this.lblDenominazione.Text = "denominazione";
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(110, 16);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.ReadOnly = true;
            this.txtCodice.Size = new System.Drawing.Size(100, 20);
            this.txtCodice.TabIndex = 16;
            // 
            // lblCodice
            // 
            this.lblCodice.AutoSize = true;
            this.lblCodice.Location = new System.Drawing.Point(29, 16);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(39, 13);
            this.lblCodice.TabIndex = 15;
            this.lblCodice.Text = "codice";
            // 
            // ModificaProdotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 392);
            this.Controls.Add(this.pnlModifica);
            this.Controls.Add(this.lblTitolo);
            this.Controls.Add(this.pnlRicerca);
            this.Name = "ModificaProdotto";
            this.Text = "Modifica Prodotto";
            this.pnlRicerca.ResumeLayout(false);
            this.pnlRicerca.PerformLayout();
            this.pnlModifica.ResumeLayout(false);
            this.pnlModifica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRicerca;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.TextBox txtCodiceRicerca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.Panel pnlModifica;
        private System.Windows.Forms.Button btnCancella;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lblGiacenza;
        private System.Windows.Forms.TextBox txtPrez;
        private System.Windows.Forms.Label lblPrezzo;
        private System.Windows.Forms.TextBox txtDenom;
        private System.Windows.Forms.Label lblDenominazione;
        private System.Windows.Forms.TextBox txtCodice;
        private System.Windows.Forms.Label lblCodice;
    }
}