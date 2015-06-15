namespace _09.StudentGroups.Extentions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public static class StudentsTwoMarks
    {
        public static IEnumerable<Student> StudentsWithTwoMarks(this IEnumerable<Student> students)
        {
            var sortedByTowMark = students.Where(s => s.Marks.Count == 2)
                .ToList() ;
            return sortedByTowMark;
        }
    }
}