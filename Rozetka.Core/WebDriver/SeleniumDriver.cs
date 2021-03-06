﻿using OpenQA.Selenium;

namespace Rozetka.Core.WebDriver
{
    public class SeleniumDriver
    {
        private static IWebDriver _driver;

        private SeleniumDriver() { }

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
