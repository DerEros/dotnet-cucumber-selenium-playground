using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Utils 
{
    public class BrowserWindow 
    {
        public static IWebDriver Driver { get; set; }

        public BrowserWindow() 
        {
            if (Driver == null) {
                Driver = new ChromeDriver();
            }
        }
    }
}
