using System;

namespace PudelkoLibrary
{
    public static class Kompresja
    {
        public static Pudelko Kompresuj(Pudelko p)
        {
            var newLen = Math.Pow(p.Objetosc, (1D / 3));
            var newPudelko = new Pudelko(newLen, newLen, newLen);

            return newPudelko;
        }
    }
}