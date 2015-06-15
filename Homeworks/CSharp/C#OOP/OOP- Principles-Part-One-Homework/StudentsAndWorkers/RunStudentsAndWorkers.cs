
/*Problem 2. Students and workers

Define abstract class Human with a first name and a last name. Define a new class Student which is derived from Human and 
 has a new field – grade. Define class Worker derived from Human with a new property WeekSalary and WorkHoursPerDay
 and a method MoneyPerHour() that returns money earned per hour by the worker. 
 Define the proper constructors and properties for this hierarchy.
Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
Initialize a list of 10 workers and sort them by money per hour in descending order.
Merge the lists and sort them by first name and last name.*/

namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class RunStudentsAndWorkers
    {
        public const int workingDaysInWeek =5;
        static void Main()
        {
            var students = new List<Student>();
            students.Add(new Student("Svetla", "Draganova", 3));
            students.Add(new Student("Georgi", "Ivanov", 9));
            students.Add(new Student("Ivan", "Petrov", 3));
            students.Add(new Student("Chavdar", "Kamenov", 10));
            students.Add(new Student("Ivan", "Kozhuharov", 10));
            students.Add(new Student("Georgi", "Stoyanov", 1));
            students.Add(new Student("Ivan", "Kovachev", 6));
            students.Add(new Student("Stefan", "Petrov", 6));
            students.Add(new Student("Martin", "Atanasov", 12));
            students.Add(new Student("Veronika", "Govedarova", 2));

            var sortedStudents = students
                .OrderBy(s => s.Grade)
                .GroupBy(s=>s.Grade)
                .ToList();

            foreach (var group in sortedStudents)
            {
                Console.WriteLine("Grade {0}:", group.Key);
                foreach (var student in group)
                {
                Console.WriteLine(student.ToString().PadRight(22) );
                }
               Console.WriteLine();

            }

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Simeon", "Petrov", 993, 12));
            workers.Add(new Worker("Severin", "Lakov", 809, 11));
            workers.Add(new Worker("Kliment", "Evgeniev", 384, 4));
            workers.Add(new Worker("Aleksandar", "Simeonov", 828, 5));
            workers.Add(new Worker("Teodor", "Hristov", 675, 4));
            workers.Add(new Worker("Andrey", "Sotirov", 688, 8));
            workers.Add(new Worker("Eleonora", "Viktorova", 589, 8));
            workers.Add(new Worker("Zafir", "Kaloyanov", 904, 10));
            workers.Add(new Worker("Plamen", "Antonov", 947, 8));
            workers.Add(new Worker("Fabian", "Kornelov", 970, 12));

            var sortedWorkers = workers
                .OrderByDescending(w => w.MoneyPerHour(workingDaysInWeek))
                .ToList();
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker.ToString().PadRight(20) + " Money per hour - {0:F2}" , worker.MoneyPerHour(workingDaysInWeek));
            }
            Console.WriteLine();

            var people = new List<Human>();
            people.AddRange(students);
            people.AddRange(workers);
            
            var sortedPeople =
                from human in people
                orderby human.LastName
                orderby human.FirstName
                select human;

            foreach (var human in sortedPeople)
            {
                Console.WriteLine(human.ToString());
            }
            Console.WriteLine();
        }
    }
}
