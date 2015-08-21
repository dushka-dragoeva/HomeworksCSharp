namespace Exceptions_Homework
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ExceptionsHomework
    {
        public static void Main()
        {
            var substr = Helpers.Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = Helpers.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(String.Join(" ", subarr));

            var allarr = Helpers.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(String.Join(" ", allarr));

            var emptyarr = Helpers.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(String.Join(" ", emptyarr));

            Console.WriteLine(Helpers.ExtractEnding("I love C#", 2));
            Console.WriteLine(Helpers.ExtractEnding("Nakov", 4));
            Console.WriteLine(Helpers.ExtractEnding("beer", 4));
            Console.WriteLine(Helpers.ExtractEnding("Hi", 100));

            try
            {
                Console.WriteLine(Helpers.ExtractEnding("Hi", 100));
            }
            catch (ArgumentOutOfRangeException exception)
            {
                Console.Error.WriteLine(exception.Message);
            }

            var primeNumber = 23;
                
            Console.WriteLine(primeNumber + " is prime." + Helpers.CheckPrime(primeNumber));

            var notPrimeNumber = 23;

            Console.WriteLine(notPrimeNumber + " is prime." + Helpers.CheckPrime(notPrimeNumber));
            
            List<Exam> peterExams = new List<Exam>()
            {
                new SimpleMathExam(2),
                new CSharpExam(55),
                new CSharpExam(100),
                new SimpleMathExam(1),
                new CSharpExam(0),
            };
            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
    }
}