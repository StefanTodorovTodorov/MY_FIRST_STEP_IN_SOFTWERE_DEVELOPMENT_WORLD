using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopNumber
{
    class StopNumber
    {
        static void Main(string[] args)
        {
            int minNum = int.Parse(Console.ReadLine());
            int maxNum = int.Parse(Console.ReadLine());
            int stopNum = int.Parse(Console.ReadLine());

            for (int i = maxNum; i >= minNum; i--)
            {
                if (i%2==0 && i%3==0)
                {
                    if (i==stopNum)
                    {
                        break;
                    }
                    else
                    {
                        if (i!=minNum)
                        {
                            Console.Write($"{i} ");
                        }
                        else
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
        }
    }
}