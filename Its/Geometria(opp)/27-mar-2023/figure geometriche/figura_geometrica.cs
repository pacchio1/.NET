namespace figure_geometriche
{
    public class Quadrato
    {
        //proprieta
        public float Lato { get; set; }

        //metodi
        public float Perimetro() {
            return Lato * 4;
        }
        public float Area()
        {
            return Lato * Lato;
        }

        public double Diagonale()
        {
            return Lato * Math.Sqrt(2);
        }
        public override string ToString()
        {
            return $"Lato:{Lato}\n" +
                $"Perimetro:{Perimetro()}\n" +
                $"Area:{Area()}\n" +
                $"Diagonale:{Diagonale()}";
        }
        //accessori

    }//class Quadrato
    public class Triangolo{
        public double Lato1 { get; set; }
        public double Lato2 { get; set; }
        public double Lato3 { get; set; }

        public Triangolo(double lato1, double lato2, double lato3)
        {
            Lato1 = lato1;
            Lato2 = lato2;
            Lato3 = lato3;
        }
        public Triangolo(Punto a,Punto b,Punto c) : 
            this(a.Distanza(b), b.Distanza(c), c.Distanza(a)) 
        { }
        
        public bool costruibile()
        {
            return Lato1 + Lato2>Lato3
                && Lato2 + Lato3 > Lato1
                && Lato3 + Lato1 > Lato2;
        }
        public double Perimetro()
        {
            return Lato1+Lato2+Lato3;
        }
        
        public double Area()
        {
            double sp = Perimetro()/2;
            if (!costruibile())
                throw new Exception("dati errati");
            return Math.Sqrt(sp)*(sp-Lato1)*(sp-Lato2)*(sp-Lato3);
        }//formula erone
        public string Tipo()
        {
            if (Lato1 == Lato2 && Lato1 == Lato3)
                return "Equilatero";
            if (Lato1 == Lato2 || Lato1 == Lato3 || Lato2 == Lato3)
                return "Isoscele";
            return "Scaleno";
        }

        public override string ToString()
        {
            return $"\n Lato1:{Lato1}" +
                $"\n Lato2:{Lato2}" +
                $"\n Lato3:{Lato3}" +
                $"\n Perimetro:{Perimetro()}" +
                $"\n Area:{Area()}" +
                $"\n Tipo:{Tipo()}";
        }
    }//class Triangolo
    public class Punto
    {
        public double x { get; set; }
        public double y { get; set; }
        //metodi
        public double Distanza(Punto punto)
        {
            return Math.Sqrt(Math.Pow(this.x-punto.x,2)+Math.Pow(this.y-punto.y,2));
        }
        public double Distanza()
        {
            var o=new Punto { x=0,y=0 };
            return Distanza(o);
        }

        public override string ToString()
        {
            return $"{{{nameof(x)}={x.ToString()}, {nameof(y)}={y.ToString()}}}";
        }
    }//class punto
}//namespace
