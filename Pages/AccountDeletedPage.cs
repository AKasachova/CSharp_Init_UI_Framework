using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using AutomationExercise.Utilities;

namespace AutomationExercise.Pages
{
    public class AccounDeletedPage : Base
    {
        public AccounDeletedPage()
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//h2[@data-qa = 'account-deleted']")]
        private IWebElement accountDeletedTitle;
        public string GetAccountDeletedTitle()
        { return accountDeletedTitle.Text; }
    }
}