using System.Configuration;
using OpenQA.Selenium;

namespace Rozetka.Core.WebDriver
{
    public class SeleniumDriver
    {
        private static IWebDriver _driver;

        private SeleniumDriver() {}

        public static IWebDriver Driver =>
            _driver ?? (_driver = DriverFactory.Create(ConfigurationManager.AppSettings["Browser"]));

        public static IWebDriver Start() => Driver;

        public static void Quit()
        {
            _driver.Quit();
            _driver = null;
        }
    }
}
