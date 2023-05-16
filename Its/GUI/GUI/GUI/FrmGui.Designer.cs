namespace GUI
{
    partial class TestGui
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblTitolo = new System.Windows.Forms.Label();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.btnInvia = new System.Windows.Forms.Button();
            this.lblOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblTitolo
            // 
            this.LblTitolo.AutoSize = true;
            this.LblTitolo.Location = new System.Drawing.Point(12, 9);
            this.LblTitolo.Name = "LblTitolo";
            this.LblTitolo.Size = new System.Drawing.Size(95, 13);
            this.LblTitolo.TabIndex = 0;
            this.LblTitolo.Text = "Titolo della finestra";
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(15, 25);
            this.txtIn.Multiline = true;
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(226, 60);
            this.txtIn.TabIndex = 1;
            // 
            // btnInvia
            // 
            this.btnInvia.Location = new System.Drawing.Point(15, 91);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(75, 23);
            this.btnInvia.TabIndex = 2;
            this.btnInvia.Text = "invia";
            this.btnInvia.UseVisualStyleBackColor = true;
            this.btnInvia.Click += new System.EventHandler(this.btnInvia_Click);
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(97, 91);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(35, 13);
            this.lblOut.TabIndex = 3;
            this.lblOut.Text = "label1";
            this.lblOut.Visible = false;
            // 
            // TestGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 122);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.btnInvia);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.LblTitolo);
            this.Name = "TestGui";
            this.Text = "Test Gui";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitolo;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.Button btnInvia;
        private System.Windows.Forms.Label lblOut;
    }
}

