namespace School
{
    using System;
    using System.Linq;

    internal class Message
    {
        public const string INVALID_NAME_MESSAGE = "Error:Name can not be empty!";
        public const string INVALID_UNIQUE_NUMBER_MESSAGE = "Error: Unique number must be  between {0} and {1}";
        public const string COURSE_QUOTA_MESSAGE = "Student list is full.";
        public const string NULL_MESSAGE = " cannot be null";
        public const string EXISTING_STUDENT_MESSAGE = "This student has been already added.";
        public const string NOT_EXISTING_STUDENT_MESSAGE = "There is no such student.";
        public const string EXISTING_UNIQUE_NUMBER_MESSAGE = "There is already a student with the same Unique number.";
        public const string NOT_ATTENDING_STUDENT_MESSAGE = "The student does not attend this class.";
        public const string EXISTING_COURSE_MESSAGE = "This course has been already added.";
        public const string NOT_EXISTING_COURSE_MESSAGE = "There is no such course.";
    }
}
