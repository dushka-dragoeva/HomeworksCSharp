using System;

class FloatOrDouble
{
    static void Main()
    {
        //2. Float or Double?
        //Which of the following values can be assigned to a variable of type float and which to a variable 
        //of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
        //Write a program to assign the numbers in variables and print them to ensure no precision is lost..
        
        double A = 34.567839023;
        float B = 12.345f;
        double C = 8923.1234857;
        float D = 3456.091f;
        Console.WriteLine("This is double {0}", A);
        Console.WriteLine("This is float {0}", B);
        Console.WriteLine("This is double {0}", C);
        Console.WriteLine("This is float {0}", D);
    }
}