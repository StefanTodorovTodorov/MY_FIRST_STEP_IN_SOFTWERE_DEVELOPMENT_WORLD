using System;

namespace SumSeconds
{
    class SumSeconds
    {
        static void Main()
        {
			//Input 3 competitors times (in seconds), calculate Total times in minutes and print it
			
            int secondsA = int.Parse(Console.ReadLine());
            int secondsB = int.Parse(Console.ReadLine());
            int secondsC = int.Parse(Console.ReadLine());
            int totalSeconds = secondsA + secondsB + secondsC;
            int seconds = totalSeconds % 60;
            int totalMinutes = (totalSeconds - seconds) / 60;
            if (seconds < 10)
            {
                Console.WriteLine($"{totalMinutes}:0{seconds}");

            }
            else
            {
                Console.WriteLine($"{totalMinutes}:{seconds}");
            }
        }
    }
}