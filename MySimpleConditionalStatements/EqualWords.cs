using System;


class EqualWords
{
    static void Main()
    {
		//Input 2 words and if they are equal print "yes" or not equal print "no"
		
        string wordA = Console.ReadLine().ToLower();
        string wordB = Console.ReadLine().ToLower();
        if (wordA==wordB )
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}