/*Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure 
(heightwidth for rectangle and heightwidth/2 for triangle).
Define class Square and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method.
Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Square, Rectangle, Triangle) stored in an array.*/
namespace Shapes
{
    using System;
    
    class RunShapes
    {
        static void Main()
        {
            var shapes = new Shape[] 
                {
                    new Triangle(4,5),
                    new Triangle(56.7,33.45),
                    new Triangle(14,7),
                    new Rectangle(10,6),
                    new Rectangle(12.36,8.9),
                    new Rectangle (3,3),
                    new Square (5),
                    new Square(7.3),
                    new Square(36.9)
                };

            foreach (var shape in shapes)
            {
                Console.WriteLine("{0}, Surface: {1}", shape.GetType(), shape.CalculateSurface());
            }
        }
    }
}
