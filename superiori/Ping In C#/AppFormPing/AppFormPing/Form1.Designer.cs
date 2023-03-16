namespace AppFormPing
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
            this.components = new System.ComponentModel.Container();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtMs = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rdbOff = new System.Windows.Forms.RadioButton();
            this.RDBoN = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.paneldefolt = new System.Windows.Forms.Panel();
            this.pannelSucces = new System.Windows.Forms.Panel();
            this.panelfail = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(12, 25);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 0;
            // 
            // txtMs
            // 
            this.txtMs.Location = new System.Drawing.Point(118, 25);
            this.txtMs.Name = "txtMs";
            this.txtMs.ReadOnly = true;
            this.txtMs.Size = new System.Drawing.Size(100, 20);
            this.txtMs.TabIndex = 0;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(12, 67);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ping";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rdbOff
            // 
            this.rdbOff.AutoSize = true;
            this.rdbOff.Location = new System.Drawing.Point(139, 67);
            this.rdbOff.Name = "rdbOff";
            this.rdbOff.Size = new System.Drawing.Size(37, 17);
            this.rdbOff.TabIndex = 6;
            this.rdbOff.Text = "on";
            this.rdbOff.UseVisualStyleBackColor = true;
            this.rdbOff.CheckedChanged += new System.EventHandler(this.rdbOff_CheckedChanged);
            // 
            // RDBoN
            // 
            this.RDBoN.AutoSize = true;
            this.RDBoN.Checked = true;
            this.RDBoN.Location = new System.Drawing.Point(182, 67);
            this.RDBoN.Name = "RDBoN";
            this.RDBoN.Size = new System.Drawing.Size(37, 17);
            this.RDBoN.TabIndex = 7;
            this.RDBoN.TabStop = true;
            this.RDBoN.Text = "off";
            this.RDBoN.UseVisualStyleBackColor = true;
            this.RDBoN.CheckedChanged += new System.EventHandler(this.RDBoN_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // paneldefolt
            // 
            this.paneldefolt.BackColor = System.Drawing.Color.Yellow;
            this.paneldefolt.Location = new System.Drawing.Point(144, 94);
            this.paneldefolt.Name = "paneldefolt";
            this.paneldefolt.Size = new System.Drawing.Size(38, 33);
            this.paneldefolt.TabIndex = 8;
            // 
            // pannelSucces
            // 
            this.pannelSucces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pannelSucces.Location = new System.Drawing.Point(103, 93);
            this.pannelSucces.Name = "pannelSucces";
            this.pannelSucces.Size = new System.Drawing.Size(35, 34);
            this.pannelSucces.TabIndex = 9;
            // 
            // panelfail
            // 
            this.panelfail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelfail.Location = new System.Drawing.Point(188, 94);
            this.panelfail.Name = "panelfail";
            this.panelfail.Size = new System.Drawing.Size(38, 33);
            this.panelfail.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 158);
            this.Controls.Add(this.panelfail);
            this.Controls.Add(this.pannelSucces);
            this.Controls.Add(this.paneldefolt);
            this.Controls.Add(this.RDBoN);
            this.Controls.Add(this.rdbOff);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.txtMs);
            this.Controls.Add(this.txtStatus);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtMs;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rdbOff;
        private System.Windows.Forms.RadioButton RDBoN;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel paneldefolt;
        private System.Windows.Forms.Panel pannelSucces;
        private System.Windows.Forms.Panel panelfail;
    }
}

