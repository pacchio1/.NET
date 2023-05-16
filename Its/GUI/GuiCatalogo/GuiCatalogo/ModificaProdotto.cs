using Magazzino27;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiCatalogo
{
    public partial class ModificaProdotto : Form
    {
        public Prodotto Prodotto{ get; set; }
        public List<Prodotto> Lista { get; set; }
        protected string path = @"..\..\..\Files\prodotti.dat";
        public ModificaProdotto()
        {
            InitializeComponent();
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            
            Lista = MyLibrary.LeggifileOggetti(path);
            int codice =Convert.ToInt32(txtCodiceRicerca.Text);
            foreach (var item in Lista) 
            { if (item.Codice==codice)
                    Prodotto=item; 
            }
            if(Prodotto!=null)
                MessageBox.Show("Prodotto non trovato","modifica prodotto",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            else
            {
                txtCodice.Text = Prodotto.Codice.ToString();
                txtDenom.Text = Prodotto.Denominazione;
                txtPrez.Text=Prodotto.Prezzo.ToString();
                txtGia.Text=Prodotto.Giacenza.ToString();
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {

            
            Prodotto.Denominazione = txtDenom.Text;
            Prodotto.Prezzo = Convert.ToDouble(txtPrez.Text);
            Prodotto.Giacenza = Convert.ToInt32(txtGia.Text);

            MyLibrary.ScriviFileOggetti(path, Lista);
                MessageBox.Show("Prodotto  aggiornato","modifica prodotto",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
