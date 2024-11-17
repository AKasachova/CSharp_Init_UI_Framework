using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using AutomationExercise.Utilities;

namespace AutomationExercise.Pages
{
    public class HomePage:Base
    {

        public HomePage()
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@style and contains(text(), 'Home')]")]
        private IWebElement activeHomePageLink;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Signup / Login')]")]
        private IWebElement signupLoginLink;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), ' Logged in as ')]")]
        private IWebElement loggedIn;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Delete Account')]")]
        private IWebElement deleteAccountLink;

        [FindsBy(How = How.XPath, Using = "//a[@href = '/logout']")]
        private IWebElement logoutLink;

        public IWebElement HomePageActive()
        { return activeHomePageLink; }
        public void ClickSignupLoginLink()
        { signupLoginLink.Click(); }
        public string LoggedInText()
        { return loggedIn.Text; }
        public void ClickDeleteAccountLink()
        { deleteAccountLink.Click(); }
        public void ClickLogoutLink()
        { logoutLink.Click(); }

    }
}

