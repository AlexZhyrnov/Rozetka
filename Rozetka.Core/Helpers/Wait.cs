using OpenQA.Selenium.Support.UI;
using Rozetka.Core.WebDriver;
using System;

namespace Rozetka.Core.Helpers
{
    public static class Wait
    {
        public static WebDriverWait Timeout(int seconds)
        {
            return new WebDriverWait(SeleniumDriver.Driver, TimeSpan.FromSeconds(seconds));
        }
    }
}
