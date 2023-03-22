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
        double a=0, b=0;
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
                    tot = a + b;
                    txt_OUT.Text = tot.ToString();
                    break;
                case '-':
                    tot = a - b;
                    txt_OUT.Text = tot.ToString();
                    break;
                case '/':
                    if (b != 0) {
                        tot = a / b;
                        txt_OUT.Text = tot.ToString();
                    }
                    else {
                        txt_OUT.Text = "ERROR";
                        
                    }
                    break;
                case '*':
                    tot = a * b;
                    txt_OUT.Text = tot.ToString();
                    break;
                  
            }
            string operazione = a.ToString() + calcolo + b.ToString()+"="+tot.ToString();
            a = tot;b = 0;
            
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
                a = 7;
                
            }
            else
            {
                b= 7;
            }
            
            
            if(firstdigit==false)
                txt_OUT.Text = txt_OUT.Text + "7";
            else
            {
                txt_OUT.Text = "7";
            }
            firstdigit = false;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (ifb == false)
            {
                a = 8;
            }
            else
            {
                b = 8;
            }
            if (firstdigit == false)
                txt_OUT.Text = txt_OUT.Text + "8";
            else
            {
                txt_OUT.Text = "8";
            }
            firstdigit = false;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (ifb == false)
            {
                a = 9;
            }
            else
            {
                b = 9;
            }
            if (firstdigit == false)
                txt_OUT.Text = txt_OUT.Text + "9";
            else
            {
                txt_OUT.Text = "9";
            }
            firstdigit = false;
        }
        

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (ifb == false)
            {
                a = 6;
            }
            else
            {
                b = 6;
            }
            if (firstdigit == false)
                txt_OUT.Text = txt_OUT.Text + "6";
            else
            {
                txt_OUT.Text = "6";
            }
            firstdigit = false;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (ifb == false)
            {
                a = 5;
            }
            else
            {
                b = 5;
            }
            if (firstdigit == false)
                txt_OUT.Text = txt_OUT.Text + "5";
            else
            {
                txt_OUT.Text = "5";
            }
            firstdigit = false;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (ifb == false)
            {
                a = 4;
            }
            else
            {
                b = 4;
            }
            if (firstdigit == false)
                txt_OUT.Text = txt_OUT.Text + "4";
            else
            {
                txt_OUT.Text = "4";
            }
            firstdigit = false;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (ifb == false)
            {
                a = 3;
            }
            else
            {
                b = 3;
            }
            if (firstdigit == false)
                txt_OUT.Text = txt_OUT.Text + "3";
            else
            {
                txt_OUT.Text = "3";
            }
            firstdigit = false;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (ifb == false)
            {
                a = 2;
                
            }
            else
            {
                b = 2;
            }
            if (firstdigit == false)
                txt_OUT.Text = txt_OUT.Text + "2";
            else
            {
                txt_OUT.Text = "2";
            }
            firstdigit = false;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (ifb == false)
            {
                a = 1;
                
            }
            else
            {
                b = 1;
            }
            if (firstdigit == false)
                txt_OUT.Text = txt_OUT.Text + "1";
            else
            {
                txt_OUT.Text = "1";
            }
            firstdigit = false;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (ifb == false)
            {
                a = 0;
                
            }
            else
            {
                b = 0;
                
            }

            if (firstdigit == false)
            {
                txt_OUT.Text = txt_OUT.Text + "0";
                firstdigit = false;
            }
            else
            {
                txt_OUT.Text = "0";
            }
            
        }

        private void lsb_cronologia_SelectedIndexChanged(object sender, EventArgs e)
        {

            string tmp,aux;
            int start=0,end=0;
            tmp=lsb_cronologia.SelectedItem.ToString();
            //txt_OUT.Text = tmp;
            // to do prendere il numero dopo l' uguale (situazione x+y=z parte inportante la z) 
            start=tmp.IndexOf('=');
            aux=tmp.Substring(start+1);
            a=int.Parse(aux);
            ifb = true;
            b = 0;
            txt_OUT.Text = tmp;
            firstdigit = false; 
            

        }

        private void BTN_piuOmeno_Click(object sender, EventArgs e)
        {
            if (ifb == false)
            {
                a = -a;
                txt_OUT.Text = a.ToString();
            }
            else
            {
                b = -b;
                txt_OUT.Text = b.ToString();
            }
            
           
            
                
            
            
        }

        private void btn_perc_Click(object sender, EventArgs e)
        {   
            if (b != 0) {
                txt_OUT.Text="Error";
            }
            else
            {
                a = (a / 100);
                txt_OUT.Text = a.ToString();
            }

            
        }

        private void BTN_AC_Click(object sender, EventArgs e)
        {
            ifb= false;
            a=0;
            b = 0;
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
