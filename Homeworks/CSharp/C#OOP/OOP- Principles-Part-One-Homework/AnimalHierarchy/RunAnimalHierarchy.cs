/* Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. 
 All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. 
 All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).*/
namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class RunAnimalHierarchy
    {
        static void Main()
        {

            Animal[] animals =
            {
                new Dog(3, "Rex", Gender.Male ),
                new Dog(2,"Jorko", Gender.Male),
                new Dog(4,"Pepa", Gender.Female),
                new Dog(6,"Pesho", Gender.Male),

                new Frog(2,"Jabko", Gender.Male),
                new Frog(3,"Kikerica", Gender.Female),
                
                new Cat(7,"Maca", Gender.Female), 
                new TomCat(5, "Tom",Gender.Male), 
                new TomCat(3,"Gosho",Gender.Male),
                new Kitten(2,"Puhcho", Gender.Female), 
            };

            var dogs = animals.Where(d => d is Dog);
            var frogs = animals.Where(f => f is Frog);
            var cats = animals.Where(c =>c is Cat );
         
            Console.WriteLine("Dogs'  avarige age is: " + Dog.CalculateAverageAge(dogs));
            Console.WriteLine("Frogs' avarige age is: " + Frog.CalculateAverageAge(frogs));
            Console.WriteLine("Cats'  avarige age is: " + Cat.CalculateAverageAge(cats));
        }
    }
}
