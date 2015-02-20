using System;

class FourDigitNumber
{
    static void Main(string[] args)
    {
        //06. Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
        //Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
        //Prints on the console the number in reversed order: dcba (in our example 1102).
        //Puts the last digit in the first position: dabc (in our example 1201).
        //Exchanges the second and the third digits: acbd (in our example 2101)

        Console.Write("Please enter four-digit number:   ");
        int fourDigitNumber = int.Parse(Console.ReadLine());
        while (fourDigitNumber < 1000 || fourDigitNumber > 9999)
        {
            Console.Write("ERROR! Enter fout-digit number:   ");
            fourDigitNumber = int.Parse(Console.ReadLine());
        }
        int d = fourDigitNumber % 10;
        int c = (fourDigitNumber / 10) % 10;
        int b = (fourDigitNumber / 100) % 10;
        int a = (fourDigitNumber / 1000) % 10;
        Console.WriteLine("Sum of digits \t\t\t    " + (a + b + c + d));
        Console.WriteLine("Reversed \t\t\t  {3}{2}{1}{0} \nLast digit in front\t\t  {3}{0}{1}{2} \nSecond and third digits exchanged {0}{2}{1}{3}", a, b, c, d);
    }
}