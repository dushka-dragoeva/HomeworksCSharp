//Problem 19. Rewrite the previous using extension methods.
namespace _19.GroupedByGroupName
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class GroupName
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            students.Add(new Student("Angel", "Georgiev", "Math"));
            students.Add(new Student("Gosho", "Dinev", "Hystory"));
            students.Add(new Student("Ani", "Petrova", "Chemistry"));
            students.Add(new Student("Pesho", "Ivanov", "Math"));
            students.Add(new Student("Dragan", "Georgiev", "Chemistry"));
            students.Add(new Student("Ivan", "Peevski", "Hystory"));
            students.Add(new Student("Peter", "Dimitrov", "Hystory"));
            students.Add(new Student("Rosen", "Popov", "Math"));
            students.Add(new Student("Desi", "Georgieva", "Math"));
            students.Add(new Student("Maria", "Mileva", "Hystory"));

            var sortedStudents =
               from student in students
               group student by student.GroupName;

            foreach (var group in sortedStudents)
            {
                Console.WriteLine("Group {0}:\n", group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine(student.ToString());
                }
                Console.WriteLine();
            }
        }
    }
}