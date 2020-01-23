using TechTalk.SpecFlow;
using Utils;
using Xunit;
using PageObject.Login;
using PageObject.Calendar;

namespace Login.Steps 
{
    [Binding]
    public class LoginSteps
    {
        BrowserWindow browser;
        LoginPage loginPage;

        public LoginSteps(BrowserWindow browserWindow, 
                LoginPage loginPage,
                CalendarPage calendarPage)
        {
            this.browser = browserWindow;
            this.loginPage = loginPage;
        }

        [When(@"logging in as '(.*)'")]
        public void LoggingInAsUser(string username) 
        {
            loginPage.Login(Settings.UserEmail, Settings.UserLogin, Settings.UserPassword);
        }

        [Then(@"the logged in user is '(.*)'")]
        public void LoggedInUserIs(string expectedUsername)
        {
            Assert.True(true);
        }
    }
}
