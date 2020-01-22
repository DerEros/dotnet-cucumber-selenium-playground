using TechTalk.SpecFlow;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Wikipedia.Steps
{
    [Binding]
    public class WikipediaSteps {
        IWebDriver driver;

        [Given(@"an open browsers window")]
        public void OpenBrowser() 
        {
            driver = new ChromeDriver();
        }

        [When(@"navigating to '(.*)'")]
        public void OpenUrl(string url) 
        {
            driver.Url = "https://wikipedia.org";
        }

        [Then(@"the title is '(.*)'")]
        public void ValidatePageTitle(string expectedTitle) 
        {
            Assert.True(expectedTitle == driver.Title);
        }
    }
}
