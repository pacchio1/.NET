using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lista = new ArrayList();
            lista.Add("Pierre");
            lista.Add(12);
            lista.Add('c');
            lista.Add(false);
        }
    }
}
