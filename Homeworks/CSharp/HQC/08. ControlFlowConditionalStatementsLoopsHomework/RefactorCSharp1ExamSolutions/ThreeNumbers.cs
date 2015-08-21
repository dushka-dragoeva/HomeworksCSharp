namespace RefactorCSharp1ExamSolutions
{
    using System;

    public class ThreeNumbers
    {
        public static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());

            double tempMaxNum = MaxTowNumbers(firstNum, secondNum);
            double maxNum = MaxTowNumbers(tempMaxNum, thirdNum);

            double tempMinNum = MinTowNumbers(firstNum, secondNum);
            double minNum = MinTowNumbers(tempMinNum, thirdNum);
            double mean = MeanThreeNumbers(firstNum, secondNum, thirdNum);

            Console.WriteLine(maxNum);
            Console.WriteLine(minNum);
            Console.WriteLine("{0:F2}", mean);
            Console.ReadLine();
        }

        private static double MaxTowNumbers(double firstNumber, double secondNumber)
        {
            double maxNum = firstNumber;
            if (maxNum < secondNumber)
            {
                maxNum = secondNumber;
            }

            return maxNum;
        }

        private static double MinTowNumbers(double firstNumber, double secondNumber)
        {
            double minNum = firstNumber;
            if (minNum > secondNumber)
            {
                minNum = secondNumber;
            }

            return minNum;
        }

        private static double MeanThreeNumbers(double firstNumber, double secondNumber, double thirdnumber)
        {
            int divider = 3;
            double mean = (firstNumber + secondNumber + thirdnumber) / divider;
            return mean;
        }
    }
}
