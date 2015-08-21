namespace Statistics
{
    using System;

    class PrintMain
    {
        static void Main()
        {
            double[] numbers = new double[] { 1.37, 2.98, 3.54, 4.75, 0.0, 18.2, -15.9, 120.4};
            var count = numbers.Length;
            Printer.PrintStatistics(numbers, count);
        }
    }
}
