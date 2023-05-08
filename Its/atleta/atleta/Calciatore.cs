using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atleta
{
    internal class Calciatore:Atleta,ICloneable,IComparable
    {
        public string Club { get; set; }
        public int PartiteGiocate { get; set; }
        public int GoalSegnati { get; set; }

        public object Clone()
        {
            if(PartiteGiocate==0)
                throw new NotSupportedException();
            return this.MemberwiseClone();
            
        }

        public int CompareTo(object obj)
        {
            if(obj is Calciatore calciatore) 
                if (this.MediaGoal()>calciatore.MediaGoal())
                    return 1;
                else return-1;
            return 0;
            
        }

        public override bool Equals(object obj)
        {
            return obj is Calciatore calciatore &&
                   Nome == calciatore.Nome &&
                   Disciplina == calciatore.Disciplina &&
                   Pettorina == calciatore.Pettorina &&
                   Club == calciatore.Club &&
                   PartiteGiocate == calciatore.PartiteGiocate &&
                   GoalSegnati == calciatore.GoalSegnati;
        }

        public double MediaGoal() => (double)GoalSegnati / PartiteGiocate;

        public override string ToString()
        {
            return base.ToString()+$"{{{nameof(Club)}={Club}, {nameof(PartiteGiocate)}={PartiteGiocate.ToString()}, {nameof(GoalSegnati)}={GoalSegnati.ToString()}, {nameof(Nome)}={Nome}, {nameof(Disciplina)}={Disciplina}, {nameof(Pettorina)}={Pettorina.ToString()}}} media goal segnati={MediaGoal().ToString()}";
        }

    }
}
