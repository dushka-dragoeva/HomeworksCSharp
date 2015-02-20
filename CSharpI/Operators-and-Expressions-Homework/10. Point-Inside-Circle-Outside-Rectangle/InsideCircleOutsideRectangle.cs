using System;
using System.Globalization;
using System.Threading;

class InsideCircleOutsideRectangle
{
    static void Main()
    {
        //Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
        //and out of the rectangle R(top=1, left=-1, width=6, height=2).
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Please enter x =  ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Please enter y =  ");
        double y = double.Parse(Console.ReadLine());
        bool check = ((((x - 1) * (x - 1)) + ((y - 1) * (y - 1))) <= (1.5 * 1.5)) && (y > 1);
        Console.Write("The Point is incide the circle and out of the rectangle -   ");
        Console.WriteLine(check==true?"Yes":"No");
    }
}