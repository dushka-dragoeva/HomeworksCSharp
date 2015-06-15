namespace StudentsAndWorkers
{
    using System;

    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;


        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            private set
            {
                if (value < 80.00m)
                {
                    throw new ArgumentException("Salary can't be less than 80.00");
                }

                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {

             get { return this.workHoursPerDay; }
            private set
            {
                if (value < 4 || value >= 13)
                {
                    throw new ArgumentException("Work hours must be between 4 and 12.");
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour(int workingDays)
        {
            decimal moneyPerHour = this.WeekSalary / (workingDays *(decimal) this.WorkHoursPerDay);
            return moneyPerHour;
        }
    }
}
