using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using WebDriverManager.DriverConfigs.Impl;

namespace AutomationExercise.Utilities
{
    
    public class BrowserInitialization
    {
        protected static IWebDriver driver; 

        [SetUp]
        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();

            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://automationexercise.com/");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement consentButton = wait.Until(driver =>
            {
                var element = driver.FindElement(By.CssSelector("button.fc-cta-consent"));
                return element.Displayed ? element : null;
            });
            consentButton.Click();
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}