using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Triangle
    {
        public double Side1 { get; private set; }
        public double Side2 { get; private set; }
        public double Side3 { get; private set; }

        public Triangle(double side1, double side2, double side3)
        {
            if (IsValidTriangle(side1, side2, side3))
            {
                Side1 = side1;
                Side2 = side2;
                Side3 = side3;
            }
            else
            {
                throw new ArgumentException("nebismieri ori gverdis jami meti unda iyos mesameze!");
            }
        }

        public double GetArea()
        {
            double s = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
        }

        public double GetPerimeter()
        {
            return Side1 + Side2 + Side3;
        }

        public static bool operator ==(Triangle t1, Triangle t2)
        {
            return Math.Abs(t1.GetArea() - t2.GetArea()) < double.Epsilon;
        }

        public static bool operator !=(Triangle t1, Triangle t2)
        {
            return !(t1 == t2);
        }

        public static bool operator >(Triangle t1, Triangle t2)
        {
            return t1.GetArea() > t2.GetArea();
        }

        public static bool operator <(Triangle t1, Triangle t2)
        {
            return t1.GetArea() < t2.GetArea();
        }

        public static Triangle operator +(Triangle t1, Triangle t2)
        {
            double newSide1 = Math.Sqrt(t1.Side1 * t1.Side1 + t2.Side1 * t2.Side1);
            double newSide2 = Math.Sqrt(t1.Side2 * t1.Side2 + t2.Side2 * t2.Side2);
            double newSide3 = Math.Sqrt(newSide1 * newSide1 + newSide2 * newSide2); 
            return new Triangle(newSide1, newSide2, newSide3);
        }

        public static explicit operator Triangle(double area)
        {
            double side1 = Math.Sqrt((2 * area) / Math.Sqrt(3));
            double side2 = side1;
            double side3 = side1 * Math.Sqrt(3);
            return new Triangle(side1, side2, side3);
        }

        private static bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}
