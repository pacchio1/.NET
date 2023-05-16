using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui_Quadrato.net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TxtOut.Enabled= false;
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            var q = new Quadrato();
            try
            {
                if(txtIn.Text.Trim().Length == 0)
                {
                    throw new Exception("il lato e obbligatorio");
                }
                    
                
                q.Lato = double.Parse(txtIn.Text);
                TxtOut.Text = q.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"input dati",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void btnCancella_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("sicuro di voler eliminare i dati visualizati", "cancella", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TxtOut.Text = string.Empty;
                txtIn.Text = string.Empty; 
            }
            
        }
    }
}
