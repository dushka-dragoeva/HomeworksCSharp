using System;
using System.Linq;
class NumberCalculations
{
    /*•	Modify your last program and try to make it work for any number type, not just integer 
     * (e.g. decimal, float, byte, etc.)
      •	Use generic method (read in Internet about generic methods in C#).*/

    static void Main(string[] args)
    {
        Console.WriteLine("Average: {0}", GetAverage(12, 32, 443, 3.3, -98));
        Console.WriteLine("Max: {0}", GetMax(1, 2.5m, 3, 4.4m));
        Console.WriteLine("Min: {0}", GetMin(981, 362, 143, 78.369));
        Console.WriteLine("Product: {0}", GetProduct(1,487,-963.23,-79));
        Console.WriteLine("Sum: {0}", GetSum(121.564, 2.36, 453, 4));
    }
    static K GetMin<K>(params K[] numbers) where K : IComparable<K>
    {
        int minIndex = 0;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i].CompareTo(numbers[minIndex]) == -1) minIndex = i;
        }
        return numbers[minIndex];
    }

    static K GetMax<K>(params K[] numbers) where K : IComparable<K>
    {
        int maxIndex = 0;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i].CompareTo(numbers[maxIndex]) == 1) maxIndex = i;
        }
        return numbers[maxIndex];
    }

    static K GetSum<K>(params K[] numbers) where K : IComparable<K>
    {
        return numbers.Aggregate<K, dynamic>(0, (current, t) => current + t);
    }

    static K GetAverage<K>(params K[] numbers) where K : IComparable<K>
    {
        dynamic averageSum = numbers.Aggregate<K, dynamic>(0, (current, t) => current + t);
        return averageSum / numbers.Length;
    }

    static K GetProduct<K>(params K[] numbers) where K : IComparable<K>
    {
        return numbers.Aggregate<K, dynamic>(1, (current, t) => current * t);
    }
}