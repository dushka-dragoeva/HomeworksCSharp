namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StudetTests
    {
        [TestMethod]
        public void Test_StudentShouldNotThrowAnExeption()
        {
            var student = new Student("Tom Jordan", 55555);
        }

        [TestMethod]
        public void Test_StudentShouldReturnExpctedName()
        {
            var student = new Student("Tom Jordan", 55555);

            Assert.AreEqual("Tom Jordan", student.Name);
        }

        [TestMethod]
        public void Test_StudentShouldReturnExpectedUniqueNumber()
        {
            var student = new Student("Tom Jordan", 55555);

            Assert.AreEqual(55555, student.UniqueNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_StudentShouldThrowNullReferenceExeptionforNullName()
        {
            var student = new Student(null, 55555);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_StudentShouldThrowNullReferenceExeptionForEmptyName()
        {
            var student = new Student(string.Empty, 55555);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_StudentShouldArgumentExeptionForInvalifUniqueNumber_Low()
        {
            var student = new Student("Tom Jordan", 555);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_StudentShouldArgumentExeptionForInvalifUniqueNumber_High()
        {
            var student = new Student("Tom Jordan", 55555555);
        }
    }
}
