using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

using Utils;

namespace PageObject.Calendar 
{
    public class  CalendarPage 
    {
        private IWebDriver Driver;

        [FindsBy(How = How.XPath, Using = "//li[@id='Ribbon.Calendar.Events-title']/a")]
        IWebElement EventsTabToggle;

        [FindsBy(How = How.XPath, Using = "//span[@id='Ribbon.Calendar.Events.New.NewListItem-Large']/a[1]")]
        IWebElement NewEventButton;
    
        public CalendarPage(BrowserWindow browserWindow) 
        {
            Driver = BrowserWindow.Driver;
            PageFactory.InitElements(this, new RetryingElementLocator(Driver, TimeSpan.FromSeconds(20)));
        }

        public void OpenEventsRibbon() {
            EventsTabToggle.Click();
        }

        public void CreateNewEvent() {
            OpenEventsRibbon();
            NewEventButton.Click();
        }
    }
}

