namespace StudentsAndWorkers
{
    using System;

    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {

            this.grade = grade;
        }
        public int Grade
        {
            get { return this.grade; }
            private set
            {
                if (value < 1|| value>=13)
                {
                    throw new ArgumentException("Grade must be between 1 and 12.");
                }

                this.grade = value;
            }
        }
    }
}