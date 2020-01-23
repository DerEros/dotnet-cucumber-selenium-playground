using TechTalk.SpecFlow;
using Utils;
using Xunit;

namespace Browser.Steps 
{
    [Binding]
    public class BrowserSteps
    {
        BrowserWindow browser;

        public BrowserSteps(BrowserWindow browserWindow)
        {
            this.browser = browserWindow;
        }

        [Given(@"a browser window")]
        public void GivenABrowserWindow() 
        {
            Assert.NotNull(BrowserWindow.Driver);
        }
    }
}
