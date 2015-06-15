using System;
using System.Threading;
using System.Globalization;

class GravitationOnTheMoon
{
    static void Main()
    {
        // 02. The gravitational field of the Moon is approximately 17% of that on the Earth.
        //Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
        
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Please, enter your weight:");
        double weight = Convert.ToDouble(Console.ReadLine());
        double moonGravity =0.17;
        double weightOnTheMoon = weight*moonGravity;
        Console.WriteLine("Your weight on the moon is {0} ", weightOnTheMoon);
    }
}