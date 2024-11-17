using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace AutomationExercise.Utilities
{
    
    public class Base
    {
        protected static IWebDriver driver; 

        [SetUp]
        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("https://automationexercise.com/");
            Thread.Sleep(1000);
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}