namespace School
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private const int MAX_STUDENT_COUNT = 30;

        private string name;
        private ICollection<Student> students;

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (Validator.ValidateName(value))
                {
                    throw new ArgumentNullException(Message.INVALID_NAME_MESSAGE);
                }

                this.name = value;
            }
        }

        public ICollection<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(Message.NULL_MESSAGE);
            }

            if (this.Students.Count + 1 > MAX_STUDENT_COUNT)
            {
                throw new InvalidOperationException(Message.COURSE_QUOTA_MESSAGE);
            }

            if (this.students.Contains(student))
            {
                throw new InvalidOperationException(Message.EXISTING_STUDENT_MESSAGE);
            }

            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(Message.NULL_MESSAGE);
            }

            if (!this.students.Contains(student))
            {
                throw new InvalidOperationException(Message.NOT_ATTENDING_STUDENT_MESSAGE);
            }

            this.students.Remove(student);
        }
    }
}