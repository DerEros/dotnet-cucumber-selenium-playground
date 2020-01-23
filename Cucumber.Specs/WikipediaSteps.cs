using TechTalk.SpecFlow;
using Xunit;
using Utils;

namespace Wikipedia.Steps
{
    [Binding]
    public class WikipediaSteps 
    {
        BrowserWindow browser;

        public WikipediaSteps(BrowserWindow browserWindow) 
        {
            this.browser = browserWindow;
        }

        [Given(@"an open browsers window")]
        public void OpenBrowser() 
        {
            Assert.NotNull(BrowserWindow.Driver);
        }

        [When(@"navigating to '(.*)'")]
        public void OpenUrl(string url) 
        {
            BrowserWindow.Driver.Url = "https://wikipedia.org";
        }

        [Then(@"the title is '(.*)'")]
        public void ValidatePageTitle(string expectedTitle) 
        {
            Assert.True(expectedTitle == BrowserWindow.Driver.Title);
        }
    }
}
