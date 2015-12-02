using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LiveDemo2014
{
    class Program
    {
        static void Main(string[] args)
        {
            var urlTelerik = @"http://www.telerik.com";
            IWebDriver driver = new FirefoxDriver();
            //driver.Url = urlTelerik;
            //driver.Navigate().GoToUrl(urlTelerik);
            //Console.WriteLine(driver.Title);
            //driver.Quit();

            // za namirane na elementi se izpolzva interface

            //IWebElement element = driver.FindElement(By.Id("coolestWidgetEvah"));
            //IList<IWebElement> cheeses = driver.FindElements(By.ClassName("cheese"));
            //IWebElement frame = driver.FindElement(By.TagName("iframe"));

            // chaning is enabled

            //IWebElement cheese = driver.FindElement(By.ClassName("firstElementTable"))
            //    .FindElement(By.Id("secondElement"));

            //with XPath and XPathAxes
            driver.Navigate().GoToUrl(@"http://www.tutorialspoint.com/html/html_tables.htm");
            IWebElement element = driver.FindElement(By.XPath("//td[contains(text(),'Shabbir')]/following-sibling::td[1]"));
            Console.WriteLine(element.Text);
        }
    }
}
