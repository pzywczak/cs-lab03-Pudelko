using System;
using System.Collections.Generic;
using static PudelkoLibrary.UnitOfMeasure;
using static PudelkoLibrary.Kompresja;


namespace PudelkoLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<Pudelko>
            {
                new Pudelko(2.2002, 8, 10),
                new Pudelko(2.5, 9.321, 1, UnitOfMeasure.meter),
                new Pudelko(5, 4.7, 2.3, UnitOfMeasure.centimeter),
                new Pudelko(5, 9, 3, UnitOfMeasure.milimeter),
            };

            Console.WriteLine("Pudelka:");
            Console.WriteLine("-----------------------------");
            foreach (var n in lista)
            {
                Console.WriteLine(n.ToString());
            }
            Console.WriteLine("-----------------------------");

            Console.WriteLine("\nMetoda ToString:");
            Console.WriteLine("-----------------------------");
            Console.WriteLine((new Pudelko(5.21, 4, 6.02)).ToString("mm"));
            Console.WriteLine((new Pudelko(5.21, 4, 6.02)).ToString("cm"));
            Console.WriteLine((new Pudelko(5.21, 4, 6.02)).ToString("m"));
            Console.WriteLine("-----------------------------");

            Console.WriteLine();

            Console.WriteLine("Objetosc i Pole:");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("a = 3.3, b = 8, c = 2");
            Console.WriteLine((new Pudelko(3.3, 8, 2)).Objetosc);
            Console.WriteLine((new Pudelko(3.3, 8, 2)).Pole);
            Console.WriteLine("-----------------------------");

            Console.WriteLine();
            Console.WriteLine("Equals:");
            Console.WriteLine("-----------------------------");
            var pudelko1 = new Pudelko(4, 3, 1.1);
            var pudelko2 = new Pudelko(4, 3, 1.1);
            var pudelko3 = new Pudelko(4, 9.999, 1.1);
            Console.WriteLine(pudelko1.Equals(pudelko2));
            Console.WriteLine(pudelko1.Equals(pudelko3));
            Console.WriteLine("-----------------------------");

            Console.WriteLine();
            Console.WriteLine("GetHashCode:");
            Console.WriteLine("-----------------------------");
            Console.WriteLine(pudelko1.GetHashCode());
            Console.WriteLine(pudelko3.GetHashCode());
            Console.WriteLine("-----------------------------");


            Console.WriteLine("-----------------------------");
            Console.WriteLine("Tworzenie pudelka przez '+':");
            Console.WriteLine("---");
            Console.WriteLine(pudelko1 + pudelko3);
            Console.WriteLine("-----------------------------");
            Console.WriteLine();

            var pudelko4 = new Pudelko(6, 5, 2);
            var pudelko5 = new Pudelko(2, 10, 5);
            var pudelko6 = new Pudelko(5, 9.999, 1.1);

            var listaPudelek = new List<Pudelko> { pudelko4, pudelko5, pudelko6 };
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Skompresowane pudelko:");
            Console.WriteLine("-----------------------------");
            Console.WriteLine(Kompresuj(pudelko1));

            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Posortowana lista:");
            
            listaPudelek.Sort(Pudelko.Comparison);
            foreach (var i in listaPudelek)
            {
                Console.WriteLine(i); 
            }
            Console.WriteLine("-----------------------------");



        }
    }
}