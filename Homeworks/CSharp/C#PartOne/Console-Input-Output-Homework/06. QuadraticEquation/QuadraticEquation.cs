using System;
using System.Globalization;
using System.Threading;

class QuadraticEquation
{
    static void Main(string[] args)
    {
        //06. Write a program that reads the coefficients a, b and c of a quadratic 
        //equation ax2 + bx + c = 0 and solves it (prints its real roots).
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please enter first number:      ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter second number:     ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter third number:      ");
        double c = double.Parse(Console.ReadLine());
        //с Math.Pow(а,n) - можем да повдигаме числа на степен
        double discriminant = Math.Pow(b, 2) - 4 * a * c;
        if (discriminant < 0)
        {
            Console.WriteLine("no real roots");
        }

        else if (discriminant == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("x1 = x2 = {0}", x);
        }
        else
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("The roots are x1={0}, x2={1})", x1, x2);
        }
    }
}
