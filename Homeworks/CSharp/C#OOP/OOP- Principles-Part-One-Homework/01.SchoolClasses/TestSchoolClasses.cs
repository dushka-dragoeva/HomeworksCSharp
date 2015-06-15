
/*We are given a school. In the school there are classes of students. Each class has a set of teachers. Each teacher teaches a set of disciplines. 
 Students have name and unique class number. Classes have unique text identifier. Teachers have name. 
 Disciplines have name, number of lectures and number of exercises. Both teachers and students are people. 
 Students, classes, teachers and disciplines could have optional comments (free text block).
Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate their fields, 
 define the class hierarchy and create a class diagram with Visual Studio.*/
namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class TestSchoolClasses
    {
        static void Main()
        {
            Student aniPetrova = new Student("Ani"," Petrova", 1);
            Student gerogiMalinov = new Student("Gerogi"," Malinov",2);
            Student hristoVasilev = new Student("Hristo ","Vasilev",3);

            List<Student> studentsInClassA = new List<Student>();
            studentsInClassA.Add(aniPetrova);
            studentsInClassA.Add(gerogiMalinov);
            studentsInClassA.Add(hristoVasilev);

            foreach (var student in studentsInClassA)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine();

            Discipline math = new Discipline("Math", 10, 10);
            Discipline language = new Discipline("Language", 20, 10);
            Discipline art = new Discipline("Art", 5, 10);

            Teacher petarPetrov = new Teacher("Petar"," Petrov");
            petarPetrov.AddDiscipline (math);
            petarPetrov.AddDiscipline(language);

            Teacher peshoPeshov = new Teacher("Pesho" ,"Peshov");
            peshoPeshov.AddDiscipline(art);

            List<Teacher> teachersForAClass = new List<Teacher>() { petarPetrov, peshoPeshov };

            Class classA = new Class("5A");
            classA.AddTeacher(petarPetrov);
            classA.AddTeacher(peshoPeshov);
            Console.WriteLine(classA.ToString() + "\n" + string.Join("", classA.TeachersSet));

            classA.AddComment("Hello");
            classA.AddComment("This is our first class.");
            classA.AddComment("This is our last class!");

            
        }
    }
}
