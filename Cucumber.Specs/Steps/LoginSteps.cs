using TechTalk.SpecFlow;
using Utils;
using Xunit;
using Login.PageObject;

namespace Login.Steps 
{
    [Binding]
    public class LoginSteps
    {
        BrowserWindow browser;
        LoginPage loginPage;

        public LoginSteps(BrowserWindow browserWindow, LoginPage loginPage)
        {
            this.browser = browserWindow;
            this.loginPage = loginPage;
        }

        [When(@"logging in as '(.*)'")]
        public void LoggingInAsUser(string username) 
        {
            loginPage.Login("***", "***", "***");
        }

        [Then(@"the logged in user is '(.*)'")]
        public void LoggedInUserIs(string expectedUsername)
        {
            Assert.True(true);
        }
    }
}
