using System;
using System.Collections.Generic;
using static PudelkoLibrary.UnitOfMeasure;


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
                
               // new Pudelko(840.2, 590, 900, UnitOfMeasure.milimeter).Kompresuj(),
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


            Console.WriteLine("\n====Pudelka Posortowane====");
            /* var sortedList = lista
               .OrderBy(n => n.Objetosc)
               .ThenBy(n => n.Pole)
               .ThenBy(n => n.A + n.B + n.C)
               .ToList();


             foreach (var pudelko in sortedList)
                 Console.WriteLine(pudelko.ToString());
               */
            

           

            

            Console.WriteLine("===========Compare===========");
           // Console.WriteLine(box1.CompareTo(box1));
           // Console.WriteLine(box1.CompareTo(box3));
        }
    }
}