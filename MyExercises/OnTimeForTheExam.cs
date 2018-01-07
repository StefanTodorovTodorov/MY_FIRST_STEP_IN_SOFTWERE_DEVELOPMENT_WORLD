using System;
using System.Globalization;


class OnTimeForTheExam
{
    static void Main()
    {
        int testHour = int.Parse(Console.ReadLine());
        int testMunute = int.Parse(Console.ReadLine());
        int departHour = int.Parse(Console.ReadLine());
        int departMunute = int.Parse(Console.ReadLine());

        int totalTimeMinutes = Math.Abs((testHour*60+testMunute)-(departHour*60+departMunute));

        DateTime testTime = DateTime.ParseExact($"{testHour}:{testMunute}","H:m",CultureInfo.CurrentCulture);
        DateTime departTime = DateTime.ParseExact($"{departHour}:{departMunute}","H:m",CultureInfo.CurrentCulture);

        if (departTime <= testTime)
        {
            if (totalTimeMinutes>0 && totalTimeMinutes<=30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{totalTimeMinutes} minutes before the start");
            }
            else if (totalTimeMinutes>30 && totalTimeMinutes <60)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{totalTimeMinutes} minutes before the start");
            }
            else if (totalTimeMinutes>=60)
            {
                int min = totalTimeMinutes % 60;
                int hour = (totalTimeMinutes - min) / 60;
                Console.WriteLine("Early");
                Console.WriteLine($"{hour}:{min:d2} hours before the start");
            }
            else if (totalTimeMinutes==0)
            {
                Console.WriteLine("On time");
            }
        }
        else if (departTime > testTime)
        {
            if (totalTimeMinutes >= 0 && totalTimeMinutes < 60)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{totalTimeMinutes} minutes after the start");
            }
            else if (totalTimeMinutes >= 60)
            {
                int min = totalTimeMinutes % 60;
                int hour = (totalTimeMinutes - min) / 60;
                Console.WriteLine("late");
                Console.WriteLine($"{hour}:{min:d2} hours after the start");
            }
        }
    }
}