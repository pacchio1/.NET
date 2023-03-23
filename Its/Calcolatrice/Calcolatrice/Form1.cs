using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatrice
{
    public partial class txt_cronologia : Form
    {
        public txt_cronologia()
        {
            InitializeComponent();
        }
        string a="0", b="0";
        double tot = 0;
        char calcolo;
        bool ifb=false,firstdigit=true;
        private void Form1_Load(object sender, EventArgs e)
        {
            txt_OUT.Text = "0";
        }
        private void Error()
        {
            txt_OUT.Text = "ERROR";
        }
        private void btn_EQ_Click(object sender, EventArgs e)
        {
            
            switch (calcolo){
                case '+':
                    tot = float.Parse(a) + float.Parse(b);
                    txt_OUT.Text = tot.ToString();
                    break;
                case '-':
                    tot = float.Parse(a) - float.Parse(b);
                    txt_OUT.Text = tot.ToString();
                    break;
                case '/':
                    if (float.Parse(b) != 0) {
                        tot = float.Parse(a) / float.Parse(b);
                        txt_OUT.Text = tot.ToString();
                    }
                    else {
                        txt_OUT.Text = "ERROR";
                        
                    }
                    break;
                case '*':
                    tot = float.Parse(a) * float.Parse(b);
                    txt_OUT.Text = tot.ToString();
                    break;
                  
            }
            string operazione = a.ToString() + calcolo + b.ToString()+"="+tot.ToString();
            a = tot.ToString();b = "0";
            
            firstdigit = true;
            lsb_cronologia.Items.Add(operazione);

        }

        private void btn_per_Click(object sender, EventArgs e)
        {
            calcolo = '*';
            txt_OUT.Text = "*";
            ifb = true;
            txt_OUT.Text = "0";
            firstdigit = true;
        }

        private void btn_meno_Click(object sender, EventArgs e)
        {
            calcolo = '-';
            txt_OUT.Text = "-";
            ifb = true;
            txt_OUT.Text = "0";
            firstdigit = true;
        }

        private void btn_piu_Click(object sender, EventArgs e)
        {
            calcolo = '+';
            txt_OUT.Text = "+";
            ifb = true;
            txt_OUT.Text = "0";
            firstdigit = true;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            
            if (ifb == false)
            {
                if (firstdigit == false)
                {
                    txt_OUT.Text = txt_OUT.Text + "7";
                    a = a + "7";
                }
                else
                {
                    txt_OUT.Text = "7";
                    a = "7";
                }
                firstdigit = false;
                
                
            }
            else
            {
                if (firstdigit == false)
                {
                    txt_OUT.Text = txt_OUT.Text + "7";
                    b = b + "7";
                }
                else
                {
                    txt_OUT.Text = "7";
                    b = "7";
                }
                firstdigit = false;
                
            }
            
            
            
        }
        /* X sos
         * if (ifb == false)
            {
                if (firstdigit == false)
                {
                    txt_OUT.Text = txt_OUT.Text + "5";
                    a = "5";
                }
                else
                {
                    txt_OUT.Text = "5";
                    a = a + "5";
                }
                firstdigit = false;
                
                
            }
            else
            {
                if (firstdigit == false)
                {
                    txt_OUT.Text = txt_OUT.Text + "5";
                    b = "5";
                }
                else
                {
                    txt_OUT.Text = "5";
                    b = b + "5";
                }
                firstdigit = false;
                
            }
         */
        private void btn_8_Click(object sender, EventArgs e)
        {
            if (ifb == false)
            {
                if (firstdigit == false)
                {
                    txt_OUT.Text = txt_OUT.Text + "8";
                     a = a + "8";
                }
                else
                {
                    txt_OUT.Text = "8";
                   a = "8";
                }
                firstdigit = false;


            }
            else
            {
                if (firstdigit == false)
                {
                    txt_OUT.Text = txt_OUT.Text + "8";
                    b = b + "8";
                }
                else
                {
                    txt_OUT.Text = "8";
                    b = "8";
                }
                firstdigit = false;

            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (ifb == false)
            {
                if (firstdigit == false)
                {
                    txt_OUT.Text = txt_OUT.Text + "9";
                    a = a + "9";
                }
                else
                {
                    txt_OUT.Text = "9";
                    a = "9";
                }
                firstdigit = false;


            }
            else
            {
                if (firstdigit == false)
                {
                    txt_OUT.Text = txt_OUT.Text + "9";
                    b = b + "9";
                }
                else
                {
                    txt_OUT.Text = "9";
                    b = "9";
                }
                firstdigit = false;

            }
        }
        

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (ifb == false)
            {
                if (firstdigit == false)
                {
                    txt_OUT.Text = txt_OUT.Text + "6";
                    a = a + "6";
                }
                else
                {
                    txt_OUT.Text = "6";
                    a = "6";
                }
                firstdigit = false;


            }
            else
            {
                if (firstdigit == false)
                {
                    txt_OUT.Text = txt_OUT.Text + "6";
                    b = b + "6";
                }
                else
                {
                    txt_OUT.Text = "6";
                    b = "6";
                }
                firstdigit = false;

            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (ifb == false)
            {
                if (firstdigit == false)
                {
                    txt_OUT.Text = txt_OUT.Text + "5";
                    a = a + "5";
                }
                else
                {
                    txt_OUT.Text = "5";
                    a = "5";
                }
                firstdigit = false;


            }
            else
            {
                if (firstdigit == false)
                {
                    txt_OUT.Text = txt_OUT.Text + "5";
                    b = b + "5";
                }
                else
                {
                    txt_OUT.Text = "5";
                    b = "5";
                }
                firstdigit = false;

            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (ifb == false)
            {
                if (firstdigit == false)
                {
                    txt_OUT.Text = txt_OUT.Text + "4";
                    a = a + "4";
                }
                else
                {
                    txt_OUT.Text = "4";
                    a = "4";
                }
                firstdigit = false;


            }
            else
            {
                if (firstdigit == false)
                {
                    txt_OUT.Text = txt_OUT.Text + "4";
                    b = b + "4";
                }
                else
                {
                    txt_OUT.Text = "4";
                    b = "4";
                }
                firstdigit = false;

            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (ifb == false)
            {
                if (firstdigit == false)
                {
                    txt_OUT.Text = txt_OUT.Text + "3";
                    a = a + "3";
                }
                else
                {
                    txt_OUT.Text = "3";
                    a = "3";
                }
                firstdigit = false;


            }
            else
            {
                if (firstdigit == false)
                {
                    txt_OUT.Text = txt_OUT.Text + "3";
                     b = b + "3";
                }
                else
                {
                    txt_OUT.Text = "3";
                    b = "3";
                }
                firstdigit = false;

            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (ifb == false)
            {
                if (firstdigit == false)
                {
                    txt_OUT.Text = txt_OUT.Text + "2";
                     a = a + "2";
                }
                else
                {
                    txt_OUT.Text = "2";
                    a = "2";
                }
                firstdigit = false;


            }
            else
            {
                if (firstdigit == false)
                {
                    txt_OUT.Text = txt_OUT.Text + "2";
                     b = b + "2";
                }
                else
                {
                    txt_OUT.Text = "2";
                    b = "2";
                }
                firstdigit = false;

            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (ifb == false)
            {
                if (firstdigit == false)
                {
                    txt_OUT.Text = txt_OUT.Text + "1";
                     a = a + "1";
                }
                else
                {
                    txt_OUT.Text = "1";
                    a = "1";
                }
                firstdigit = false;


            }
            else
            {
                if (firstdigit == false)
                {
                    txt_OUT.Text = txt_OUT.Text + "1";
                    b = b + "1";
                }
                else
                {
                    txt_OUT.Text = "1";
                    b = "1";
                }
                firstdigit = false;

            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (ifb == false)
            {
                if (firstdigit == false)
                {
                    txt_OUT.Text = txt_OUT.Text + "0";
                     a = a + "0";
                }
                else
                {
                    txt_OUT.Text = "0";
                    a = "0";
                }
                firstdigit = false;


            }
            else
            {
                if (firstdigit == false)
                {
                    txt_OUT.Text = txt_OUT.Text + "0";
                     b = b + "0";
                }
                else
                {
                    txt_OUT.Text = "0";
                    b = "0";
                }
                firstdigit = false;

            }

        }

        private void lsb_cronologia_SelectedIndexChanged(object sender, EventArgs e)
        {

            string tmp,aux;
            int start=0;
            tmp=lsb_cronologia.SelectedItem.ToString();
            //txt_OUT.Text = tmp;
            // to do prendere il numero dopo l' uguale (situazione x+y=z parte inportante la z) 
            start=tmp.IndexOf('=');
            aux=tmp.Substring(start+1);
            a = aux;
            ifb = true;
            b = "0";
            txt_OUT.Text = tmp;
            firstdigit = false; 
            

        }

        private void BTN_piuOmeno_Click(object sender, EventArgs e)
        {
            if (ifb == false)
            {
                a = "-"+a;
                txt_OUT.Text = a.ToString();
            }
            else
            {
                b = "-" + b;
                txt_OUT.Text = b.ToString();
            }
            
           
            
                
            
            
        }

        private void btn_perc_Click(object sender, EventArgs e)
        {   
            if (float.Parse(b) != 0) {
                txt_OUT.Text="Error";
            }
            else
            {
                a = (float.Parse(a) / 100).ToString();
                txt_OUT.Text = a.ToString();
            }

            
        }

        private void BTN_AC_Click(object sender, EventArgs e)
        {
            ifb= false;
            a="0";
            b = "0";
            txt_OUT.Text = "0";
            firstdigit = true;
        }

        private void btn_Diviso_Click(object sender, EventArgs e)
        {
            calcolo = '/';
            txt_OUT.Text = "/";
            ifb = true;
            txt_OUT.Text = "0";
            firstdigit = true;
        }
    }
}
