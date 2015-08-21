namespace Assertions_Homework
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    internal class SearchAlgorithm
    {
        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            return BinarySearch(arr, value, 0, arr.Length - 1);
        }
        
        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array is null.");
            Debug.Assert(arr.Length > 0, "Array is empty.");

            Debug.Assert(value != null, "Searching value is null.");

            Debug.Assert(startIndex >= 0 && startIndex < arr.Length, "Invalid startIndex value.");
            Debug.Assert(endIndex >= 0 && endIndex < arr.Length, "Invalid endIndex value.");
            Debug.Assert(startIndex <= endIndex, "Start Index is greater than end index.");

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }

                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            // Searched value not found
            Debug.Assert(Helpers.HasValue(arr, value), "The array contains searched value, but method returns -1.");
            return -1;
        }
    }
}
