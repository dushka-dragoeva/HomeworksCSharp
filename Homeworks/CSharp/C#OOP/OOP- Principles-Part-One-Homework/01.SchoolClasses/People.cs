namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class People:IComment
    {
        private string firstName;
        private string lastName;
        
        public People(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }
                this.lastName = value;
            }
        }

        public List<string> comment;

        public void AddComment(string newComment)
        {
            
            var comment =new List<string>();
                comment.Add(newComment);
            Console.WriteLine(string.Join("",comment ));
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }

    }

