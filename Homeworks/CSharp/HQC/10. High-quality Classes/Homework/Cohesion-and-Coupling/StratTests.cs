namespace CohesionAndCoupling
{
    using System;

   public class StratTests
    {
       public static void Main()
        {
            // throw ArgumentException
            // Console.WriteLine(GetFileName.GetFileExtension("example"));
            Console.WriteLine(GetFileName.GetFileExtension("example.pdf"));
            Console.WriteLine(GetFileName.GetFileExtension("example.new.pdf"));

            // throw ArgumentException
            // Console.WriteLine(GetFileName.GetFileNameWithoutExtension("example"));
            Console.WriteLine(GetFileName.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(GetFileName.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine(
                "Distance in the 2D space = {0:f2}",
                DistanceCalculations.CalculateDistance2D(1, -2, 3, 4));
            Console.WriteLine(
                "Distance in the 3D space = {0:f2}",
                DistanceCalculations.CalculateDistance3D(5, 2, -1, 3, -6, 4));
           
            var parallelepiped = new Parallelepiped(3, 4, 5);
          
            Console.WriteLine("Volume = {0:f2}", parallelepiped.CalculateVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", parallelepiped.CalculateDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}",    parallelepiped.CalculateDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", parallelepiped.CalculateDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", parallelepiped.CalculateDiagonalYZ());
            Console.Read();
        }
    }
}
