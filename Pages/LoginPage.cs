using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using AutomationExercise.Utilities;

namespace AutomationExercise.Pages
{
    public class LoginPage:Base
    {
        public LoginPage()
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//h2[contains(text(), 'New User Signup!')]")]
        private IWebElement signupTitle;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'login-form']/h2")]
        private IWebElement loginTitle;

        [FindsBy(How = How.XPath, Using = "//input[@data-qa = 'signup-name']")]
        private IWebElement newUserName;

        [FindsBy(How = How.XPath, Using = "//input[@data-qa = 'signup-email']")]
        private IWebElement newUserEmail;

        [FindsBy(How = How.XPath, Using = "//input[@data-qa = 'login-email']")]
        private IWebElement userEmail;

        [FindsBy(How = How.XPath, Using = "//input[@data-qa = 'login-password']")]
        private IWebElement userPassword;

        [FindsBy(How = How.XPath, Using = "//button[@data-qa = 'signup-button']")]
        private IWebElement signupButton;

        [FindsBy(How = How.XPath, Using = "//button[@data-qa = 'login-button']")]
        private IWebElement loginButton;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(), 'Your email or password is incorrect!')]")]
        private IWebElement incorrectLoginText;

        public string getSignupTitle()
        { return signupTitle.Text; }
        public string getLoginTitle()
        { return loginTitle.Text; }
        public IWebElement getIncorrectLoginMessage()
        { return incorrectLoginText; }
        public void Signup(string name, string password)
        {
            newUserName.SendKeys(name);
            newUserEmail.SendKeys(password);
            signupButton.Click(); 
        }
        public void Login(string email, string password)
        {
            userEmail.SendKeys(email);
            userPassword.SendKeys(password);
            loginButton.Click();
        }
    }
}
