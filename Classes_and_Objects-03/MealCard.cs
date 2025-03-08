using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects_03
{
    internal class MealCard
    {

        public string studentName;
        public int balance;
        public MealCard(string stdName, int points = 100)
        {

            this.studentName = stdName;
            this.balance = points;

        }
        public void AddPoints(int Points)
        {
            balance += Points;
            Console.WriteLine(Points + "points added.New balance : " + balance);
        }
        public void Purchase(int points)
        {
            if (balance >= points)
            {
                balance -= points;
                Console.WriteLine("Purchased has been done. Remaining balance is :  " + balance);
            }
            else
            {

            }
            Console.WriteLine("Points not enough for this purchase.");
        }
    
    public void DisplayBalance()
        {
            Console.WriteLine("Student:" + studentName + " , Balance : " + balance);
        }
    }
}
