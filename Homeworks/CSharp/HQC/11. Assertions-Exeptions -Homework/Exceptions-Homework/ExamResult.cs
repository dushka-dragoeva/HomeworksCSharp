namespace Exceptions_Homework
{
    using System;

    public class ExamResult
    {
        private const string NEGATIVE_GRADE_MESSAGE = "Grade must be positive!";
        private const string GRADE_COMPARISON_MESSAGE = "Max grade must be greater than min grade!";
        private const string EMPTY_STRING_MESSAGE = "Comments must be a non-empty string!";
       
        private int grade;
        private int minGrade;
        private int maxGrade;
        private string comments;

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Max " + NEGATIVE_GRADE_MESSAGE);
                }

                this.grade = value;
            }
        }

        public int MinGrade
        {
            get
            {
                return this.minGrade;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Min " + NEGATIVE_GRADE_MESSAGE);
                }

                this.minGrade = value;
            }
        }

        public int MaxGrade
        {
            get
            {
                return this.maxGrade;
            }

            private set
            {
                if (value <= this.MinGrade)
                {
                    throw new ArgumentException(GRADE_COMPARISON_MESSAGE);
                }

                this.maxGrade = value;
            }
        }

        public string Comments
        {
            get
            {
                return this.comments;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(EMPTY_STRING_MESSAGE);
                }

                this.comments = value;
            }
        }
    }
}