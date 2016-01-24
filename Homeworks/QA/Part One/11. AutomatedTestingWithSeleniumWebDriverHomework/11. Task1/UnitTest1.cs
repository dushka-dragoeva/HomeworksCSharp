/*Log in in http://www.stage.telerikacademy.com/. Use appropriate validations to create a good test
Go to “Settings” and fill in all the fields with information about yourself
Save changes and verity that updated information is shown on your profile page
*/

namespace _11.Task1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Firefox;



    [TestClass]
    public class UnitTest1
    {
      

        [TestInitialize]
        public void SetupTest()
        {


        }


        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.stage.telerikacademy.com/";
            IWebElement login = driver.FindElement(By.Id("EntranceButton"));

            
        }
    }
}
