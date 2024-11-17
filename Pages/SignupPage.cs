using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using AutomationExercise.Utilities;
using OpenQA.Selenium.Support.UI;

namespace AutomationExercise.Pages
{
    public class SignupPage : Base
    {
        public SignupPage()
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "h2 b")]
        private IWebElement signupTitle;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'radio-inline'][1]")]
        private IWebElement titleRadioButtom;

        [FindsBy(How = How.Id, Using = "name")]
        private IWebElement nameTextField;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement passwordTextField;

        [FindsBy(How = How.Id, Using = "days")]
        private IWebElement daysDropDown;

        [FindsBy(How = How.Id, Using = "months")]
        private IWebElement monthsDropDown;

        [FindsBy(How = How.Id, Using = "years")]
        private IWebElement yearsDropDown;

        [FindsBy(How = How.Id, Using = "newsletter")]
        private IWebElement newsletterCheckbox;

        [FindsBy(How = How.Id, Using = "newsletter")]
        private IWebElement optinCheckbox;

        [FindsBy(How = How.Id, Using = "first_name")]
        private IWebElement firstNameTextField;

        [FindsBy(How = How.Id, Using = "last_name")]
        private IWebElement lastNameTextField;

        [FindsBy(How = How.Id, Using = "address1")]
        private IWebElement addressTextField;

        [FindsBy(How = How.Id, Using = "company")]
        private IWebElement companyTextField;

        [FindsBy(How = How.Id, Using = "country")]
        private IWebElement countryDropDown;

        [FindsBy(How = How.Id, Using = "state")]
        private IWebElement stateTextField;

        [FindsBy(How = How.Id, Using = "city")]
        private IWebElement cityTextField;

        [FindsBy(How = How.Id, Using = "zipcode")]
        private IWebElement zipcodeTextField;

        [FindsBy(How = How.Id, Using = "mobile_number")]
        private IWebElement mobileNumberTextField;

        [FindsBy(How = How.CssSelector, Using = "button[data-qa='create-account']")]
        private IWebElement createAccountButton;

        public string GetSignupTitle()
        {
            var title = signupTitle.Text;
            return title;
        }
        public void FillAndSubmitSugnupForm(string name, string password, string firstName, string lastName)
        {
            titleRadioButtom.Click();
            nameTextField.SendKeys(name);
            passwordTextField.SendKeys(password);
            SelectElement selectDay = new SelectElement(daysDropDown);
            selectDay.SelectByValue("1");
            SelectElement selectMonth = new SelectElement(monthsDropDown);
            selectMonth.SelectByValue("1");
            SelectElement selectYear = new SelectElement(yearsDropDown);
            selectYear.SelectByText("1991");
            newsletterCheckbox.Click();
            optinCheckbox.Click();
            firstNameTextField.SendKeys(firstName);
            lastNameTextField.SendKeys(lastName);
            addressTextField.SendKeys("some street");
            companyTextField.SendKeys("Vention");
            SelectElement selectCountry = new SelectElement(countryDropDown);
            selectCountry.SelectByValue("Canada");
            stateTextField.SendKeys("Alabama");
            cityTextField.SendKeys("Minsk");
            zipcodeTextField.SendKeys("12345");
            mobileNumberTextField.SendKeys("1111111111");
            createAccountButton.Click();
        }
    }
}
