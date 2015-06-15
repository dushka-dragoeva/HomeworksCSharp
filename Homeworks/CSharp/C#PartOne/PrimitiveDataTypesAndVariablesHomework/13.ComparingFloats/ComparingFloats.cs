using System;

class ComparingFloats
{
    static void Main()
    {
        //13.* Comparing Floats
        //Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
        double a = 5.3;
        double b = 6.01;
        double eps = 0.000001;
        string result = " The difference is\t";
        // Сравнявам абсолютната стойност на раликата между а и b със стойността за точност
        // Логически може и да се сравни така bool Name = (((a - b) < eps) && ((a - b) > -eps));
        bool c =((Math.Abs(a-b)<eps));
        Console.WriteLine( c+ result + Math.Abs(a-b));
        a = 5.00000001;
        b = 5.00000003;
        bool d = ((Math.Abs(a-b)<eps));
        Console.WriteLine(d + result + Math.Abs(a - b));
        a = 5.00000005;
        b = 5.00000001;
        bool e = ((Math.Abs(a - b) < eps));
        Console.WriteLine(e + result + Math.Abs(a - b));
        a = -0.00000007;
        b = 0.00000007;
        bool f = ((Math.Abs(a - b) < eps));
        Console.WriteLine(f + result + Math.Abs(a - b)); ;
        a = -4.999999;
        b = -4.999998;
        bool g = ((Math.Abs(a - b) < eps));
        Console.WriteLine(g + result + Math.Abs(a - b)); ;
        a = 4.999999;
        b = 4.999998;
        bool h = ((Math.Abs(a - b) < eps));
        Console.WriteLine(h + result + Math.Abs(a - b));
    }
}