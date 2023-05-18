using Magazzino27;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiCatalogo
{

    public partial class EliminaProdotto : Form
    {
        public Prodotto Prodotto { get; set; }
        public List<Prodotto> Lista { get; set; }
        protected string path = @"..\..\..\Files\prodotti.dat";
        public EliminaProdotto()
        {
            InitializeComponent();
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            Lista = MyLibrary.LeggifileOggetti(path);
            int codice = Convert.ToInt32(txtCodiceRicerca.Text);
            foreach (var item in Lista)
            {
                if (item.Codice == codice)
                    Prodotto = item;
            }
            if (Prodotto != null)
                MessageBox.Show("Prodotto non trovato", "modifica prodotto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                txtCodice.Text = Prodotto.Codice.ToString();
                txtDenom.Text = Prodotto.Denominazione;
                txtPrez.Text = Prodotto.Prezzo.ToString();
                txtGia.Text = Prodotto.Giacenza.ToString();
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {

        }
    }
}
