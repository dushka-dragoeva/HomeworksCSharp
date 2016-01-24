using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.TestAttributes;
using ArtOfTest.WebAii.TestTemplates;
using ArtOfTest.WebAii.Win32.Dialogs;

using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using System.Threading;

namespace TTF_Homework
{
    /// <summary>
    /// Summary description for WebTests
    /// </summary>
    [TestClass]
    public class WebTests : BaseTest
    {

        #region [Setup / TearDown]

        private TestContext testContextInstance = null;
        private object input;

        /// <summary>
        ///Gets or sets the VS test context which provides
        ///information about and functionality for the
        ///current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }


        //Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
        }


        // Use TestInitialize to run code before running each test
        [TestInitialize()]
        public void MyTestInitialize()
        {
            #region WebAii Initialization

            // Initializes WebAii manager to be used by the test case.
            // If a WebAii configuration section exists, settings will be
            // loaded from it. Otherwise, will create a default settings
            // object with system defaults.
            //
            // Note: We are passing in a delegate to the VisualStudio
            // testContext.WriteLine() method in addition to the Visual Studio
            // TestLogs directory as our log location. This way any logging
            // done from WebAii (i.e. Manager.Log.WriteLine()) is
            // automatically logged to the VisualStudio test log and
            // the WebAii log file is placed in the same location as VS logs.
            //
            // If you do not care about unifying the log, then you can simply
            // initialize the test by calling Initialize() with no parameters;
            // that will cause the log location to be picked up from the config
            // file if it exists or will use the default system settings (C:\WebAiiLog\)
            // You can also use Initialize(LogLocation) to set a specific log
            // location for this test.

            // Pass in 'true' to recycle the browser between test methods
            Initialize(true, this.TestContext.TestLogsDir, new TestContextWriteLine(this.TestContext.WriteLine));

            // If you need to override any other settings coming from the
            // config section you can comment the 'Initialize' line above and instead
            // use the following:

            /*

            // This will get a new Settings object. If a configuration
            // section exists, then settings from that section will be
            // loaded

            Settings settings = GetSettings();

            // Override the settings you want. For example:
            settings.Web.DefaultBrowser = BrowserType.FireFox;

            // Now call Initialize again with your updated settings object
            Initialize(settings, new TestContextWriteLine(this.TestContext.WriteLine));

            */

            // Set the current test method. This is needed for WebAii to discover
            // its custom TestAttributes set on methods and classes.
            // This method should always exist in [TestInitialize()] method.
            SetTestMethod(this, (string)TestContext.Properties["TestName"]);

            #endregion

            //
            // Place any additional initialization here
            //

        }

        // Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup()
        {

            //
            // Place any additional cleanup here
            //

            #region WebAii CleanUp

            // Shuts down WebAii manager and closes all browsers currently running
            // after each test. This call is ignored if recycleBrowser is set
            this.CleanUp();

            #endregion
        }

        //Use ClassCleanup to run code after all tests in a class have run
        [ClassCleanup()]
        public static void MyClassCleanup()
        {
            // This will shut down all browsers if
            // recycleBrowser is turned on. Else
            // will do nothing.
            ShutDown();
        }

        #endregion

        [TestMethod]
        public void GoogleSearchTtfkDownloads()
        {
            Manager.LaunchNewBrowser();
            ActiveBrowser.NavigateTo(@"https://www.google.com/ ");

            var input = Find.ById<HtmlInputText>("lst-ib");
            input.MouseClick();
            Manager.Desktop.KeyBoard.TypeText("Telerik Testing Framework");
            Manager.Desktop.KeyBoard.KeyPress(Keys.Enter, 100);

            Thread.Sleep(2000);
            Manager.ActiveBrowser.RefreshDomTree();

            var expectedFirstResult = @"http://www.telerik.com/teststudio/testing-framework";
            var actualFirstResult = Find.ByXPath<HtmlAnchor>("//*/div[@id='ires']/ol/div/div[1]/div/h3/a");

            Assert.AreEqual(expectedFirstResult, actualFirstResult.HRef);
            actualFirstResult.Click();

            ActiveBrowser.WaitForElement(5000, "id=?HyperLink");
            Find.ByExpression<HtmlAnchor>("id=?HyperLink").Click();

            var result = Find.AllByExpression("tagname=h2").FirstOrDefault();
            Assert.IsTrue(result.InnerText.Contains("Download Testing Framework"));
        }

        [TestMethod]
        public void SortingKendoGridTest()
        {
            Manager.LaunchNewBrowser();
            ActiveBrowser.NavigateTo(@"http://www.telerik.com/support/demos");

            ActiveBrowser.WaitForElement(5000, "tagname=img", "title=kendo-ui");

            Find.AllByContent<HtmlAnchor>("p:Kendo UI demos", FindContentType.InnerText).FirstOrDefault().Click();

            ActiveBrowser.WaitForElement(5000, "tagname=a", "innertext=Grid");
            Manager.ActiveBrowser.Window.Maximize();

            Find.AllByContent<HtmlAnchor>("p:Grid", FindContentType.InnerText).FirstOrDefault().Click();

            ActiveBrowser.WaitForElement(5000, "tagname=a", "innertext=Initialization from table");
            Find.AllByContent<HtmlAnchor>("p:Initialization from table", FindContentType.InnerText).FirstOrDefault().Click();

            ActiveBrowser.WaitForElement(2000, "id=grid");
            var tableHeaders = Find.AllByAttributes<HtmlAnchor>("class=k-link");
            var gridTable = Find.ByExpression<HtmlControl>("tagname=tbody", "role=rowgroup").ChildNodes;

            Assert.IsNotNull(gridTable);
            Assert.AreEqual(5, tableHeaders.Count);
            Assert.AreEqual(21, gridTable.Count);

            for (int i = 0; i < tableHeaders.Count; i++)
            {
                tableHeaders[i].Click();
                ActiveBrowser.RefreshDomTree();
                gridTable = Find.ByExpression<HtmlControl>("tagname=tbody", "role=rowgroup").ChildNodes;
                var element = gridTable.FirstOrDefault().ChildNodes[i].InnerText;

                for (int j = 1; j < gridTable.Count; j++)
                {
                    var elementToCompare = gridTable[j].ChildNodes[i].InnerText;
                    Assert.IsTrue(element.CompareTo(elementToCompare) <= 0);
                    element = elementToCompare;
                }

                tableHeaders[i].Click();
                ActiveBrowser.RefreshDomTree();
                gridTable = Find.ByExpression<HtmlControl>("tagname=tbody", "role=rowgroup").ChildNodes;
                element = gridTable.FirstOrDefault().ChildNodes[i].InnerText;

                for (int j = 1; j < gridTable.Count; j++)
                {
                    var elementToCompare = gridTable[j].ChildNodes[i].InnerText;
                    Assert.IsTrue(element.CompareTo(elementToCompare) >= 0);
                    element = elementToCompare;
                }
            }
        }
    }
}
