namespace Students
{
    using System;
    using System.Text;

    class Student : ICloneable, IComparable<Student>
    {
        private const string EmptyNameExceptionMsg = "Name cannot be empty.";
        private const string NameLengthExceptionMsg = "Name must be between 2 and 50 characters long.";
        private const string InvalidObjectMsg = "Object must be of type Student.";

        private string firstName;
        private string middleName;
        private string lastName;
        private string ssn;
        private string address;
        private string mobilePhone;
        private string email;
        private int course;
        private Specialty specialty;
        private Faculty faculty;
        private University university;

        public Student(string firstName, string lastName, string ssn, int course, Specialty specialty, University univeristy, Faculty faculty)
            : this(firstName, string.Empty, lastName, ssn, string.Empty, string.Empty, string.Empty, course, specialty, univeristy, faculty)
        {
        }

        public Student(string firstName, string middleName, string lastName, string ssn, string address, string mobilePhone, string email, int course, Specialty specialty, University university, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(EmptyNameExceptionMsg);
                }

                if (value.Length < 2 || value.Length > 50)
                {
                    throw new ArgumentException(NameLengthExceptionMsg);
                }

                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }

            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length < 2 || value.Length > 50)
                {
                    throw new ArgumentException(NameLengthExceptionMsg);
                }

                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(EmptyNameExceptionMsg);
                }

                if (value.Length < 2 || value.Length > 50)
                {
                    throw new ArgumentException(NameLengthExceptionMsg);
                }

                this.lastName = value;
            }
        }

        public string SSN
        {
            get
            {
                return this.ssn;
            }

            set
            {
                this.ssn = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }

            set
            {
                this.address = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }

            set
            {
                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                this.email = value;
            }
        }

        public int Course
        {
            get
            {
                return this.course;
            }

            set
            {
                this.course = value;
            }
        }

        public Specialty Specialty
        {
            get
            {
                return this.specialty;
            }

            set
            {
                this.specialty = value;
            }
        }

        public University University
        {
            get
            {
                return this.university;
            }

            set
            {
                this.university = value;
            }
        }

        public Faculty Faculty
        {
            get
            {
                return this.faculty;
            }

            set
            {
                this.faculty = value;
            }
        }
        
        public override bool Equals(object other)
        {
            var student = other as Student;
            
            if (this.SSN == student.SSN)
            {
                return true;
            }

            return false;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.FirstName + " " + this.LastName +", SSN: "+this.SSN)
                .AppendLine("Specialty: " + this.Specialty + " " + this.Course + " course")
                .AppendLine("University: " + this.University)
                .AppendLine("Faculty: " + this.Faculty);

            return sb.ToString();
        }
        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ LastName.GetHashCode() ^ SSN.GetHashCode()^Course.GetHashCode();
        }
        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return firstStudent.Equals(secondStudent);
        }
        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !firstStudent.Equals(secondStudent);
        }
        
        public object Clone()
        {
            Student originalStudent=this;
            Student clonedStudemt= new Student(this.FirstName,this.MiddleName,this.LastName,
                this.SSN,this.Address,this.MobilePhone,this.Email, this.Course,this.Specialty,this.University,this.Faculty);
            return clonedStudemt;
        }
        public int CompareTo(Student otherStudent)
        {
            var studentName = this.FirstName + this.MiddleName + this.LastName;
            var otherStudentName = otherStudent.FirstName + otherStudent.MiddleName + otherStudent.LastName;
           

            if(studentName==otherStudentName)
            {
               return int.Parse(this.SSN).CompareTo(int.Parse(otherStudent.SSN));
            }
            return studentName.CompareTo(otherStudentName);
        }
    }
}
