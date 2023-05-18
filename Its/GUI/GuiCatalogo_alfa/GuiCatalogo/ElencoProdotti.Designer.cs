namespace GuiCatalogo
{
    partial class ElencoProdotti
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
            this.lblNProdotti = new System.Windows.Forms.Label();
            this.lbxElenco = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Location = new System.Drawing.Point(390, 9);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(78, 13);
            this.lblTitolo.TabIndex = 0;
            this.lblTitolo.Text = "Elenco prodotti";
            // 
            // lblNProdotti
            // 
            this.lblNProdotti.AutoSize = true;
            this.lblNProdotti.Location = new System.Drawing.Point(7, 20);
            this.lblNProdotti.Name = "lblNProdotti";
            this.lblNProdotti.Size = new System.Drawing.Size(60, 13);
            this.lblNProdotti.TabIndex = 1;
            this.lblNProdotti.Text = "N. Prodotti:";
            // 
            // lbxElenco
            // 
            this.lbxElenco.FormattingEnabled = true;
            this.lbxElenco.Location = new System.Drawing.Point(7, 36);
            this.lbxElenco.Name = "lbxElenco";
            this.lbxElenco.Size = new System.Drawing.Size(781, 329);
            this.lbxElenco.TabIndex = 2;
            // 
            // ElencoProdotti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxElenco);
            this.Controls.Add(this.lblNProdotti);
            this.Controls.Add(this.lblTitolo);
            this.Name = "ElencoProdotti";
            this.Text = "Elenco Prodotti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.Label lblNProdotti;
        private System.Windows.Forms.ListBox lbxElenco;
    }
}