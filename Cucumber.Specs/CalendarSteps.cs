using TechTalk.SpecFlow;
using Utils;
using Xunit;
using PageObject.Calendar;

namespace Calendar.Steps
{
    [Binding]
    public class CalendarSteps
    {
        BrowserWindow browser;
        CalendarPage calendarPage;

        public CalendarSteps(BrowserWindow browserWindow,
                CalendarPage calendarPage)
        {
            this.browser = browserWindow;
            this.calendarPage = calendarPage;
        }

        [When(@"entering christmas vacation")]
        public void EnterChristmasVacation() 
        {
            calendarPage.CreateNewEvent();
        }
    }
}
