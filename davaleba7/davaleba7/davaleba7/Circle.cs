using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba7
{
    class Circle : Shape
    {
        private double radius;

        public Circle(double circleRadius)
        {
            radius = circleRadius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
