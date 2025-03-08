using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MealCard myCard = new MealCard("Alice ");
            myCard.DisplayBalance();
            myCard.Purchase(70);
            myCard.AddPoints(80);
            myCard.Purchase(90);
        }
    }
}
