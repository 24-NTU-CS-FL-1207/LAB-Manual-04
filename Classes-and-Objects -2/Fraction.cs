using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects__2
{
    internal class Fraction
    {
        public int dividend;
        public int divisor;
         public Fraction(int dividend1, int divisor1)
        {
            this.dividend = dividend1;
            this.divisor = divisor1;
        }

        public void Display()
        {
            Console.WriteLine(dividend + "/" + divisor);
        }
    }
}
