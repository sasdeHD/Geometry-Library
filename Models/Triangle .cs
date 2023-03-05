using GeometryLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Models
{
    public class Triangle : IShape
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double CalculateArea()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool IsRightTriangle()
        {
            return Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) ||
                   Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2) ||
                   Math.Pow(c, 2) + Math.Pow(a, 2) == Math.Pow(b, 2);
        }
    }
}
