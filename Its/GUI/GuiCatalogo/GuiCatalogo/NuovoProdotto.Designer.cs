namespace GuiCatalogo
{
    partial class NuovoProdotto
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
            this.lblTitolo = new System.Windows.Forms.Label();
            this.lblCodice = new System.Windows.Forms.Label();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.txtDenom = new System.Windows.Forms.TextBox();
            this.lblDenominazione = new System.Windows.Forms.Label();
            this.txtPrez = new System.Windows.Forms.TextBox();
            this.lblPrezzo = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.lblGiacenza = new System.Windows.Forms.Label();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnCancella = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Location = new System.Drawing.Point(53, 9);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(79, 13);
            this.lblTitolo.TabIndex = 0;
            this.lblTitolo.Text = "nuovo prodotto";
            // 
            // lblCodice
            // 
            this.lblCodice.AutoSize = true;
            this.lblCodice.Location = new System.Drawing.Point(15, 45);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(39, 13);
            this.lblCodice.TabIndex = 1;
            this.lblCodice.Text = "codice";
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(96, 45);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(100, 20);
            this.txtCodice.TabIndex = 3;
            // 
            // txtDenom
            // 
            this.txtDenom.Location = new System.Drawing.Point(96, 90);
            this.txtDenom.Name = "txtDenom";
            this.txtDenom.Size = new System.Drawing.Size(100, 20);
            this.txtDenom.TabIndex = 5;
            // 
            // lblDenominazione
            // 
            this.lblDenominazione.AutoSize = true;
            this.lblDenominazione.Location = new System.Drawing.Point(15, 93);
            this.lblDenominazione.Name = "lblDenominazione";
            this.lblDenominazione.Size = new System.Drawing.Size(78, 13);
            this.lblDenominazione.TabIndex = 4;
            this.lblDenominazione.Text = "denominazione";
            // 
            // txtPrez
            // 
            this.txtPrez.Location = new System.Drawing.Point(96, 139);
            this.txtPrez.Name = "txtPrez";
            this.txtPrez.Size = new System.Drawing.Size(100, 20);
            this.txtPrez.TabIndex = 7;
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.Location = new System.Drawing.Point(15, 142);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(33, 13);
            this.lblPrezzo.TabIndex = 6;
            this.lblPrezzo.Text = "prezo";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(96, 178);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(100, 20);
            this.txtGia.TabIndex = 9;
            // 
            // lblGiacenza
            // 
            this.lblGiacenza.AutoSize = true;
            this.lblGiacenza.Location = new System.Drawing.Point(15, 181);
            this.lblGiacenza.Name = "lblGiacenza";
            this.lblGiacenza.Size = new System.Drawing.Size(50, 13);
            this.lblGiacenza.TabIndex = 8;
            this.lblGiacenza.Text = "giacenza";
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(12, 224);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(75, 23);
            this.btnSalva.TabIndex = 12;
            this.btnSalva.Text = " salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnCancella
            // 
            this.btnCancella.Location = new System.Drawing.Point(121, 224);
            this.btnCancella.Name = "btnCancella";
            this.btnCancella.Size = new System.Drawing.Size(75, 23);
            this.btnCancella.TabIndex = 13;
            this.btnCancella.Text = "cancella";
            this.btnCancella.UseVisualStyleBackColor = true;
            // 
            // NuovoProdotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 264);
            this.Controls.Add(this.btnCancella);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.lblGiacenza);
            this.Controls.Add(this.txtPrez);
            this.Controls.Add(this.lblPrezzo);
            this.Controls.Add(this.txtDenom);
            this.Controls.Add(this.lblDenominazione);
            this.Controls.Add(this.txtCodice);
            this.Controls.Add(this.lblCodice);
            this.Controls.Add(this.lblTitolo);
            this.Name = "NuovoProdotto";
            this.Text = "Nuovo Prodotto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.Label lblCodice;
        private System.Windows.Forms.TextBox txtCodice;
        private System.Windows.Forms.TextBox txtDenom;
        private System.Windows.Forms.Label lblDenominazione;
        private System.Windows.Forms.TextBox txtPrez;
        private System.Windows.Forms.Label lblPrezzo;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lblGiacenza;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnCancella;
    }
}