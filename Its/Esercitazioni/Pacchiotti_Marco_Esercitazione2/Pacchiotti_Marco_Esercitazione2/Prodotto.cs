﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacchiotti_Marco_Esercitazione2
{
    internal class Prodotto
    {
        public int Codice { get; set; }
        public string NomeProdotto { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }

        public override string ToString()
        {
            return $"{nameof(Codice)}={Codice.ToString()}, {nameof(NomeProdotto)}={NomeProdotto}, {nameof(Descrizione)}={Descrizione}, {nameof(Prezzo)}={Prezzo.ToString()}";
        }
    }
}
