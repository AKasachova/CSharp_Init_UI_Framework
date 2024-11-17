using AutomationExercise.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationExercise.Utilities;
using System.Xml.Linq;

namespace AutomationExercise.Tests
{
    public class RegisterUserTests:Base
    {

        [Test]
        public void UserRegisteredSuccessfully()
        {
            var homePage = new HomePage();
            var activePage = homePage.HomePageActive();
            Assert.IsTrue(activePage.Displayed, "Home Page is not displayed");

            homePage.ClickSignupLoginLink();

            var loginSignupPage = new LoginPage();
            var loginSignupTitle = loginSignupPage.getSignupTitle();

            Assert.AreEqual(loginSignupTitle, "New User Signup!");

            loginSignupPage.Signup("Admin1", "Admin1@test.com");

            var signupPage = new SignupPage();
            Assert.AreEqual(signupPage.GetSignupTitle(), "ENTER ACCOUNT INFORMATION");

            signupPage.FillAndSubmitSugnupForm("name", "password", "firstName", "lastName");

            AccountCreatedPage accountCreatedPage = new AccountCreatedPage();
            Assert.AreEqual(accountCreatedPage.GetAccountCreatedTitle(), "ACCOUNT CREATED!");
            accountCreatedPage.ClickContinueButton();

            var loggedInText = homePage.LoggedInText();
            Assert.AreEqual(loggedInText, "Logged in as Admin1name");

        }

        [Test]
        public void RegisterExistingUserUnsucessfully()
        {
            HomePage homePage = new HomePage();
            var activePage = homePage.HomePageActive();
            Assert.IsTrue(activePage.Displayed, "Home Page is not displayed");

            homePage.ClickSignupLoginLink();
            SignupPage signupPage = new SignupPage();
            //exceptioin !! string signupPageTitle = signupPage.GetSignupTitle();
            // Assert.AreEqual(signupPageTitle, "New User Signup!");



        }
    }
}