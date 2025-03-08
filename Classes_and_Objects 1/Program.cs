
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trip myTrip = new Trip(" Paris",67, 40, 17);
            myTrip.DisplayTripInfo();
        }
    }
}
