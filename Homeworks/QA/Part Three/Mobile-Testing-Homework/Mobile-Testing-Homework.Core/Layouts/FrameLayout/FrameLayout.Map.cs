namespace Mobile_Testing_Homework.Core.Layouts.FrameLayout
{
    using OpenQA.Selenium.Appium.Android;

    public partial class FrameLayout
    {
        public AndroidElement Name
        {
            get
            {
                return this.Driver.FindElementByClassName("android.widget.EditText");
            }
        }

        public AndroidElement OkButton
        {
            get
            {
                return this.Driver.FindElementById("android:id/button1");
            }
        }
    }
}
