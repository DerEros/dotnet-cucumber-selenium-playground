using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

using Utils;

namespace PageObject.CalendarEntryForm {
    public class CalendarEntryForm
    {
        private IWebDriver Driver;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'ms-dlgFrameContainer')]/iframe")]
        IWebElement DialogIFrame;

        [FindsBy(How = How.Id, Using = "ctl00_ctl33_g_b61cf1d3_bdcc_4767_803e_7874c477db42_ctl00_ctl05_ctl00_ctl00_ctl00_ctl05_ctl00_ctl00_TextField")]
        IWebElement TitleField;
        IWebElement LocationField;
        IWebElement StartTimeField;
        IWebElement EndTimeField;
        IWebElement DescriptionField;
        IWebElement CategoryField;
        IWebElement AllDayEventField;
        IWebElement RecurrenceField;

        [FindsBy(How = How.Id, Using = "ctl00_ctl33_g_b61cf1d3_bdcc_4767_803e_7874c477db42_ctl00_toolBarTbl_RightRptControls_ctl00_ctl00_diidIOSaveItem")]
        IWebElement SaveButton;
        IWebElement CancelButton;

        public CalendarEntryForm(BrowserWindow browserWindow)
        {
            Driver = BrowserWindow.Driver;
            PageFactory.InitElements(this, new RetryingElementLocator(Driver, TimeSpan.FromSeconds(20)));
        }

        public void CreateAndStore(string title = "Title",
                string location = "",
                string startTime = "1/1/1970",
                string endTime = "1/1/1970",
                string description = "")
        {
            WaitForDialog();
            Driver.SwitchTo().Frame(DialogIFrame);
            Title = title;
            /*
            Location = location;
            StartTime = startTime;
            EndTime = endTime;
            Description = description;
            */

            Save();
            Driver.SwitchTo().DefaultContent();
        }

        public string Title {
            get { return TitleField.Text; }
            set { ClearAndEnter(TitleField, value); }
        }

        public string Location {
            get { return LocationField.Text; }
            set { ClearAndEnter(LocationField, value); }
        }

        public string StartTime {
            get { return StartTimeField.Text; }
            set { ClearAndEnter(StartTimeField, value); }
        }

        public string EndTime {
            get { return EndTimeField.Text; }
            set { ClearAndEnter(EndTimeField, value); }
        }

        public string Description {
            get { return DescriptionField.Text; }
            set { ClearAndEnter(DescriptionField, value); }
        }

        public void ClearAndEnter(IWebElement element, string value) 
        {
            element.Clear();
            element.SendKeys(value);
        }

        public void Save()
        {
            SaveButton.Click();
        }

        public void Cancel()
        {
            CancelButton.Click();
        }

        public void WaitForDialog() 
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            wait.Until(driver => { return DialogIFrame.Displayed; } );
        }
    }
}
