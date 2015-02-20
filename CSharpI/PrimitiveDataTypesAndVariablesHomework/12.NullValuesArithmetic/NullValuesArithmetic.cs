using System;

class NullValuesArithmetic
{
    static void Main()
    {
        //12. Null Values Arithmetic
        //Create a program that assigns null values to an integer and to a double variable.
        //Try to print these variables at the console.
        //Try to add some number or the null literal to these variables and print the result.
        int? A =null;
        double? B= null;
        Console.WriteLine(A);
        Console.WriteLine(B);
        Console.WriteLine(A+0);
        Console.WriteLine(B+5.75);
        A = 0;
        B = 5.75;
        Console.WriteLine(A);
        Console.WriteLine(B);
    }
}
