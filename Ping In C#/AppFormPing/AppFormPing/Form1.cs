using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Timers;


namespace AppFormPing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pannelSucces.Visible = false;
            panelfail.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            txtStatus.Text = "";
            txtMs.Text = "";
            string Indirizzo = txtIP.Text;

            Ping pinger = new Ping();
            PingReply reply = pinger.Send(Indirizzo);
            string status = reply.Status.ToString();
            string millisec = reply.RoundtripTime.ToString();
            txtStatus.Text = status;
            txtMs.Text = millisec;
            this.Cursor = Cursors.Arrow;
        }
        string cecked;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            txtStatus.Text = "";
            txtMs.Text = "";
            string Indirizzo = txtIP.Text;

            Ping pinger = new Ping();
            PingReply reply = pinger.Send(Indirizzo);
            string status = reply.Status.ToString();
            string millisec = reply.RoundtripTime.ToString();
            txtStatus.Text = status;
            txtMs.Text = millisec;
            this.Cursor = Cursors.Arrow;
            cecked = txtStatus.Text;
            if (cecked == "Success")
            {
                pannelSucces.Visible = true;
                paneldefolt.Visible = false;
            }
            else
            {
                panelfail.Visible = true;
                paneldefolt.Visible = false;
            }
        }
         
        private void rdbOff_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void RDBoN_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
        
       

    }
}
