using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects_3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Fraction frac = new Fraction(10, 100);
            frac.Display();
        }




        class Fraction
        {
            private int dividend;
            private int divisor;

            public Fraction(int d1, int d2)
            {
                dividend = d1;
                divisor = d2;
            }

            public void Display()
            {
                Console.WriteLine(dividend + "/" + divisor);
            }






        }
    }
}