namespace Exceptions_Homework
{
    using System;

    public class CSharpExam : Exam
    {
        private const int MIN_SCORE = 0;
        private const int MAX_SCORE = 100;
        private int score;

        public CSharpExam(int score)
        {
            this.Score = score;
        }

        public int Score
        {
            get
            {
                return this.score;
            }

            set
            {
                if (MIN_SCORE > value || value > MAX_SCORE)
                {
                    throw new ArgumentException("The score should be between 0 and 100!");
                }

                this.score = value;
            }
        }

        public override ExamResult Check()
        {
            return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        }
    }
}