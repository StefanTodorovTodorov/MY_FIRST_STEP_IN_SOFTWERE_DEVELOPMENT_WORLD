using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersCombinations
{
    class LettersCombinations
    {
        static void Main(string[] args)
        {
            char chA = char.Parse(Console.ReadLine());
            char chB = char.Parse(Console.ReadLine());
            char chC = char.Parse(Console.ReadLine());
            int count = 0;

            for (char c1 = chA; c1 <= chB; c1++)
            {
                for (char c2 = chA; c2 <= chB; c2++)
                {
                    for (char c3 = chA; c3 <= chB; c3++)
                    {
                        if (c1!=chC && c2!=chC && c3 != chC )
                        {
                            Console.Write($"{c1}{c2}{c3} ");
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
