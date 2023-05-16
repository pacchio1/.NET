using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TestGui : Form
    {
        public TestGui()
        {
            InitializeComponent();
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            string txt = txtIn.Text;
            lblOut.Visible = true;
            lblOut.Text = "hai inserito: "+txt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
