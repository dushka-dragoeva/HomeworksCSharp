using System;

class Trapezoidas
{
    static void Main()
    {
        //09. Write an expression that calculates trapezoid's area by given sides a and b and height h

        Console.Write("Please enter side a =  ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter side b =  ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter = height h ");
        double h = double.Parse(Console.ReadLine());
        double area = (a + b) * h / 2;
        string d = "The trapezoid's area is ";
        Console.WriteLine(d + area);
    }
}