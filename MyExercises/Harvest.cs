using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Harvest
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            int workPeople = int.Parse(Console.ReadLine());
            

            double wine = ((x * y)*0.40)/2.5;
            double totalWine = Math.Abs(wine-z);
            if (wine<z)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor( totalWine)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(totalWine)} liters left -> {Math.Ceiling(totalWine / workPeople)} liters per person.");
            }
        }
    }
}