using OpenQA.Selenium;
using Rozetka.Core.Extensions;

namespace Rozetka.Core.WebDriver
{
    public static class SeleniumDriver
    {
        private static IWebDriver _driver;

        public static IWebDriver Driver =>
            _driver ??= DriverFactory.Create(ConfigExtensions.GetAppSettings("Browser"));

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
