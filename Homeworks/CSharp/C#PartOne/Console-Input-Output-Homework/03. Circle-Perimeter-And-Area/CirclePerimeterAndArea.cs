using System;
using System.Globalization;
using System.Threading;

class CirclePerimeterAndArea
{
    static void Main(string[] args)
    {
        //03 Write a program that reads the radius r of a circle and prints its 
        //perimeter and area formatted with 2 digits after the decimal point

        Thread.CurrentThread.CurrentCulture =CultureInfo.InvariantCulture;
        Console.Write("Please enter radius:  ");
        double radius = Convert.ToDouble(Console.ReadLine());
        double perimeter = 2 *Math.PI* radius;
        double area = Math.PI * radius * radius;
        Console.WriteLine("The perimeter is{0,15:0.00} \nThe area is{1,20:0.00}  ", perimeter, area);
    }
}