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
    public class SuccessfullUserLogin: Base
    {

        [Test]
        public void UserSuccessfullyLoggedInWithCorrectCreds()
        {
            var homePage = new HomePage();
            var activePage = homePage.HomePageActive();
            Assert.IsTrue(activePage.Displayed, "Home Page is not displayed");

            homePage.ClickSignupLoginLink();

            var loginPage = new LoginPage();
            var loginTitle = loginPage.getLoginTitle();

            Assert.AreEqual(loginTitle, "Login to your account");

            loginPage.Login("Admin1@test.com", "password");

            var loggedInText = homePage.LoggedInText();
            Assert.AreEqual(loggedInText, "Logged in as Admin1name");

            homePage.ClickDeleteAccountLink();

            AccounDeletedPage accountDeletedPage = new AccounDeletedPage();
            Assert.AreEqual(accountDeletedPage.GetAccountDeletedTitle(), "ACCOUNT DELETED!");  
        }

    }
}
