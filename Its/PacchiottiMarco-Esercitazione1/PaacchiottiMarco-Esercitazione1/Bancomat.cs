using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaacchiottiMarco_Esercitazione1
{
    internal class Bancomat
    {
        public int N_10_E { get; set; }
        public int N_20_E { get; set; }
        public int N_50_E { get; set; }

        public Bancomat(int n_10_E, int n_20_E, int n_50_E)
        {
            N_10_E = n_10_E;
            N_20_E = n_20_E;
            N_50_E = n_50_E;
        }

        public Bancomat(int n_10_E):this(0,0,n_10_E)
        {
            N_10_E = n_10_E;
        }
        public string InterrogazioneBancomat()
        {

            string r = "Totale "+totale().ToString()+"euro \n Banconote disponibili da 50 :"+N_50_E.ToString()+"\n Banconote disponibili da 20 :" + N_20_E.ToString() + "\n Banconote disponibili da 10 :" + N_10_E.ToString();
            return r;
        }
        public double totale() => N_10_E * 10 + N_20_E * 20 + N_50_E * 50;
        public bool Togli50(int i)
        {
            bool r= true;
            if (N_50_E>i&&N_50_E>0)
                N_50_E -= i;
            else r= false;
            return r;
        }
        public String[] PrelievoFallito()
        {
            string[] a = { "operazzione fallita","Numero di banconote consegnate da 50 euro: 0", "Numero di banconote consegnate da 20 euro: 0", "Numero di banconote consegnate da 10 euro: 0" };
            return a;
        }
        public String[] Prelievo(double i)
        {
            string[] a=new string[4];
            int j = 0;
            if (i < totale() && i > 0) { 
                a[0] = "operazione riuscita";
                while (i / 50 > 0 && N_50_E > 0) { 
                    i = i- 50;
                    N_50_E -= 1;
                    j++;
                }
                a[1] = "Numero di banconote consegnate da 50 euro: " + j;
                j=0;
                while (i / 20 > 0 && N_20_E > 0)
                {
                    i = i - 20;
                    N_20_E -= 1; j++;
                }
                a[2] = "Numero di banconote consegnate da 20 euro: " + j;
                j = 0;
                while (i / 10 > 0 && N_10_E > 0)
                {
                    i = i - 10; ;
                    N_50_E -= 1; j++;
                }
                a[3] = "Numero di banconote consegnate da 10 euro: " + j;
                j = 0;
                if (i > 0){
                    a = PrelievoFallito();
                }
            }
            else
            {
                a=PrelievoFallito();
            }
            return a;
        }

        public override string ToString() => InterrogazioneBancomat();
    }
}
