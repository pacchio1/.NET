using Magazzino27;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiCatalogo
{
    public partial class NuovoProdotto : Form
    {
        public NuovoProdotto()
        {
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            string path = @"..\..\..\Files\prodotti.dat";
            //var Lista=MyLibrary.LeggifileOggetti(path);
            var Lista=new List<Prodotto>();
            Lista.Add(new Prodotto { Codice=Convert.ToInt32(txtCodice.Text),
                Denominazione=txtDenom.Text,
                Prezzo=Convert.ToDouble(txtPrez.Text),
                Giacenza=Convert.ToInt32(txtGia.Text) });
            MyLibrary.ScriviFileOggetti(path, Lista);
            MessageBox.Show("operazione avvenuta con successo", "Nuovo prodotto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
