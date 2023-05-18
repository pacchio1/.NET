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
    public partial class ElencoProdotti : Form
    {
        public ElencoProdotti()
        {
            InitializeComponent();
            LoadDati();
        }
        private void LoadDati()
        {
            string path = @"..\..\..\Files\prodotti.dat";
            var lista=MyLibrary.LeggifileOggetti(path);
            lblNProdotti.Text = lblNProdotti.Text + lista.Count;
            foreach (var item in lista)
            {
                lbxElenco.Items.Add(item.Denominazione);
            }

            
        }
    }
}
