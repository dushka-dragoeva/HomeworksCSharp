namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Threading.Tasks;

    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void Test_CourseShouldNotThrowAnExeption()
        {
            var course = new Course("Java Script");
        }

        [TestMethod]
        public void Test_CourseShouldReturnExpectedName()
        {
            var course = new Course("Java Script");

            Assert.AreEqual("Java Script", course.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_CourseShouldThrowNullReferenceExeptionforNullName()
        {
            var course = new Course(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_CourseShouldThrowNullReferenceExeptionForEmptyName()
        {
            var course = new Course(string.Empty);
        }

        [TestMethod]
        public void Test_CourseShouldAddStudentCorrectly()
        {
            var course = new Course("Java Script");
            var student = new Student("Tom Jordan", 55555);

            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_CourseShouldThrowNullReferenceExeptionWhenNullSudentAdded()
        {
            var course = new Course("Java Script");
            course.AddStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Test_CourseShouldThrowWhenExistingSudentAdded()
        {
            var course = new Course("Java Script");
            var student = new Student("Tom Jordan", 55555);
            course.AddStudent(student);
            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Test_CourseshouldThrowExceptionWhenMoreThanPossibleStudentAdded()
        {
            var course = new Course("Java Script");
            for (int i = 0; i < 50; i++)
            {
                course.AddStudent(new Student(i.ToString(), 10000 + i));
            }
        }

        [TestMethod]
        public void Test_CourseRemoveStudentCorrectly()
        {
            var course = new Course("Java Script");
            var student = new Student("Tom Jordan", 55555);
            course.AddStudent(student);
            course.RemoveStudent(student);
            Assert.AreEqual(0, course.Students.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_CourseShouldThrowNullReferenceExeptionWhenNullSudentRemoved()
        {
            var course = new Course("Java Script");
            course.RemoveStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Test_CourseShouldThrowWhenNotExistingSudentRemoved()
        {
            var course = new Course("Java Script");
            var student = new Student("Tom Jordan", 55555);
            course.AddStudent(student);
            course.RemoveStudent(student);
            course.RemoveStudent(student);
        }
    }
}
