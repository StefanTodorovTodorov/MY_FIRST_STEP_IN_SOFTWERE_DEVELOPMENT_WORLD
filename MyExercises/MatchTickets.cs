using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets
{
    class MatchTickets
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine().ToUpper();
            int group = int.Parse(Console.ReadLine());
            double percent = 0;
            double ticketPrice = 0;

            if (group>=1 && group<=4)
            {
                percent = 0.75;
            }
            else if (group >= 5 && group <= 9)
            {
                percent = 0.60;
            }
            else if (group >= 10 && group <= 24)
            {
                percent = 0.50;
            }
            else if (group >= 25 && group <= 49)
            {
                percent = 0.40;
            }
            else if (group >= 50)
            {
                percent = 0.25;
            }

            double residue = budget - (budget * percent);

            switch (category)
            {
                case "NORMAL":
                    ticketPrice = 249.99 * group;
                    break;
                case "VIP":
                    ticketPrice = 499.99 * group;
                    break;
                default:
                    break;
            }

            if (residue>=ticketPrice)
            {
                residue = residue - ticketPrice;
                Console.WriteLine($"Yes! You have {residue:f2} leva left.");
            }
            else
            {
                residue = ticketPrice - residue;
                Console.WriteLine($"Not enough money! You need {residue:f2} leva.");
            }
        }
    }
}