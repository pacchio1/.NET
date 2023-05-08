using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace quadrilateri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I quadrilater");
            var q1 = new quadrilatero(10, 10, 10, 5);
            //Console.WriteLine(q1);
            
            var q2 = new Rettangolo(30, 20);
            //Console.WriteLine(q2);
            
            var q3 = new Quadrato(25);
            //Console.WriteLine(q3);
                
            quadrilatero q4=q3;
            //Console.WriteLine(((Quadrato)q4).Area());
            quadrilatero[] quadrilateri = {q1,q2,q3};
            foreach(var q in quadrilateri)
            {
                Rettangolo r = null;
                Quadrato qua = null;
                if(q is Rettangolo) { r = (Rettangolo)q; Console.WriteLine(r.ToString()); }
                else if(qua is Quadrato) { qua = (Quadrato)q; Console.WriteLine(qua.ToString()); }
                else { q.ToString(); }
            }
            
            Console.ReadLine();
        }
    }
}
