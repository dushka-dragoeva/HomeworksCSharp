namespace _09.StudentGroups
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        public Student( string firstName, string lastName, string fn, string tel, string email, List<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN =fn;
            this.Tel =tel;
            this.Email=email;
            this.Marks =marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }
       
        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
        
    }
}
