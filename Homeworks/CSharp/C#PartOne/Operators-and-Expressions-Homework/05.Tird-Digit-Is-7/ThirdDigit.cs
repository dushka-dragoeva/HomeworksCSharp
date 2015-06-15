using System;

class ThirdDigit
{
    static void Main()
    {
        //05.Write an expression that checks for given integer if its third digit from right-to-left is 7
        Console.Write("Please enter an integer >99:  ");
        int number = int.Parse(Console.ReadLine());
        bool result = ((number/100) % 10 == 7);
        Console.WriteLine("Third digit is 7 -  "+result);     
    }
}