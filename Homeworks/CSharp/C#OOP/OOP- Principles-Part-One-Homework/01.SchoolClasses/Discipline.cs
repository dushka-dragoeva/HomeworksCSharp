namespace  SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Discipline : IComment
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.name = name;
            this.numberOfLectures = numberOfLectures;
            this.numberOfExercises = numberOfExercises;
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Discipline name cannot be null or empty");
                }

                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            private set
            {
                if (this.numberOfLectures < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of lectures cannot be negative number");
                }

                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get { return this.numberOfExercises; }
            private set
            {
                if (this.numberOfExercises < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of exercise cannot be negative number");
                }

                this.numberOfExercises = value;
            }
        }

        public List<string> comment;

        public void AddComment(string newComment)
        {

            var comment = new List<string>();
            comment.Add(newComment);
            Console.WriteLine(string.Join("", comment));
        }

        public override string ToString()
        {
            return  this.Name;
        }
    }
}