namespace SchoolClasses
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public class Class : IComment
    {
        private string textIdentifier;
        private List<Teacher> teachersSet;

        public Class(string textIdent, params Teacher[] teachersSet)
        {
            this.TextIdentifier = textIdent;
            this.teachersSet = new List<Teacher>();
            this.teachersSet.AddRange(teachersSet);
        }

        public string TextIdentifier
        {
            get { return this.textIdentifier; }
            private set { this.textIdentifier = value; }
        }

        public List<Teacher> TeachersSet
        {
            get
            {
                return new List<Teacher>(this.teachersSet);
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachersSet.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.teachersSet.Remove(teacher);
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
            return "Class " + this.TextIdentifier;
        }

        
    }
}
