using System;

class ExchangeVariableValues
{
    static void Main()
    {
        //9. Exchange Variable Values
        //Declare two integer variables a and b and assign them with 5 and 10 and after 
        //that exchange their values by using some programming logic.
        //Print the variable values before and after the exchange.
        int A = 5;
        int B = 10;
        Console.WriteLine("Before {0}, {1}", A, B);
        int C = A;
        A = B;
        B=C;
        Console.WriteLine("After {0}, {1}", A, B);
    }
}

