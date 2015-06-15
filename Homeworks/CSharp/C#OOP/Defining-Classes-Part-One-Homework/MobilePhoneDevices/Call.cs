namespace MobilePhoneDevices
{
    using System;
    using System.Text;
    public class Call
    {
        private DateTime date;
        private string dailedNumber;
        private int duration;

        public Call(DateTime date, string dailedNumber, int duration)
        {
            this.Date = date;
            this.DailedNumber = dailedNumber;
            this.Duration = duration;
        }
        public DateTime Date
        {
            get { return this.date; }
            private set { this.date = value; }
        }

        public string DailedNumber
        {
            get { return this.dailedNumber; }
            private set { this.dailedNumber = value; }
        }

        public int Duration
        {
            get { return this.duration; }
            private set
            {
                if (value >= 0)
                {
                    this.duration = value;
                }
                else
                {
                    throw new Exception("Duration of call can not be negative number");
                }
            }
        }

        public override string ToString()
        {
            var output = new System.Text.StringBuilder();

            output.Append(String.Format("On {0:dd.MM.yyyy HH:mm:ss} dailed number: {1}, duration:{2,5} seconds."
                , this.Date, this.DailedNumber, this.Duration));

            return output.ToString();
        }
    }
}