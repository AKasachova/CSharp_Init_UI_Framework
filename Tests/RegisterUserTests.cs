using AutomationExercise.Pages;
using AutomationExercise.Utilities;
using NUnit.Framework.Internal;

namespace AutomationExercise.Tests
{
    public class RegisterUserTests : BrowserInitialization
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
            LoginPage loginPage = new LoginPage();
            string loginTitle = loginPage.getSignupTitle();
            //To ask Andrey wtf?
            Assert.AreEqual(loginTitle, "New User Signup!");

            loginPage.Signup("Aliona", "Admin2@test.com");
            string existingEmailMessage = loginPage.GetExistingEmailMessage();
            Assert.AreEqual(existingEmailMessage, "Email Address already exist!");
        }
    }
}