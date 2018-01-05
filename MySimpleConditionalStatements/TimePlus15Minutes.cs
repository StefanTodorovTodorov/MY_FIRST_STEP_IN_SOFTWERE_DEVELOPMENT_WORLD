using System;

class TimePlus15Minutes
{
    static void Main()
    {
		/*Input hour and minutes. Add 15 minutes and print new time in hours and minutes
		Minutes must be print in 2 digits format*/
		
        int hour =int.Parse(Console.ReadLine());
        int minutes =int.Parse(Console.ReadLine());
        int time = (hour * 60) + minutes+15;
        minutes = time % 60;
        hour = (time - minutes) / 60;
        if (hour==24)
        {
            hour = 0;
        }
        Console.WriteLine($"{hour}:{minutes:00}");
    }
}