using System;
using System.Globalization;
using System.Threading;

class PointInACircle
{
    static void Main()
    {
        //07.Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2)

        Thread.CurrentThread.CurrentCulture =  CultureInfo.InvariantCulture;
        Console.Write("Please enter x =  ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Please enter y =  ");
        double y = double.Parse(Console.ReadLine());
        bool check =((x*x)+(y*y)<=(2*2));
        Console.WriteLine("The Point is incide the circle  -  "+check);
    }
}