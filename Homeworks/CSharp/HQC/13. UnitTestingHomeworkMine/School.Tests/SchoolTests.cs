namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        public void Test_SchoolShouldNotThrowAnExeption()
        {
            var school = new School("Telerik");
        }

        [TestMethod]
        public void Test_SchoolShouldReturnExpectedName()
        {
            var school = new School("Telerik");

            Assert.AreEqual("Telerik", school.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_SchoolShouldThrowNullReferenceExeptionforNullName()
        {
            var school = new School(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_SchoolShouldThrowNullReferenceExeptionForEmptyName()
        {
            var school = new School(string.Empty);
        }

        [TestMethod]
        public void Test_SchoolShouldAddStudentCorrectly()
        {
            var school = new School("Telerik");
            var student = new Student("Tom Jordan", 55555);

            school.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_SchoolShouldThrowNullReferenceExeptionWhenNullSudentAdded()
        {
            var school = new School("Telerik");
            school.AddStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Test_SchoolShouldThrowWhenExistingSudentAdded()
        {
            var school = new School("Telerik");
            var student = new Student("Tom Jordan", 55555);
            school.AddStudent(student);
            school.AddStudent(student);
        }

        [TestMethod]
        public void Test_SchoolRemoveStudentCorrectly()
        {
            var school = new School("Telerik");
            var student = new Student("Tom Jordan", 55555);
            school.AddStudent(student);
            school.RemoveStudent(student);
            Assert.AreEqual(0, school.Students.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_SchoolShouldThrowNullReferenceExeptionWhenNullSudentRemoved()
        {
            var school = new School("Telerik");
            school.RemoveStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Test_SchoolShouldThrowWhenNotExistingSudentRemoved()
        {
            var school = new School("Telerik");
            var student = new Student("Tom Jordan", 55555);
            school.AddStudent(student);
            school.RemoveStudent(student);
            school.RemoveStudent(student);
        }

        [TestMethod]
        public void Test_SchoolShouldAddCourseCorrectly()
        {
            var school = new School("Telerik");
            var course = new Course("Java Script");

            school.AddCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_SchoolShouldThrowNullReferenceExeptionWhenNullCourseAdded()
        {
            var school = new School("Telerik");
            school.AddCourse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Test_SchoolShouldThrowWhenExistingSCourseAdded()
        {
            var school = new School("Telerik");
            var course = new Course("Java Script");
            school.AddCourse(course);
            school.AddCourse(course);
        }

        [TestMethod]
        public void Test_SchoolRemoveCoursetCorrectly()
        {
            var school = new School("Telerik");
            var course = new Course("Java Script");
            school.AddCourse(course);
            school.RemoveCourse(course);
            Assert.AreEqual(0, school.Courses.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_SchoolShouldThrowNullReferenceExeptionWhenNullCourseRemoved()
        {
            var school = new School("Telerik");
            school.RemoveCourse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Test_SchoolShouldThrowWhenNotExistingCourseRemoved()
        {
            var school = new School("Telerik");
            var course = new Course("Java Script");
            school.AddCourse(course);
            school.RemoveCourse(course);
            school.RemoveCourse(course);
        }
    }
}
