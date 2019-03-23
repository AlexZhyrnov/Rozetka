using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace Rozetka.Core.WebDriver.DriverCreator
{
    public class EdgeCreator : IDriverCreator
    {
        public IWebDriver CreateDriver()
        {
            EdgeOptions options = new EdgeOptions
            {
                PageLoadStrategy = PageLoadStrategy.Eager
            };
            EdgeDriver driver = new EdgeDriver(options);
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}
