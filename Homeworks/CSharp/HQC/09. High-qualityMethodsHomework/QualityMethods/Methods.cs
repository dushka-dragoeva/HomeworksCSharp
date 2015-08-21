namespace QualityMethods
{
    using System;

    /// <summary>
    /// Take the VS solution Methods and refactor its code to follow the guidelines of high-quality methods.
    /// Ensure:
    /// you handle errors correctly
    /// when the methods cannot do what their name says, throw an exception (do not return wrong result).
    /// good cohesion and coupling
    /// good naming
    /// no side effects, etc.
    /// </summary>
    internal class Methods
    {
        internal static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Sides should be positive numbers.");
            }

            if ((a + b) < c || (a + c) < b || (a + b) < c)
            {
                throw new ArgumentOutOfRangeException("The sum ot 2 sides must be greater than third side");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        internal static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
            }

            throw new ArgumentOutOfRangeException("The number must be between 0 and 9 includinng!");
        }

        internal static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("The array cann't be empty!");
            }

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > elements[0])
                {
                    elements[0] = elements[i];
                }
            }

            return elements[0];
        }

        internal static void PrintFormatWithPrecision(double number)
        {
            Console.WriteLine("{0:f2}", number);
        }

        internal static void PrintNumberAsPersentige(double number)
        {
            Console.WriteLine("{0:p0}", number);
        }

        internal static void PrintnumberAlignedRight(double number)
        {
            Console.WriteLine("{0,8}", number);
        }

        internal static double CalculateDistance(
            double firstPointX,
            double firstPointY,
            double secondPointX,
            double secondPointY)
        {
            double distance = Math.Sqrt(((secondPointX - firstPointX) * (secondPointX - firstPointX))
                                        + ((secondPointY - firstPointY) * (secondPointY - firstPointY)));
            return distance;
        }

        internal static bool IsLineHorizontal(double firstPointY, double secondPointY)
        {
            bool isHorizontal = firstPointY == secondPointY;
            return isHorizontal;
        }

        internal static bool IsLineVertical(double firstPointX, double secondPointX)
        {
            bool isVerticL = firstPointX == secondPointX;
            return isVerticL;
        }
    }
}