using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba6_2
{
    public static class Calculator
    {
        public static int Add(int a, int b)
        {
            return a+b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static decimal Divide(decimal a, decimal b)
        {
            if(b == 0)
            {
                throw new ArgumentException("0 ze gayofa ar sheidzleba");
            }

            return  a / b;
        }
    }
}
