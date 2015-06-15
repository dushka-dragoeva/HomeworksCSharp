//Write a program to return the string with maximum length from an array of strings.
//Use LINQ.
namespace _17.LongestString
{
    using System;
    using System.Linq;
    using System.Text;
    class Program
    {
        static void Main()
        {
            string input = @"For most of the last century, the study of emotions was not considered serious science. 
                        The problem was subjectivity. Science is objective, rigorously objective. 
                        Emotions, though, are internal states, so the only way to study them is through subjective inference 
                        (essentially asking people to report how they feel). But — because people lie, because we often misinterpret 
                        our emotions and because comparisons between subjects, that is the depth of my anger versus your anger, 
                        is impossibletomeasurethere’s no objective data to be found.";

            var stringArray = input
                .Split(new char[] { ' ', '.', ',', '!', '?', '(', ')', ':' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var longestString =stringArray
                .OrderByDescending(x => x.Length)
                .First();
            Console.WriteLine(longestString);
        }
    }
}
