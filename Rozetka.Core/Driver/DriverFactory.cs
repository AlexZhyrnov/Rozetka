using OpenQA.Selenium;
using Rozetka.Core.Driver.DriverCreator;
using System;

namespace Rozetka.Core.Driver
{
    public static class DriverFactory
    {
        public static IWebDriver Create(string browser)
        {
            IDriverCreator driverCreator = browser switch
            {
                "Chrome" => new ChromeCreator(),
                "Firefox" => new FirefoxCreator(),
                "Edge" => new EdgeCreator(),
                "IE" => new InternetExplorerCreator(),
                _ => throw new ArgumentException($"'{browser}' is not a valid browser!")
            };
            return driverCreator.CreateDriver();
        }
    }
}
