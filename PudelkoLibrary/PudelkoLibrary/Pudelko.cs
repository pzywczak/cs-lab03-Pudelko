using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace PudelkoLibrary
{
    public enum UnitOfMeasure
    {
        milimeter = 1000,
        centimeter = 100,
        meter = 1
    }

    public sealed class Pudelko : IFormattable, IEquatable<Pudelko>, IEnumerable<double>
    {
        private readonly double length;
        private readonly double width;
        private readonly double height;
        private readonly UnitOfMeasure _unit;
        private readonly double[] _indexArr;
        public double A { get => Math.Truncate(1000 * this.length) / 1000; }
        public double B { get => Math.Truncate(1000 * this.width) / 1000; }
        public double C { get => Math.Truncate(1000 * this.height) / 1000; }

        public double Objetosc => Math.Round(A * B * C, 9);
        public double Pole => Math.Round((2 * A * B) + (2 * A * C) + (2 * B * C), 6);

        public Pudelko(double a, double b, double c, UnitOfMeasure unit = UnitOfMeasure.meter)
        {
            if ((a > 0) && (a / (double)unit <= 10.0))
            {
                length = a / (double)unit;
            }
            else
            {
                throw new ArgumentOutOfRangeException(a.ToString());
            }

            if ((b > 0) && (b / (double)unit <= 10.0))
            {
                width = b / (double)unit;
            }
            else
            {
                throw new ArgumentOutOfRangeException(b.ToString());
            }

            if ((c > 0) && (c / (double)unit <= 10.0))
            {
                height = c / (double)unit;
            }
            else
            {
                throw new ArgumentOutOfRangeException(c.ToString());
            }

            if (A == 0 || B == 0 || C == 0)
                throw new ArgumentOutOfRangeException();

            _indexArr = new double[] { A, B, C };
            _unit = unit;
        }

        public override string ToString()
        {
            return $"{String.Format("{0:0.000}", A)} m \u00D7 {String.Format("{0:0.000}", B)} m \u00D7 {String.Format("{0:0.000}", C)} m";
        }

        public string ToString(string format, IFormatProvider provider = null)
        {
            switch (format)
            {
                case "cm":
                    return $"{String.Format("{0:0.0}", A * 100)} cm \u00D7 {String.Format("{0:0.0}", B * 100)} cm \u00D7 {String.Format("{0:0.0}", C * 100)} cm";
                case "mm":
                    return $"{String.Format("{0:0}", A * 1000)} mm \u00D7 {String.Format("{0:0}", B * 1000)} mm \u00D7 {String.Format("{0:0}", C * 1000)} mm";
                case "m":
                    return ToString();
                case null:
                    return ToString();
                default:
                    throw new FormatException("Invalid format");
            }
        }
    }
    
}
