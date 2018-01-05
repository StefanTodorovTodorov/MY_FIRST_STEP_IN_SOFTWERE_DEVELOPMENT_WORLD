using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BonusScore
{
    static void Main()
    {
		/*Input real number
		If then number is equal or less than 100, add 5 bonus points.
		If number is greater then 100, add 20% bonus pints.
		If number is greater then 1000, add 10% bonus points.
		If the number is even add 1 points bonus
		if the number end of 5 add 5 points bonus
		Find and calculate all options and print the result*/
		
        double n = double.Parse(Console.ReadLine());
        double result = 0;
        if (n <= 100)
        {
            result += 5; //add 5 points
        }
        else if (n > 100 && n <= 1000)
        {
            result += n * 0.2d; //add 20%
        }
        else if (n > 1000)
        {
            result += n * 0.1d;//add 10%
        }

        if (n % 2 == 0)
        {
            result++;
        }
        if (n % 10 == 5)
        {
            result += 2;
        }
        Console.WriteLine(result);
        Console.WriteLine(n += result);
    }
}