//Implement a set of extension methods for IEnumerable<T> that implement the 
//following group functions: sum, product, min, max, average.
namespace _02.IEnumerable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using _02.IEnumerable.Extentions;

    public static class IEnmerableExtentions
    {
        static void Main()
        {
            var test = new List<double> { 5.78, 6.32, 7,-95.3,16,-1 };

            Console.WriteLine("Sum: "+test.SumExt<double>());
            Console.WriteLine("Product: "+test.ProductExt<double>());
            Console.WriteLine("Avarage: " + test.AvarigeExt <double>());
            Console.WriteLine("Min: " + test.MinExt <double>()); 
            Console.WriteLine("Max: " + test.MaxExt<double>());
        }
    }
}
