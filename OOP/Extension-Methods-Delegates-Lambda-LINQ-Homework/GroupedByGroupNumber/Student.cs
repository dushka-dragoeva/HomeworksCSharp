namespace GroupedByGroupNumber
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        public Student( string firstName, string lastName,  int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.GroupNumber = groupNumber;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GroupNumber { get; set; }
       
        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
        
    }
}
