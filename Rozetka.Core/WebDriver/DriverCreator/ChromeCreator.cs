using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Rozetka.Core.WebDriver.DriverCreator
{
    public class ChromeCreator : IDriverCreator
    {
        public IWebDriver CreateDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("download.default_directory", AppDomain.CurrentDomain.BaseDirectory);
            options.AddUserProfilePreference("download.prompt_for_download", false);
            options.AddUserProfilePreference("disable-popup-blocking", true);
            options.AddArguments(
                //"--incognito",
                "--disable-web-security",
                "--disable-extensions",
                "disable-infobars",
                "start-maximized");
            return new ChromeDriver(options);
        }
    }
}
