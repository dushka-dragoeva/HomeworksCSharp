namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Course
    {
        private string coursName;
        private string teacherName;
        private IList<string> students;

        public Course(string courseName)
        {
            this.CourseName = courseName;
        }

        public Course(string courseName, string teacherName)
            : this(courseName)
        {
            this.TeacherName = teacherName;
        }

        public Course(string courseName, string teacherName, IList<string> students)
            : this(courseName, teacherName)
        {
            this.Students = students;
        }

        public string CourseName
        {
            get
            {
                return this.coursName;
            }

            set
            {
                if (value.Length <= 3)
                {
                    throw new ArgumentException("Name length must be at least 3 characters");
                }

                this.coursName = value;
            }
        }

       public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                if (value.Length <= 3)
                {
                    throw new ArgumentException("Name length must be at least 3 characters");
                }

                this.teacherName = value;
            }
        }

       public IList<string> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                this.students = value ?? new List<string>();
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.CourseName);
            if (!string.IsNullOrEmpty(this.TeacherName))
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            if (this.Students != null && this.Students.Count > 0)
            {
                result.Append("; Students = ");
                result.Append(this.GetStudentsAsString());
            }
            
            return result.ToString();
        }

        protected string GetStudentsAsString()
        {
            if (this.Students.Count == 0)
            {
                return "{ }";
            }

            return "{ " + string.Join(", ", this.Students) + " }";
        }
    }
    }
