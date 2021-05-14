using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Rozetka.Core.Driver.DriverCreator
{
    public class FirefoxCreator : IDriverCreator
    {
        public IWebDriver CreateDriver()
        {
            FirefoxDriver driver = new();
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}
