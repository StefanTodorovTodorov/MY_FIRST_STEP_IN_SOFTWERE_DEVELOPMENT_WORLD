using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1000DaysAfterBirth
{
    class Program
    {
        static void Main()
        {
			//input date, add 1000 days after that  print new date
			
            CultureInfo culture = CultureInfo.CurrentCulture;
            string inputDate = Console.ReadLine();
            var date = DateTime.ParseExact(inputDate, "dd-MM-yyyy",culture );
            date = date.AddDays(999);
            Console.WriteLine(date.ToString("dd-MM-yyyy",culture));
        }
    }
}