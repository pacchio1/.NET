using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Solidi
{
    [Serializable]//data annotatation
    
    internal class Cubo : Solido
    {

        public double Lato { get; set; }

        

        public override string ToString()
        {
            return $"Lato={Lato},"+base.ToString();
        }

        public override double Volume()
        {
            return Math.Pow(Lato,3);
        }

        
    }
}
