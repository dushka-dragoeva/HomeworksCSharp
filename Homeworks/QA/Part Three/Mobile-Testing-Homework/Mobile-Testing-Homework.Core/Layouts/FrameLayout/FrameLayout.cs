namespace Mobile_Testing_Homework.Core.Layouts.FrameLayout
{ 
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium.Appium;
    using OpenQA.Selenium.Appium.Android;

    public partial class FrameLayout
    {
        public FrameLayout(AppiumDriver<AndroidElement> driver)
        {
            this.Driver = driver;
        }

        public AppiumDriver<AndroidElement> Driver { get; set; }

        public void UpdateName(AndroidElement element, string newText)
        {
            element.Clear();
            element.SendKeys(newText);
        }
    }
}
