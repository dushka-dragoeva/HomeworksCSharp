using System;
using System.Text;

class UnicodeCharacter
{
    static void Main()
    {
        //4. Unicode Character
        //Declare a character variable and assign it with the symbol that has
        // Unicode code 42 (decimal) using the \u00XX syntax, and then print it.
        Console.OutputEncoding = Encoding.Unicode;
        int DecimalNum = 42;
        char Symbol = '\u002A';
        Console.WriteLine("The Symbol of Decimal {0} is {1}", DecimalNum, Symbol);
        }
}