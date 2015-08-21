namespace Statistics
{
    using System;

    public class Printer
    {
        public static void PrintStatistics(double[] arr, int count)
        {
            double max = 0;
            for (int i = 0; i < count; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine(max);

            double min = 0;
            for (int i = 0; i < count; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine(min);

            double sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine(sum/count);
        }
    }
}
