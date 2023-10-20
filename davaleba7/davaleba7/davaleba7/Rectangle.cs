using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba7
{
    class Rectangle : Shape
    {
        private double length, width;

        public Rectangle(double sideLength, double sideWidth)
        {
            length = sideLength;
            width = sideWidth;
        }

        public override double GetArea()
        {
            return length * width;
        }

        public override double GetPerimeter()
        {
            return 2 * (length + width);
        }
    }

}
