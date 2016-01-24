namespace Mobile_Testing_Homework.Core.Layouts.StartLayout
{
    using FrameLayout;
    using OpenQA.Selenium.Appium.Android;

    public partial class StartLayout
    {
        public AndroidElement Vibrate
        {
            get
            {
                return this.Driver.FindElementsByClassName("android.widget.Switch")[0];
            }
        }

        public AndroidElement Sound
        {
            get
            {
                return this.Driver.FindElementsByClassName("android.widget.Switch")[1];
            }
        }

        public AndroidElement SeekBar
        {
            get
            {
                return this.Driver.FindElementByClassName("android.widget.SeekBar");
            }
        }

        public AndroidElement Height
        {
            get
            {
                return this.Driver.FindElementsByClassName("android.widget.EditText")[0];
            }
        }

        public AndroidElement Weight
        {
            get
            {
                return this.Driver.FindElementsByClassName("android.widget.EditText")[1];
            }
        }

        public AndroidElement EditNameButton
        {
            get
            {
                return this.Driver.FindElementByClassName("android.widget.Button");
            }
        }

        public FrameLayout Frame
        {
            get
            {
                return new FrameLayout(this.Driver);
            }
        }
    }
}
