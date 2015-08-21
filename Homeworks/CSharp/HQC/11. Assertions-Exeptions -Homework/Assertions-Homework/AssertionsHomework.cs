// Add assertions in the code from the project Assertions-Homework to ensure all possible preconditions and postconditions are checked.
namespace Assertions_Homework
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    public class AssertionsHomework
    {
        public static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };

            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            SortAlgorithm.SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            SortAlgorithm.SelectionSort(new int[0]); // Test sorting empty array
            SortAlgorithm.SelectionSort(new int[1]); // Test sorting single element array

            Console.WriteLine(SearchAlgorithm.BinarySearch(arr, -1000));
            Console.WriteLine(SearchAlgorithm.BinarySearch(arr, 0));
            Console.WriteLine(SearchAlgorithm.BinarySearch(arr, 17));
            Console.WriteLine(SearchAlgorithm.BinarySearch(arr, 10));
            Console.WriteLine(SearchAlgorithm.BinarySearch(arr, 1000));
            Console.Read();
        }
    }
}