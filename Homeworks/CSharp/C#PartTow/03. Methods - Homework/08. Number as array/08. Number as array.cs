using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class NumberAsArray
{
    static void Main()
    {
        //•	Write a method that adds two positive integer numbers represented as arrays of digits 
        //  (each array element arr[i]contains a digit; the last digit is kept in arr[0]).
        //•	Each of the numbers that will be added could have up to 10 000 digits.
        int[] firstArr = Enumerable.Repeat(3,10000).ToArray() ;
        int[] secondArr = Enumerable.Repeat(2, 10000).ToArray();
        
        Console.WriteLine("The sum is: "+ SumNumsAsArr(firstArr,secondArr ) );
    }
    static BigInteger SumNumsAsArr(int [] arrA, int [] arrB)
    {
        BigInteger a= BigInteger.Parse ( String
            .Join(string.Empty, new List<int>(arrA)
            .ConvertAll(i => i.ToString())
            .ToArray()
            .Reverse()));
        BigInteger b = BigInteger.Parse(String
            .Join(string.Empty, new List<int>(arrB)
            .ConvertAll(i => i.ToString())
            .ToArray()
            .Reverse()));
        BigInteger result = a + b;
        return result;
    }
}