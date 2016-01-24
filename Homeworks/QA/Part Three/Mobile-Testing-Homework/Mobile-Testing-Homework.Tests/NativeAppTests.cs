namespace Mobile_Testing_Homework.Tests
{
    using System;
    using System.Collections.Generic;
    using Core.Layouts.FrameLayout;
    using Core.Layouts.StartLayout;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium.Appium;
    using OpenQA.Selenium.Appium.Android;
    using OpenQA.Selenium.Appium.Service;
    using OpenQA.Selenium.Appium.Service.Options;
    using OpenQA.Selenium.Remote;

    [TestClass]
    public class NativeAppTests
    {
        private const string Path = "E:\\Terelik\\QA\\QAPartThree\\HomeWork\\Mobile-Testing-Homework\\Mobile-Testing-Homework.Tests\\testapp\\fitness-debug.apk";
        private static AppiumLocalService service;
        private static AppiumDriver<AndroidElement> driver;

        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return this.testContextInstance;
            }

            set
            {
                this.testContextInstance = value;
            }
        }

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            // Start Appium Server
            var avdOptions = new KeyValuePair<string, string>("--avd", "MyDeviceDemo");
            var avdParamsOptions = new KeyValuePair<string, string>("--avd-args", "\"-scale 0.50\"");
            OptionCollector emulatorArguments = new OptionCollector();
            emulatorArguments.AddArguments(avdOptions);
            emulatorArguments.AddArguments(avdParamsOptions);

            service = new AppiumServiceBuilder()
                .WithArguments(emulatorArguments)
                .UsingAnyFreePort()
                .Build();
            service.Start();

            Assert.IsTrue(service.IsRunning);

            // Start Appium Client
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability("deviceName", "MyDeviceDemo");
            capabilities.SetCapability("app", Path);
            driver = new AndroidDriver<AndroidElement>(service.ServiceUrl, capabilities, TimeSpan.FromSeconds(180));
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            driver.Quit();
            service.Dispose();
        }

        [TestInitialize]
        public void TestInit()
        {
            driver.ResetApp();
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [TestMethod]
        public void NotificatinsTest()
        {
            StartLayout layout = new StartLayout(driver);

            layout.AssertSeekBarIsEnabled();
            layout.ChangeNotifications();

            layout.AssertSeekBarIsDisabled();
        }

        [TestMethod]
        public void UpdateValuesTest()
        {
            StartLayout layout = new StartLayout(driver);

            string newHeight = "160";
            layout.UpdateHeigt(newHeight);

            string newWeight = "50";
            layout.UpdateWeight(newWeight);

            layout.AssertTextIsUpdated(layout.Height, newHeight);
            layout.AssertTextIsUpdated(layout.Weight, newWeight);

            driver.BackgroundApp(10);
            layout.AssertTextIsUpdated(layout.Height, newHeight);
            layout.AssertTextIsUpdated(layout.Weight, newWeight);
        }

        [TestMethod]
        public void UpdateNameTest()
        {
            StartLayout layout = new StartLayout(driver);
            FrameLayout frame = new FrameLayout(driver);
            string newName = "Pepi Petrov";

            layout.UpdateName(newName);
            layout.AssertTextIsUpdated(layout.EditNameButton, newName);

            driver.BackgroundApp(10);
            layout.AssertTextIsUpdated(layout.EditNameButton, newName);
        }
    }
}
