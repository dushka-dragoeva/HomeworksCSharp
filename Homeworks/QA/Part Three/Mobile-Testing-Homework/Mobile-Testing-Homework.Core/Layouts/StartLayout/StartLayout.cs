namespace Mobile_Testing_Homework.Core.Layouts.StartLayout
{
    using System.Threading;
    using OpenQA.Selenium.Appium;
    using OpenQA.Selenium.Appium.Android;

    public partial class StartLayout
    {
        public StartLayout(AppiumDriver<AndroidElement> driver)
        {
            this.Driver = driver;
        }

        public AppiumDriver<AndroidElement> Driver { get; set; }

        public void ChangeNotifications()
        {
            this.Vibrate.Click();
            this.Sound.Click();
        }

        public void UpdateHeigt(string text)
        {
            this.UpdateText(this.Height, text);
            this.AssertTextIsUpdated(this.Height, text);
        }

        public void UpdateWeight(string text)
        {
            this.UpdateText(this.Weight, text);
            this.AssertTextIsUpdated(this.Weight, text);
        }

        public void UpdateText(AndroidElement element, string newText)
        {
            this.AssertTextIsDiffernt(element, newText);
            element.Clear();
            element.SendKeys(newText);
        }

        public void UpdateName(string newName)
        {
            this.AssertTextIsDiffernt(this.EditNameButton, newName);
            this.EditNameButton.Click();
            this.UpdateText(this.Frame.Name, newName);
            this.Frame.OkButton.Click();
            this.AssertTextIsUpdated(this.EditNameButton, newName);
        }
    }
}
