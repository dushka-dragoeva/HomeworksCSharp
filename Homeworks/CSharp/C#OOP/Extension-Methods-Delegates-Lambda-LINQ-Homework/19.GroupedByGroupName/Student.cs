namespace _19.GroupedByGroupName
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        public Student( string firstName, string lastName, string groupName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            
            this.GroupName = groupName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
     
        public string GroupName { get; set; }
       
        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
        
    }
}
