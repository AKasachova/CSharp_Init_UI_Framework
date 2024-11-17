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
    public class UserLogout : Base
    {

        [Test]
        public void UserSuccessfullyLoggedOut()
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

            homePage.ClickLogoutLink();

            var loginPage2 = new LoginPage();
            Assert.AreEqual(loginPage2.getLoginTitle(), "Login to your account");
        }

    }
}
