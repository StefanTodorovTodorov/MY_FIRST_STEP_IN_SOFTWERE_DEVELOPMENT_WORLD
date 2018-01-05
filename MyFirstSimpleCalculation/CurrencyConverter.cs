using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CurrencyConverter
{
    static void Main()
    {
		/*Input currency value and name
		Input converting currency name
		Calculate new value
		Print new currency value and name (print value with 2 digits after comma)*/
		
        decimal usd = 1.79549m;
        decimal eur = 1.95583m;
        decimal gbp = 2.53405m;
        decimal currencyValueA = 0m;
        decimal currencyValueB = 0m;

        decimal value = decimal.Parse(Console.ReadLine());

        string nameCurrencyA = Console.ReadLine().ToUpper();
            if (nameCurrencyA == "BGN") 
			{
				currencyValueA = 1;
			}
            esle if (nameCurrencyA == "USD") 
			{
				currencyValueA = usd;
			}
            else if (nameCurrencyA == "EUR") 
			{
				currencyValueA = eur;
			}
            else if (nameCurrencyA == "GBP") 
			{
				currencyValueA = gbp;
			}

        string nameCurrencyB = Console.ReadLine().ToUpper();
            if (nameCurrencyB == "BGN") 
			{
				currencyValueB = 1;
			}
            else if (nameCurrencyB == "USD") 
			{
				currencyValueB = usd;
			}
            else if (nameCurrencyB == "EUR") 
			{
				currencyValueB = eur;
			}
            else if (nameCurrencyB == "GBP") 
			{
				currencyValueB = gbp;
			}

        decimal sum = (value * currencyValueA) / currencyValueB;

        Console.WriteLine($"{sum:f2} {nameCurrencyB}");
    }
}