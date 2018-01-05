using System;

class Volleyball
{
    static void Main()
    {
		/*Input year type (leap or normal), holidays count, day in home town count
		Calculate how many times the boy play volleyball in an year and print the result*/
		
        string yearType = Console.ReadLine().ToLower();
        int holidays = int.Parse(Console.ReadLine());
        int dayInHomeTown = int.Parse(Console.ReadLine());
        double result = 0;

        if (yearType == "leap")
        {
            double saturdayGamesInSofia = (3.0/4);
            double holidayGamesInSofia = (2.0/3);
            double leapYear = 0.15;
            result = 48 - dayInHomeTown;
            result *= saturdayGamesInSofia;
            result = result+(holidays * holidayGamesInSofia);
            result += dayInHomeTown;
            result = Math.Floor( result + (result * leapYear));
        }
        else if (yearType == "normal")
        {
            double saturdayGamesInSofia = (3.0/4);
            double holidayGamesInSofia = (2.0/3);
            result = 48 - dayInHomeTown;
            result *= saturdayGamesInSofia;
            result = result + (holidays * holidayGamesInSofia);
            result +=dayInHomeTown;
            result = Math.Floor(result);
        }
        Console.WriteLine(result);
    }
}