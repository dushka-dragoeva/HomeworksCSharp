/*01.Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, 
course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=
02.Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.
03.Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social security number
(as second criteria, in increasing order).*/

namespace Students
{
    using System;

    class TestStudent
    {
        static void Main()
        {
            var studentMaria = new Student("Maria", "Petrova","985112", 3, Specialty.BiologyTeacher, University.SofiaUneversity, Faculty.Biology);
            var studentPesho = new Student("Pesho", "Peshev", "159876", 4, Specialty.SoftwareEngineer, University.Technical, Faculty.Electronics);
            var otherPesho = studentPesho.Clone() as Student;

            Console.WriteLine("Compare Pesho and otherPesho:");
            Console.WriteLine("Equal: "+ studentPesho.Equals(otherPesho));
            Console.Write("==: ");
            Console.WriteLine( studentPesho == otherPesho);
            Console.Write("!=: ");
            Console.WriteLine(studentPesho != otherPesho);
            Console.WriteLine();
            Console.WriteLine("Compare Pesho and Maria:");
            Console.WriteLine("Equal: " + studentPesho.Equals(studentMaria));
            Console.Write("==: ");
            Console.WriteLine(studentPesho == studentMaria);
            Console.Write("!=: ");
            Console.WriteLine(studentPesho != studentMaria);
            Console.WriteLine();
            
            otherPesho.SSN = "546549";
            
            Console.WriteLine("Original Pesho:\n" +studentPesho.ToString());
            Console.WriteLine("Cloned Pesho:\n"+otherPesho.ToString());
            Console.WriteLine("Compairing Pesho and otherPesho " +studentPesho.CompareTo(otherPesho));
            Console.WriteLine("Compare Pesho and otherPesho:");
            //Console.WriteLine("Equal: " + studentPesho.Equals(otherPesho));
            Console.Write("==: ");
            //Console.WriteLine(studentPesho == otherPesho);
            Console.Write("!=: ");
            //Console.WriteLine(studentPesho != otherPesho);
            Console.WriteLine();

        }
    }
}
