namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

   public class School
    {
        private ICollection<Course> courses;
        private ICollection<Student> students;
        private string name;

        public School(string name)
        {
            this.Name = name;
            this.courses = new List<Course>();
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

        public ICollection<Course> Courses
        {
            get
            {
                return new List<Course>(this.courses);
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
                throw new ArgumentNullException("Student" + Message.NULL_MESSAGE);
            }

            if (this.students.Contains(student))
            {
                throw new InvalidOperationException(Message.EXISTING_STUDENT_MESSAGE);
            }

            if (this.students.Any(x => x.UniqueNumber == student.UniqueNumber))
            {
                throw new ArgumentException(Message.EXISTING_UNIQUE_NUMBER_MESSAGE);
            }

            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student" + Message.NULL_MESSAGE);
            }

            if (!this.students.Contains(student))
            {
                throw new InvalidOperationException(Message.NOT_EXISTING_STUDENT_MESSAGE);
            }

            this.students.Remove(student);
        }

        public void AddCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course" + Message.NULL_MESSAGE);
            }

            if (this.courses.Contains(course))
            {
                throw new InvalidOperationException(Message.EXISTING_COURSE_MESSAGE);
            }

            this.courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course" + Message.NULL_MESSAGE);
            }

            if (!this.courses.Contains(course))
            {
                throw new InvalidOperationException(Message.NOT_EXISTING_COURSE_MESSAGE);
            }

            this.courses.Remove(course);
        }
    }
}
