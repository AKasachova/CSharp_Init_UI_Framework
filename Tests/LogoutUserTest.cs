using AutomationExercise.Pages;
using AutomationExercise.Utilities;

namespace AutomationExercise.Tests
{
    public class UserLogout : BrowserInitialization
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

            loginPage.Login("Admin2@test.com", "password2");
            var loggedInText = homePage.LoggedInText();
            Assert.IsTrue(loggedInText.Contains("Logged in as"), "The user is not logged in");

            homePage.ClickLogoutLink();

            var loginPage2 = new LoginPage();
            Assert.AreEqual(loginPage2.getLoginTitle(), "Login to your account");
        }
    }
}
