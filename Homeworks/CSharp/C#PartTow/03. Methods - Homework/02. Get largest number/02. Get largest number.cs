using System;

class GetLargestNumber
{
    /*•	Write a method GetMax() with two parameters that returns the larger of two integers.
      •	Write a program that reads 3 integers from the console and prints the largest of 
     * them using the method GetMax(). */
    static void Main()
    {
        Console.WriteLine("Enter 3 integers");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        Console.WriteLine("The largest number is: " + GetMax(GetMax(num1, num2), num3));
    }
    static int GetMax(int numA, int numB)
    {
        if (numA > numB)
        {
            return numA;
        }
        else
        {
            return numB;
        }
    }
    
}

