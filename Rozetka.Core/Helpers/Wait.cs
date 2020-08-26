using OpenQA.Selenium.Support.UI;
using Rozetka.Core.WebDriver;
using System;
using OpenQA.Selenium;

namespace Rozetka.Core.Helpers
{
    public static class Wait
    {
        public static WebDriverWait Timeout(TimeSpan timeSpan)
        {
            return new WebDriverWait(SeleniumDriver.Driver, timeSpan);
        }

        public static bool Until(Func<IWebDriver, bool> condition)
        {
            return Timeout(TimeSpan.FromSeconds(10)).Until(condition);
        }
    }
}
