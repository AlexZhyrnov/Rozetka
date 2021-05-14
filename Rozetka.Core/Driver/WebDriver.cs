using OpenQA.Selenium;

namespace Rozetka.Core.Driver
{
    public class WebDriver
    {
        private static IWebDriver _driver;

        private WebDriver() { }

        public static IWebDriver Driver => _driver ??= DriverFactory.Create(Settings.Browser);

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
