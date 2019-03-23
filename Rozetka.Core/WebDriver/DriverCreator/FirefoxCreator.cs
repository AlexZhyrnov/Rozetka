using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Rozetka.Core.WebDriver.DriverCreator
{
    public class FirefoxCreator : IDriverCreator
    {
        public IWebDriver CreateDriver()
        {
            FirefoxOptions options = new FirefoxOptions
            {

            };
            FirefoxDriver driver = new FirefoxDriver(options);
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}
