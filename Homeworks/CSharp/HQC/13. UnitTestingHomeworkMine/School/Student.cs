namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public const int MIN_UNIQUE_NUMBER_VALUE = 10000;
        public const int MAX_UNIQUE_NUMBER_VALUE = 99999;

        private string name;
        private int uniqueNumber;

       public Student(string name, int uniqueNumber)
        {
            this.Name = name;
            this.UniqueNumber = uniqueNumber;
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

        public int UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }

            set
            {
                if (!Validator.ValidateUniqueNumber(value, MIN_UNIQUE_NUMBER_VALUE, MAX_UNIQUE_NUMBER_VALUE))
                {
                    throw new ArgumentException(string.Format(Message.INVALID_UNIQUE_NUMBER_MESSAGE, MIN_UNIQUE_NUMBER_VALUE, MAX_UNIQUE_NUMBER_VALUE));
                }

                this.uniqueNumber = value;
            }
        }
    }
}