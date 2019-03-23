using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Rozetka.Core.WebDriver.DriverCreator
{
    public class FirefoxCreator : IDriverCreator
    {
        public IWebDriver CreateDriver()
        {
            FirefoxDriver driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}
