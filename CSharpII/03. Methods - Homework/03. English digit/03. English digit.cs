using System;

class EnglishDigit
{
    //•	Write a method that returns the last digit of given integer as an English word.
    
    static String LastDigit (int number)
    {
        string result = string.Empty;
        int digit = number % 10;
        switch (digit)
        {
            case 0: result = "zero"; break;
            case 1: result = "one"; break;
            case 2: result = "tow"; break;
            case 3: result = "three"; break;
            case 4: result = "four"; break;
            case 5: result = "five"; break;
            case 6: result = "six"; break;
            case 7: result = "seven"; break;
            case 8: result = "eight"; break;
            case 9: result = "nine"; break;
        }
        return result;
    }
    static void Main()
    {
        Console.Write( "Enter an Integer: ");
        Console.WriteLine("The last digit is "+LastDigit(int.Parse(Console.ReadLine())));
    }
}
