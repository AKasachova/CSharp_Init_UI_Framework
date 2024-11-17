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
    public class UnsuccessfulLogin : Base
    {

        [Test]
        public void UnuccessfulLoginForUserWithIncorrectCreds()
        {
            var homePage = new HomePage();
            var activePage = homePage.HomePageActive();
            Assert.IsTrue(activePage.Displayed, "Home Page is not displayed");

            homePage.ClickSignupLoginLink();

            var loginPage = new LoginPage();
            var loginTitle = loginPage.getLoginTitle();

            Assert.AreEqual(loginTitle, "Login to your account");

            loginPage.Login("1@we.com", "1");
            // Explicit waiter

            Assert.IsNotNull(loginPage.getIncorrectLoginMessage(), "Error message is not displayed!");

        }

    }
}
