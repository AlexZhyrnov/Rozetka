using System.Configuration;
using OpenQA.Selenium;

namespace Rozetka.Core.WebDriver
{
    public static class SeleniumDriver
    {
        private static IWebDriver _driver;

        public static IWebDriver Driver =>
            _driver ?? (_driver = DriverFactory.Create(ConfigurationManager.AppSettings["Browser"]));

        public static IWebDriver Start()
        {
            return Driver;
        }

        public static void Quit()
        {
            _driver.Quit();
            _driver = null;
        }
    }
}
