using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

using Utils;

namespace PageObject.Login
{
    public class LoginPage 
    {
        private IWebDriver Driver;

        [FindsBy(How = How.Name, Using = "loginfmt")]
        public IWebElement Email;

        [FindsBy(How = How.Id, Using = "idSIButton9")]
        public IWebElement SubmitEmail;

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement Username;

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement Password;

        [FindsBy(How = How.Name, Using = "submit")]
        public IWebElement SubmitLogin;

        [FindsBy(How = How.XPath, Using = "//*[text()='Stay signed in?']")]
        public IWebElement StaySignedInText;

        public LoginPage(BrowserWindow browserWindow) 
        {
            Driver = BrowserWindow.Driver;
            PageFactory.InitElements(this, new RetryingElementLocator(Driver, TimeSpan.FromSeconds(20)));
        }

        public void Login(string email, string username, string password)
        {
            Driver.Url = Settings.LoginUrl;

            EnterAndSubmitEmail(email);
            SubmitUsernameAndPassword(username, password);

            SubmitEmail.Click();
        }

        public void EnterAndSubmitEmail(string email)
        {
            Email.Clear();
            Email.SendKeys(email);

            SubmitEmail.Click();
        }

        public void SubmitUsernameAndPassword(string username, string password)
        {
            Username.Clear();
            Username.SendKeys(username); 
            Password.Clear(); 
            Password.SendKeys(password);

            SubmitLogin.Click();
        }
    }
}
