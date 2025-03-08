using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects_1
{
    internal class Trip
    {
        public string destination;
        public double distanceTraveled;
        public double totalCost;
        public double noOFGallons;
        public Trip(string dest, double distTraveled, double cost, double gallons)
        {
            this.destination = dest;
            this.distanceTraveled = distTraveled;
            this.totalCost = cost;
            this.noOFGallons = gallons;
        }
        public double MilesPerGallon()
        
        {
            return distanceTraveled / noOFGallons;

        }
        public double CostPerMile()
        {
            return totalCost / distanceTraveled;

        }
        public void DisplayTripInfo()
        {
            Console.WriteLine($"Destination:  {destination}");
            Console.WriteLine($"MilesPerGallon: {MilesPerGallon()}");
            Console.WriteLine($"Cost Per Gallon: { CostPerMile()}");

        }

    }
}
