using TechTalk.SpecFlow;
using Utils;
using Xunit;
using PageObject.Calendar;
using PageObject.CalendarEntryForm;

namespace Calendar.Steps
{
    [Binding]
    public class CalendarSteps
    {
        BrowserWindow browser;
        CalendarPage calendarPage;
        CalendarEntryForm calendarEntryForm;

        public CalendarSteps(BrowserWindow browserWindow,
                CalendarPage calendarPage,
                CalendarEntryForm calendarEntryForm)
        {
            this.browser = browserWindow;
            this.calendarPage = calendarPage;
            this.calendarEntryForm = calendarEntryForm;
        }

        [When(@"entering christmas vacation")]
        public void EnterChristmasVacation() 
        {
            calendarPage.CreateNewEvent();
            calendarEntryForm.CreateAndStore(title: "Christmas Vacation");
        }
    }
}
