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
using System.IO;

namespace SuperPing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TextBox[] txtIP = new TextBox[5];
        TextBox[] txtStatus = new TextBox[5];
        TextBox[] txtMs = new TextBox[5];
        PictureBox[] boxes = new PictureBox[5];
        string nomefile = "bin/Debug/ip.csv", x = "X.png", v = "V.png";

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader File = new StreamReader(nomefile);
            string IPS;
            IPS = File.ReadToEnd();
            string[] campi = IPS.Split('%');

            for (int i = 0; i < 5; i++)
            {
                txtIP[i] = new TextBox();
                txtIP[i].Top = ((i + 1) * 50);
                txtIP[i].Left = (i + 1) + 19;
                txtIP[i].Text = campi[i];
                this.Controls.Add(txtIP[i]);
                txtStatus[i] = new TextBox();
                txtStatus[i].Top = ((i + 1) * 50);
                txtStatus[i].Left = (i + 150);
                txtStatus[i].Text = "host";
                this.Controls.Add(txtStatus[i]);
                txtMs[i] = new TextBox();
                txtMs[i].Top = ((i + 1) * 50);
                txtMs[i].Left = (i + 300);
                txtMs[i].Text = "ms";
                this.Controls.Add(txtMs[i]);
                boxes[i] = new PictureBox();
                boxes[i].Top = ((i + 1) * 50);
                boxes[i].Left= (i + 425);
                boxes[i].Width = 20;
                boxes[i].Height = 20;
                this.Controls.Add(boxes[i]);
            }
            File.Close();
        }//load

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                //this.Cursor = Cursors.WaitCursor;
                //txtStatus[1].Text = "";
                //txtMs.Text = "";
                string Indirizzo = txtIP[i].Text;

                Ping pinger = new Ping();
                PingReply reply = pinger.Send(Indirizzo);
                string status = reply.Status.ToString();
                string millisec = reply.RoundtripTime.ToString();
                txtStatus[i].Text = status;
                txtMs[i].Text = millisec;
                this.Cursor = Cursors.Arrow;
                if (txtStatus[i].Text == "Success")
                {
                    txtStatus[i].BackColor = Color.LightGreen;
                    boxes[i].Load(v);
                }
                else
                {
                    txtStatus[i].BackColor = Color.OrangeRed;
                    boxes[i].Load(x);
                }
            }
        }//bn forza



        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                string Indirizzo = txtIP[i].Text;

                Ping pinger = new Ping();
                PingReply reply = pinger.Send(Indirizzo);
                string status = reply.Status.ToString();
                string millisec = reply.RoundtripTime.ToString();
                txtStatus[i].Text = status;
                txtMs[i].Text = millisec;
                this.Cursor = Cursors.Arrow;
                if (txtStatus[i].Text == "Success")
                {
                    txtStatus[i].BackColor = Color.LightGreen;
                    boxes[i].Load(v);
                }
                else
                {
                    txtStatus[i].BackColor = Color.OrangeRed;
                    boxes[i].Load(x);
                }

            }
        }//timer

        private void Name_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled=true;

        }

        private void rdbOff_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void save_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(nomefile);
            string tds = null;
            for(int i=0;i<5;i++)
            {
                tds = tds + txtIP[i].Text + '%';
            }
            writer.WriteLine(tds);
            writer.Close();
            Application.Exit();
        }//btn save
    }
}
