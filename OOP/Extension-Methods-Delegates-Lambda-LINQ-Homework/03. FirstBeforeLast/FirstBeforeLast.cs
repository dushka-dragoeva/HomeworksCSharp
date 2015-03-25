/*03.Write a method that from a given array of students finds all students whose first 
name is before its last name alphabetically.
Use LINQ query operators.
 04. Write a LINQ query that finds the first name and last name of all students with age 
 between 18 and 24.
 05.Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the
 students by first name and last name in descending order.
Rewrite the same with LINQ.*/

namespace _03.FirstBeforeLast
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class FirstBeforeLast
    {
        static void Main()
        {
            Student[] students = {new Student("Ivan", "Petrov", 12),
                                    new Student("Atanas", "Georgiev", 22),
                                    new Student("Georgi", "Atanassov", 50),
                                    new Student("Stamat", "Dimitrov", 19),
                                    new Student("Pesho", "Todorov", 27),
                                    new Student("Pesho", "Ivanov", 27),
                                    new Student("Pesho", "Peshev", 24),
                                    new Student("Pesho", "Andreev", 27)};

            FirstBeforeSecond(students);
           
            var selectedByAge =
                from student in students
                where (student.Age >= 18 && student.Age <= 24)
                select student;

            Console.WriteLine("Students with age between 18 and 24.\n");
            PrintStudents(selectedByAge);

            var sortedStudentsLambda = students.OrderByDescending(s => s.FirstName)
                .ThenByDescending(s => s.LastName)
                .ToArray();

            Console.WriteLine("Students ordered by desending using lambda:\n");
            PrintStudents(sortedStudentsLambda);

            var sortetStudentsLinq =
                 from student in students
                 orderby student.LastName
                 descending
                 orderby student.FirstName
                 descending
                 select student;

            Console.WriteLine("Students ordered by desending using LINQ:\n");
            PrintStudents(sortetStudentsLinq);
        }
        
        public static void FirstBeforeSecond(Student[] students)
        {
            Console.WriteLine("Students  whose first name is before its lastname using LINQ:\n");
            var selectedStudents =
                   from student in students
                   where ((student.FirstName).CompareTo(student.LastName) < 1)
                   select student;
            PrintStudents(selectedStudents);
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


