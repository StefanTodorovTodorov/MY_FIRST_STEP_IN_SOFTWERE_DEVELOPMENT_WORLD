using System;

class StupidPasswordGenerator
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());
        string chars = "abcdefghi";

        if ((n >= 1 && n <= 9) && (l >= 1 && l <= 9))
        {
            for (int s1 = 1; s1 < n; s1++)
            {
                for (int s2 = 1; s2 < n; s2++)
                {
                    for (int l1 = 0; l1 < l; l1++)
                    {
                        for (int l2 = 0; l2 < l; l2++)
                        {
                            for (int s3 = 1; s3 <= n; s3++)
                            {
                                if (s3 > s1 && s3 > s2)
                                {
                                    Console.Write($"{s1}{s2}{chars[l1]}{chars[l2]}{s3} ");
                                }
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine();
    }
}