using System;
using System.Globalization;
using System.Threading;

class Rectangles
{
    static void Main()
    {
        //04. Write an expression that calculates rectangle’s perimeter and area by given width and height.
        
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter width:  ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        double height = double.Parse(Console.ReadLine());
        double perimeter = 2 * (width + height);
        double area = width * height;
        Console.WriteLine("The perimeter is: {0,15}  \nThe area is : {1,19}", perimeter, area);
    }
}