namespace RefactorTheFollowingLoop
{
    using System;

   public class Program
    {
        public const int DIVIDER = 10;

        public static void Main(string[] args)
        {
            int[] array = new int[100];
            int expectedValue = 33;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                if (IsDivisableWithoutReminder(i, DIVIDER) && IsExpectedValue(array[i], expectedValue))
                {
                    Console.WriteLine("Value Found");
                    break;
                }
            }
        }

        public static bool IsDivisableWithoutReminder(int value, int divider)
        {
            bool hasReminder = true;

            if (value % divider == 0)
            {
                hasReminder = false;
            }

            return !hasReminder;
        }

        private static bool IsExpectedValue(int value, int expectedValue)
        {
            bool isExpectedValue = value == expectedValue;

            return isExpectedValue;
        }
    }
}
