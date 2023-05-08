namespace figure_geometriche
{
  
    internal class Program
    {
        static void Main(string[] args)
        {
            //figure_geometriche.Quadrato q = new Quadrato();
            //q.Lato = float.Parse(Console.ReadLine());
            //Console.WriteLine($"Lato: {q.Lato}");
            //Console.WriteLine($"Perimetro: {q.Perimetro()}");
            //Console.WriteLine($"Area: {q.Area()}");
            //Console.WriteLine($"Diagonale: {q.Diagonale()}");
            //Console.WriteLine(q.ToString());
            //var q1=new Quadrato { Lato=2.5f};
            //Console.WriteLine("\n \n"+ q1);
            //Console.WriteLine("lati del triangolo");
            //double Lato1=double.Parse(Console.ReadLine());
            //double Lato2 = double.Parse(Console.ReadLine());
            //double Lato3= double.Parse(Console.ReadLine());
            //try { var t1 = new Triangolo(Lato1, Lato2, Lato3); Console.WriteLine(t1); }
            //catch (Exception ex) { Console.WriteLine(ex); }
            //var p = new Punto { x = 2.5, y = 3.75 };
            //Console.WriteLine(p);
            var a = new Punto { x = 0, y = 0 };var b = new Punto { x = -10, y = -5 };var c = new Punto{x=-10,y=5};
            //var ab = a.Distanza(b);
            //var bc = b.Distanza(c);
            //var ca = c.Distanza(a);
            try { var triangolo_punti = new Triangolo(a, b, c); Console.WriteLine(triangolo_punti); }
            catch(Exception ex) { Console.WriteLine(ex); }


        }
    }
}