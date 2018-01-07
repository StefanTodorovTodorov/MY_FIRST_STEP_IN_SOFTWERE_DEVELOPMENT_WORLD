using System;

class ChristmasTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        for (int row = 0; row <= n; row++)
        {
            Console.Write(new string(' ',n-row)+new string('*',row));
            Console.Write(" | ");
            Console.WriteLine(new string('*',row));            
        }
    }
}