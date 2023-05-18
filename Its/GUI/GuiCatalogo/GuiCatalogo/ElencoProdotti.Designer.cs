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
            this.lblNumeroProdotti = new System.Windows.Forms.Label();
            this.lbxElenco = new System.Windows.Forms.ListBox();
            this.btnElencoCsv = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Location = new System.Drawing.Point(356, 23);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(88, 15);
            this.lblTitolo.TabIndex = 0;
            this.lblTitolo.Text = "Elenco Prodotti";
            // 
            // lblNumeroProdotti
            // 
            this.lblNumeroProdotti.AutoSize = true;
            this.lblNumeroProdotti.Location = new System.Drawing.Point(51, 80);
            this.lblNumeroProdotti.Name = "lblNumeroProdotti";
            this.lblNumeroProdotti.Size = new System.Drawing.Size(140, 15);
            this.lblNumeroProdotti.TabIndex = 1;
            this.lblNumeroProdotti.Text = "Numero prodotti trovati: ";
            // 
            // lbxElenco
            // 
            this.lbxElenco.FormattingEnabled = true;
            this.lbxElenco.ItemHeight = 15;
            this.lbxElenco.Location = new System.Drawing.Point(51, 112);
            this.lbxElenco.Name = "lbxElenco";
            this.lbxElenco.Size = new System.Drawing.Size(467, 259);
            this.lbxElenco.TabIndex = 2;
            // 
            // btnElencoCsv
            // 
            this.btnElencoCsv.Location = new System.Drawing.Point(51, 399);
            this.btnElencoCsv.Name = "btnElencoCsv";
            this.btnElencoCsv.Size = new System.Drawing.Size(177, 43);
            this.btnElencoCsv.TabIndex = 3;
            this.btnElencoCsv.Text = "Scrivi Elenco Csv";
            this.btnElencoCsv.UseVisualStyleBackColor = true;
            this.btnElencoCsv.Click += new System.EventHandler(this.btnElencoCsv_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Leggi Elenco Csv";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ElencoProdotti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnElencoCsv);
            this.Controls.Add(this.lbxElenco);
            this.Controls.Add(this.lblNumeroProdotti);
            this.Controls.Add(this.lblTitolo);
            this.Name = "ElencoProdotti";
            this.Text = "Elenco Prodotti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitolo;
        private Label lblNumeroProdotti;
        private ListBox lbxElenco;
        private Button btnElencoCsv;
        private Button button1;
    }
}