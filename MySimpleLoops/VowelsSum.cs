using System;

class VowelsSum
{
    static void Main()
    {
		/* Input text
		Find all vowels in text and print sum of vowels*/
		
        string str = Console.ReadLine();
        int strLenght = str.Length;
        int sumVowels = 0;
        int vowels = 0;
        for (int i = 0; i < strLenght; i++)
        {
            switch (str[i])
            {
                case 'a':
                    vowels = 1;
                    break;
                case 'e':
                    vowels = 2;
                    break;
                case 'i':
                    vowels = 3;
                    break;
                case 'o':
                    vowels = 4;
                    break;
                case 'u':
                    vowels = 5;
                    break;
            }
            sumVowels += vowels;
            vowels = 0;
        }
        Console.WriteLine(sumVowels);
    }
}