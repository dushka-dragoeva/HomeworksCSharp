/*09.Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
Create a List<Student> with sample students. Select only the students that are from group number 2.
Use LINQ query. Order the students by FirstName.*/
namespace _09.StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using _09.StudentGroups.Extentions;
    

    public class StudentsGroups
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            students.Add(new Student("Angel", "Georgiev", "896506" , "042 456 321", "a.georgiev@dir.bg", new List<int> { 4, 6 }, 1));
            students.Add(new Student("Gosho", "Dinev", "789607", "02 456 322", "g.dinev@abv.bg", new List<int> { 4, 3 }, 1));
            students.Add(new Student("Ani", "Petrova", "7896106", "0887 456 323", "a.petrova@abv.bg", new List<int> { 4, 3, 5, }, 1));
            students.Add(new Student("Pesho", "Ivanov", "896205", "056 456 324", "p.ivanov@abv.bg", new List<int> { 4, 6 }, 2));
            students.Add(new Student("Dragan", "Georgiev", "654106", "02 456 325", "d.georgiev@adir.bg", new List<int> { 4, 4, 3, 5, 3, }, 2));
            students.Add(new Student("Ivan", "Peevski", "964107", "02 456 333", "i.peevski@abv.bg", new List<int> { 6 }, 2));
            students.Add(new Student("Peter", "Dimitrov", "654108", "0887 456 334", "p.dimitrov@abv.bg", new List<int> { 4, 6, 3, 3, 2, }, 3));
            students.Add(new Student("Rosen", "Popov", "789109", "0887 456 335", "r.popov@abv.bg", new List<int> { 4, }, 3));
            students.Add(new Student("Desi", "Georgieva", "954206", "0887 456 316", "d.georgieva@dir.bg", new List<int> { 6, 6, 5, 4, 6, 4 }, 4));
            students.Add(new Student("Maria", "Mileva", "652105", "02 456 356", "m.mileva@abv.bg", new List<int> { 6, 6, 6, }, 4));

            var studentsGroupTwo =
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;
            Console.WriteLine("Students from group 2 using LINQ \n");
            PrintStudents(studentsGroupTwo);

            //10.Implement the previous using the same query expressed with extension methods.
            var studentsFromGroupTwo =students.ExtensionSortByGroup();
            Console.WriteLine("Students from group 2 using Extention Method.\n");
            PrintStudents(studentsFromGroupTwo);

            EMailAbv(students);
            PhonesInSofia(students);
            SortByExcelentMark(students);
            StudentsWithTwoMarks(students);
            SortBySigningIn2006(students);
        }
      //  11. Extract all students that have email in abv.bg.Use string methods and LINQ.
        public static void EMailAbv(List<Student> students)
        {
            var studentAbvEmail =
                from student in students
                where student.Email.Contains("abv.bg")
                select student;
            Console.WriteLine("List of students that have email in abv.bg.\n");
            PrintStudents(studentAbvEmail);

        }
        //12.Extract all students with phones in Sofia. Use LINQ.
        public static void PhonesInSofia(List<Student> students)
        {
            var studentFromSofia =
                from student in students
                where student.Tel.StartsWith("02")
                select student;
            Console.WriteLine("List of students with phones in Sofia.\n");
            PrintStudents(studentFromSofia);

        }
        //13.Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks. Use LINQ.
        public static void SortByExcelentMark(List<Student> students)
        {
            var sortedByExilentMark =
                from student in students
                where student.Marks.Contains(6)
                select new { FullName = student.ToString(), Marks = student.Marks };

            Console.WriteLine("Students that have at least one mark Excellent (6).\n");
            foreach (var student in sortedByExilentMark)
            {
                Console.WriteLine(student.FullName.PadRight(15) + " [" + string.Join(", ", student.Marks) + "]");
            }
            Console.WriteLine();
        }
       // 14. Write down a similar program that extracts the students with exactly two marks "2".Use extension methods.
        public static void StudentsWithTwoMarks(List<Student> students)
        {
            var studentsTwoMarks = students.StudentsWithTwoMarks()
                .Select(s => new { FullName = s.ToString(), Marks = s.Marks })
                .ToList();
            Console.WriteLine("Students with two marks.\n");
            foreach (var student in studentsTwoMarks)
            {
                Console.WriteLine(student.FullName.PadRight(15) + " [" + string.Join(", ", student.Marks) + "]");
            }
            Console.WriteLine();
        }
       //15. Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).*/
        public static void SortBySigningIn2006(IEnumerable<Student> students)
        {
            var studentsSigningIn2006 =
                from st in students
                where st.FN.EndsWith("06")
                select st;

            Console.WriteLine("Marks of students enrolled in 2006\n");

            foreach (Student student in studentsSigningIn2006)
            {
                Console.WriteLine(student.ToString().PadRight(18) +
                    "[" + string.Join(", ", student.Marks) + "]");
            }
            Console.WriteLine();
        }
        public static void PrintStudents(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();
        }
    }
}