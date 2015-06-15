/*4. Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString() to display the information of a person 
 and if age is not specified – to say so.  Write a program to test this functionality.*/

namespace Persons
{
    using System;

    class TestPersons
    {
        static void Main()
        {
            var persons = new Person[]
            {new Person("Maria Peshova"),
                new Person ("Pesho Peshev", 56),
                new Person("Gosho Peshov", 0)
        };
            foreach (var person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
