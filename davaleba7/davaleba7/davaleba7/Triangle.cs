using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba7
{
    class Triangle : Shape
    {
        private double a, b, c;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (IsValidTriangle(sideA, sideB, sideC))
            {
                a = sideA;
                b = sideB;
                c = sideC;
            }
            else
            {
                throw new ArgumentException("ori gverdis jami mesameze meti unda iyos");
            }
        }

        public override double GetArea()
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public override double GetPerimeter()
        {
            return a + b + c;
        }

        private static bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}

