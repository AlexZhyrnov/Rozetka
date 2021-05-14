using OpenQA.Selenium;

namespace Rozetka.WebDriver
{
    public class DriverService
    {
        private static IWebDriver _driver;

        private DriverService() { }

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
