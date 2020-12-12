using OpenQA.Selenium;
using Rozetka.Core.WebDriver.DriverCreator;
using System;

namespace Rozetka.Core.WebDriver
{
    public static class DriverFactory
    {
        public static IWebDriver Create(string browser)
        {
            IDriverCreator driverCreator;
            switch (browser)
            {
                case "Chrome":
                    driverCreator = new ChromeCreator();
                    break;
                case "Firefox":
                    driverCreator = new FirefoxCreator();
                    break;
                case "IE":
                    driverCreator = new InternetExplorerCreator();
                    break;
                case "Edge":
                    driverCreator = new EdgeCreator();
                    break;
                default:
                    throw new ArgumentException($"'{browser}' is not a valid browser!");
            }
            return driverCreator.CreateDriver();
        }
    }
}
