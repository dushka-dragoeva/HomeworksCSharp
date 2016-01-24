namespace Mobile_Testing_Homework.Core.Layouts.StartLayout
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium.Appium.Android;

    public static class StartLAyoutAsserter
    {
        public static void AssertSeekBarIsEnabled(this StartLayout startScreen)
        {
            Assert.IsTrue(startScreen.SeekBar.Enabled);
        }

        public static void AssertSeekBarIsDisabled(this StartLayout startScreen)
        {
            Assert.IsFalse(startScreen.SeekBar.Enabled);
        }

        public static void AssertTextIsDiffernt(this StartLayout startScreen, AndroidElement element, string newText)
        {
            Assert.AreNotEqual(element.Text, newText);
        }

        public static void AssertTextIsUpdated(this StartLayout startScreen, AndroidElement element, string newText)
        {
            Assert.AreEqual(element.Text, newText);
        }
    }
}
