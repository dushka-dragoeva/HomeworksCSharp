namespace MobilePhoneDevices
{
    using System;
    using System.Text;
   
    public class Display
    {
        private decimal sizeX;
        private decimal sizeY;
        private ulong numberOfColors;

        public Display(decimal sizeX, decimal sizeY, ulong numberOfColors)        
       {
           this.sizeX = sizeX;
           this.sizeY = sizeY;
           this.numberOfColors = numberOfColors;
       }

        public decimal SizeX
        {
            get { return this.sizeX; }
            set { this.sizeX = value; }
        }
        public decimal SizeY
        {
            get { return this.sizeY; }
            set { this.sizeY = value; }
        }
        public ulong NumberOfColors
        {
            get { return this.numberOfColors; }
            set { this.numberOfColors = value; }
        }
        public override string ToString()
        {
            var output =new StringBuilder();
            output.Append(string.Format(string.Format("Height: {0}cm , Width: {1}cm, Colors: {2}"
                , this.SizeX, this.SizeY, this.NumberOfColors)));
            return output.ToString();
        }
    }
}
