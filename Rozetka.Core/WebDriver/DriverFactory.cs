using System;
using OpenQA.Selenium;
using Rozetka.Core.WebDriver.DriverCreator;

namespace Rozetka.Core.WebDriver
{
    public static class DriverFactory
    {
        public static IWebDriver Create(string browser)
        {
            IDriverCreator driverCreator;
            switch (browser)
            {
                case "Chrome":  driverCreator = new ChromeCreator();       break;
                case "Firefox": driverCreator = new FirefoxCreator();      break;
                case "IE":      driverCreator = new IECreator();           break;
                case "Edge":    driverCreator = new EdgeCreator();         break;
                case "EdgeDev": driverCreator = new EdgeChromiumCreator(); break;
                default:
                    throw new ArgumentException($"'{browser}' is not a valid browser!");
            }
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            return driverCreator.CreateDriver();
        }
    }
}
