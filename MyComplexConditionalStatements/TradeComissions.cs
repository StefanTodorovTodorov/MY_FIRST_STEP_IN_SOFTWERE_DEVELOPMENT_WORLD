using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TradeComissions
{
    static void Main()
    {

        string city = Console.ReadLine().ToUpper();
        double sales = double.Parse(Console.ReadLine());

        bool isTrue = (city == "SOFIA" || city == "VARNA" || city == "PLOVDIV") && sales >=0;

        if (isTrue)
        {
            if (city == "SOFIA")
            {
                if (sales >= 0 && sales <= 500)
                {
                    sales *= 0.05;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    sales *= 0.07;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    sales *= 0.08;
                }
                else if (sales > 10000)
                {
                    sales *= 0.12;
                }
            }
            if (city == "VARNA")
            {
                if (sales >= 0 && sales <= 500)
                {
                    sales *= 0.045;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    sales *= 0.075;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    sales *= 0.10;
                }
                else if (sales > 10000)
                {
                    sales *= 0.13;
                }
            }
            if (city == "PLOVDIV")
            {
                if (sales >= 0 && sales <= 500)
                {
                    sales *= 0.055;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    sales *= 0.08;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    sales *= 0.12;
                }
                else if (sales > 10000)
                {
                    sales *= 0.145;
                }
            }
            Console.WriteLine($"{sales:f2}");
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}