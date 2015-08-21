namespace QualityMethods
{
    using System;

    internal class Student
    {
        public const int MIN_NAME_LENGTH = 2;
        public const int MAX_NAME_LENGTH = 30;
        private string firstName;
        private string lastName;

        internal Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        internal Student(string firstName, string lastName, string otherInfo)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.OtherInfo = otherInfo;
        }

        internal string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.ValidateName(value);
                this.firstName = value;
            }
        }

        internal string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.lastName = value;
            }
        }

        internal string OtherInfo { get; set; }

        public bool IsOlderThan(Student other)
        {
            DateTime firstDate =
                DateTime.Parse(this.OtherInfo.Substring(this.OtherInfo.Length - 10));
            DateTime secondDate =
                DateTime.Parse(other.OtherInfo.Substring(other.OtherInfo.Length - 10));
            bool isOlder = firstDate < secondDate;
            return isOlder;
        }

        private void ValidateName(string name)
        {
            if (MIN_NAME_LENGTH > name.Length || name.Length > MAX_NAME_LENGTH)
            {
                throw new ArgumentOutOfRangeException("The name must me between 2 and 30 letters!");
            }

            foreach (char symbol in name)
            {
                if (!char.IsLetter(symbol) && symbol != '-' && symbol != '.')
                {
                    throw new ArgumentException("The name can contain only letters, '-' or '.'!");
                }
            }
        }
    }
}