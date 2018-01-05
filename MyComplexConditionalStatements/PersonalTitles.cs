using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PersonalTitles
{
    static void Main()
    {
        double age = double.Parse(Console.ReadLine());
        string sex = Console.ReadLine().ToLower();
        string titles = null;

        if (sex == "m")
        {
            if (age>=16)
            {
                titles = "Mr.";
            }
            else if (age < 16)
            {
                titles = "Master";
            }
        }
        else if (sex == "f")
        {
            if (age >= 16)
            {
                titles = "Ms.";
            }
            else if (age < 16)
            {
                titles = "Miss";
            }
        }
    Console.WriteLine(titles);
    }
}