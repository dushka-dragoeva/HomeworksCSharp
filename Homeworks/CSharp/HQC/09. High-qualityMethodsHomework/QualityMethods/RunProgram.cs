namespace QualityMethods
{
    using System;

    public class RunProgram
    {
        public static void Main()
        {
            Console.WriteLine(Methods.CalcTriangleArea(3, 4, 5));

            Console.WriteLine(Methods.NumberToDigit(5));

            Console.WriteLine(Methods.FindMax(5, -1, 3, 2, 14, 2, 3));

            Methods.PrintFormatWithPrecision(1.3);
            Methods.PrintNumberAsPersentige(0.75);
            Methods.PrintnumberAlignedRight(2.30);

            Console.WriteLine(Methods.CalculateDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + Methods.IsLineHorizontal(-1, 2.5));
            Console.WriteLine("Vertical? " + Methods.IsLineVertical(3, 3));
            Student peter = new Student("Peter", "Ivanov" );
            peter.OtherInfo = "From Sofia, born at 17.03.1992";
            Student stella = new Student("Stella", "Markova");
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";
            
            Console.WriteLine(
                "{0} older than {1} -> {2}",
                peter.FirstName,
                stella.FirstName,
                peter.IsOlderThan(stella));
            Console.ReadLine();
        }
    }
}
