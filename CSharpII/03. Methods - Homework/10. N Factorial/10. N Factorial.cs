using System;
using System.Linq;
using System.Numerics;

class NFactorial
{
    static void Main()
    {
        //•	Write a program to calculate n! for each n in the range [1..100].
        //Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.


       for(int i =1;i<=100;i++)
       {
           Console.WriteLine(" fakturiel {0,4} = {1}", i, Facturiel(i));
       }

    }
    static BigInteger Facturiel(int number)
    {
        BigInteger facturiel=1;
        for(int i =1;i<=number;i++)
        {
             facturiel *= i;
        }
        return facturiel;
    }
}
