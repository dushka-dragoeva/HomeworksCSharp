namespace Exceptions_Homework
{
    using System;

    public class SimpleMathExam : Exam
    {
        private const string EXEILLENT_RESULT_COMMENT = "Excellent result: everything's done correctly.";
        private const string GOOD_RESULT_COMMENT = "Good result: almost everything's done correctly.";
        private const string AVERAGE_RESULT_COMMENT = "Average result: almost nothing done.";
        private const string BAD_RESULT_COMMENT = "Bad result: nothing done.";

        private const int MIN_PROBLEMS_SOLVED = 0;
        private const int MAX_PROBLEMS_SOLVED = 10;
        private const int BAD_GRADE_MAX_PROBLEMS = 2;
        private const int AVARAGE_GRADE_MAX_PROBLMS = 5;
        private const int GOOD_GRADE_EXAM_PROBLEMS = 8;

        private int problemsSolved;

        public SimpleMathExam(int problemsSolved)
        {
            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved
        {
            get
            {
                if (this.problemsSolved < MIN_PROBLEMS_SOLVED)
                {
                    return MIN_PROBLEMS_SOLVED;
                }
                else if (this.problemsSolved > MAX_PROBLEMS_SOLVED)
                {
                    return MAX_PROBLEMS_SOLVED;
                }
                else
                {
                    return this.problemsSolved;
                }
            }

            private set
            {
                this.problemsSolved = value;
            }
        }

        public override ExamResult Check()
        {
            string comment = String.Empty;

            if (this.ProblemsSolved <= BAD_GRADE_MAX_PROBLEMS)
            {
                comment = BAD_RESULT_COMMENT;
            }
            else if (this.ProblemsSolved <= AVARAGE_GRADE_MAX_PROBLMS)
            {
                comment = AVERAGE_RESULT_COMMENT;
            }
            else if (this.ProblemsSolved <= GOOD_GRADE_EXAM_PROBLEMS)
            {
                comment = GOOD_RESULT_COMMENT;
            }
            else
            {
                comment = EXEILLENT_RESULT_COMMENT;
            }

            return new ExamResult(this.problemsSolved, MIN_PROBLEMS_SOLVED, MAX_PROBLEMS_SOLVED, comment);
        }
    }
}