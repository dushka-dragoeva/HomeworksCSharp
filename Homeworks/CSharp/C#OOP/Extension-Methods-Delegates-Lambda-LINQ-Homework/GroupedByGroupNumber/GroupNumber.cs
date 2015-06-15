/* 18.Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
Use LINQ.*/
namespace GroupedByGroupNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class GroupNumber
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            students.Add(new Student("Angel", "Georgiev",  1));
            students.Add(new Student("Gosho", "Dinev",  3));
            students.Add(new Student("Ani", "Petrova",  1));
            students.Add(new Student("Pesho", "Ivanov", 3));
            students.Add(new Student("Dragan", "Georgiev", 2));
            students.Add(new Student("Ivan", "Peevski",  2));
            students.Add(new Student("Peter", "Dimitrov", 3));
            students.Add(new Student("Rosen", "Popov", 4));
            students.Add(new Student("Desi", "Georgieva", 2));
            students.Add(new Student("Maria", "Mileva", 4));

           var sortedStudents=
               from student in students
               group student by student.GroupNumber;

           foreach (var group in sortedStudents)
           {
               Console.WriteLine( "Group {0}:\n",group.Key);
               foreach (var student in group)
               {
                   Console.WriteLine(student.ToString());
               }
               Console.WriteLine();
           }
        }
    }
}
