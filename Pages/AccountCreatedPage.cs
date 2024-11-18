using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using AutomationExercise.Utilities;

namespace AutomationExercise.Pages
{
    public class AccountCreatedPage: BrowserInitialization
    {
        public AccountCreatedPage()
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//h2[@data-qa = 'account-created']")]
        private IWebElement accountCreatedTitle;

        [FindsBy(How = How.XPath, Using = "//a[@data-qa = 'continue-button']")]
        private IWebElement continueButton;

        public string GetAccountCreatedTitle()
        { return accountCreatedTitle.Text; }
        public void ClickContinueButton()
        {
            continueButton.Click();
        }
    }
}