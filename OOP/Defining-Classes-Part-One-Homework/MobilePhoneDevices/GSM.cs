namespace MobilePhoneDevices
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        private static GSM iPhone4s =
            new GSM("iPhone 4s", "Apple", 900, "Bill Gates", new Battery(BatteryType.NiMH, 200, 15), new Display(4.5m, 2.3m, 16000000));
        
        private string model;
        private string manufacture;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;
        private  List<Call>  callHistory = new List<Call>();
        
        public GSM(string model, string manufacture)
        {
            this.Model = model;
            this.Manufacture = manufacture;
            this.Price = 0;
            this.Owner = null;
            this.Battery = null;
            this.Display = null;
        }
        public GSM(string model, string manufacture, decimal price, string owner)
            : this(model, manufacture)
        {
            this.Price = price;
            this.Owner = owner;
        }
        public GSM(string model, string manufacture, decimal price, string owner, Battery battery, Display display)
            : this(model, manufacture, price, owner)
        {
            this.Battery = battery;
            this.Display = display;
        }

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
        }

        public static GSM IPhone
        {
            get { return iPhone4s; }
        }
        
        public string Model
        {
            get { return this.model; }
            set
            {
                if (value != "" || value == null)
                {
                    this.model = value;
                }
                else
                {
                    throw new Exception("String shouldn't be empty!");
                }
            }
        }
        public string Manufacture
        {
            get { return this.manufacture; }
            set 
            { 
                if( value !=""|| value==null)
                {
                    this.manufacture = value; 
                }
                else
                {
                    throw new Exception("String shouldn't be empty!");
                }
            }
        }
        public decimal Price
        {
            get { return this.price; }
            set 
            { 
                if(value>=0)
                {
                    this.price = value; 
                }
                else
                {
                    throw new Exception("Price must be possitive");
                }
            }
        }
        public string Owner
        {
            get { return this.owner; }
            set {
                if (value != "" || value == null)
                {
                    this.owner = value;
                }
                else
                {
                    throw new Exception("String shouldn't be empty!");
                } 
            }
        }
        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }
        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }
        public override string ToString()
        {
            var result = new StringBuilder();

            if (this.Model != null)
            {
                result.Append("Model: ".PadRight(15, ' '));
                result.Append(this.Model);
                result.AppendLine();
            }
            if (this.Manufacture != null)
            {
                result.Append("Manufacture: ".PadRight(15, ' '));
                result.Append(this.Manufacture);
                result.AppendLine();
            }
            if (this.Price != 0)
            {
                result.Append("Price: ".PadRight(15, ' '));
                result.Append(string.Format("{0:c}", this.Price));
                result.AppendLine();
            }
            if (this.Owner != null)
            {
                result.Append("Owner: ".PadRight(15, ' '));
                result.Append(this.Owner);
                result.AppendLine();
            }
            if (this.Battery != null)
            {
                result.Append("Battery: ".PadRight(15, ' '));
                result.Append(this.Battery.ToString());
                result.AppendLine();
            }
            if (this.Display != null)
            {
                result.Append("Display: ".PadRight(15, ' '));
                result.Append(this.Display.ToString());
                result.AppendLine();
            }
       
            return result.ToString();
        }

        public void AddingCall(Call call)
        {
            this.CallHistory.Add(call);
        }
        public void DelitingCall(Call call)
        {
            this.CallHistory.Remove(call);
        }
        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }
        public decimal TotalPriceOfTheCalls(decimal pricePerMinite)
        {
            List<Call> callHistory = new List<Call>();

            decimal result = 0;
            foreach (Call call in this.CallHistory)
            {
                result += call.Duration;
            }
            return result / 60 * pricePerMinite;
        }
    }
}