namespace Gui_Quadrato.net
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.TxtOut = new System.Windows.Forms.RichTextBox();
            this.btnInvia = new System.Windows.Forms.Button();
            this.btnCancella = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gui quadrato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "inserisci lato";
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(86, 30);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(75, 20);
            this.txtIn.TabIndex = 2;
            // 
            // TxtOut
            // 
            this.TxtOut.Location = new System.Drawing.Point(35, 85);
            this.TxtOut.Name = "TxtOut";
            this.TxtOut.ReadOnly = true;
            this.TxtOut.Size = new System.Drawing.Size(100, 96);
            this.TxtOut.TabIndex = 3;
            this.TxtOut.Text = "";
            // 
            // btnInvia
            // 
            this.btnInvia.Location = new System.Drawing.Point(86, 56);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(75, 23);
            this.btnInvia.TabIndex = 4;
            this.btnInvia.Text = "invia";
            this.btnInvia.UseVisualStyleBackColor = true;
            this.btnInvia.Click += new System.EventHandler(this.btnInvia_Click);
            // 
            // btnCancella
            // 
            this.btnCancella.Location = new System.Drawing.Point(5, 56);
            this.btnCancella.Name = "btnCancella";
            this.btnCancella.Size = new System.Drawing.Size(75, 23);
            this.btnCancella.TabIndex = 5;
            this.btnCancella.Text = "cancella";
            this.btnCancella.UseVisualStyleBackColor = true;
            this.btnCancella.Click += new System.EventHandler(this.btnCancella_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 184);
            this.Controls.Add(this.btnCancella);
            this.Controls.Add(this.btnInvia);
            this.Controls.Add(this.TxtOut);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.RichTextBox TxtOut;
        private System.Windows.Forms.Button btnInvia;
        private System.Windows.Forms.Button btnCancella;
    }
}

