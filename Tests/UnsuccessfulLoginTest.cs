using AutomationExercise.Pages;
using AutomationExercise.Utilities;

namespace AutomationExercise.Tests
{
    public class UnsuccessfulLogin : BrowserInitialization
    {

        [Test]
        public void UnsuccessfulLoginForUserWithIncorrectCredentials()
        {
            var homePage = new HomePage();
            var activePage = homePage.HomePageActive();
            Assert.IsTrue(activePage.Displayed, "Home Page is not displayed");

            homePage.ClickSignupLoginLink();

            var loginPage = new LoginPage();
            var loginTitle = loginPage.getLoginTitle();
            Assert.AreEqual(loginTitle, "Login to your account");

            loginPage.Login("1@we.com", "1");
            Assert.IsNotNull(loginPage.getIncorrectLoginMessage(), "Error message is not displayed!");

        }
    }
}
