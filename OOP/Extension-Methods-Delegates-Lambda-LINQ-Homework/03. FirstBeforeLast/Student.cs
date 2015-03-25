namespace _03.FirstBeforeLast
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;

    public class Student 
    {
        public Student(string firstName, string lastName,int age)

        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        
      
    }
}
