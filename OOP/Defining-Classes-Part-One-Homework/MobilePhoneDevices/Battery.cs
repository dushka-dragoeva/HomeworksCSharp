namespace MobilePhoneDevices
{
    using System;
    using System.Text;
   
    public class Battery
    {
        private BatteryType batteryModel;
        private int? hoursIdle;
        private int? hoursTalk;

        public Battery(BatteryType batteryModel)
        {
            this.BatteryModel = batteryModel;
            this.HoursIdle = null;
            this.HoursTalk = null;
        }
        public Battery(BatteryType batteryModel, int hoursIdle, int hoursTalk)
        {
            this.BatteryModel = batteryModel;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public BatteryType BatteryModel
        {
            get { return this.batteryModel; }
            set { this.batteryModel = value; }
        }
        public int? HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }

        public int? HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }

        public override string ToString()
        {
          var output = new StringBuilder();

          
            output.Append(this.BatteryModel);
            output.Append("  ");

            if (this.HoursIdle != null)
            {
                output.Append(this.HoursIdle);
                output.Append(" hours idle , ");
            }
            if (this.HoursTalk != null)
            {
                output.Append(this.HoursTalk);
                output.Append(" hours talk.");
            }

            string result = output.ToString();
            return result;
        }
    }
}