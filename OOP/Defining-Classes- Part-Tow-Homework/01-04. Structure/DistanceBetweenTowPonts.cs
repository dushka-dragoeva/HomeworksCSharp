namespace _01_04.Structure
{
    using System;

    public static class DistanceBetweenTowPoints
    {
         public static double DistanceBetweenPoints(Point3D a, Point3D b)
         {
             double distance = Math.Sqrt((a.X - b.X) * (a.X - b.X)
                                        + (a.Y - b.Y) * (a.Y - b.Y)
                                        +(a.Z - b.Z) * (a.Z - b.Z));



                return distance;
         }
    }
}
