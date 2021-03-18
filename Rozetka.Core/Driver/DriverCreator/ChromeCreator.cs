using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Rozetka.Core.Driver.DriverCreator
{
    public class ChromeCreator : IDriverCreator
    {
        public IWebDriver CreateDriver()
        {
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(AppDomain.CurrentDomain.BaseDirectory);
            service.LogPath = $"{AppDomain.CurrentDomain.BaseDirectory}ChromeDriver.log";

            ChromeOptions options = new ChromeOptions();
            options.AddExcludedArgument("enable-automation");
            options.AddAdditionalCapability("useAutomationExtension", false);
            options.AddUserProfilePreference("download.default_directory", AppDomain.CurrentDomain.BaseDirectory);
            options.AddUserProfilePreference("download.prompt_for_download", true);
            options.AddUserProfilePreference("disable-popup-blocking", true);
            options.AddUserProfilePreference("credentials_enable_service", false);
            options.AddUserProfilePreference("profile.password_manager_enabled", false);
            options.AddArguments(
                "--disable-extensions",
                "--disable-web-security",
                "--disable-popup-blocking",
                "--disable-notifications",
                "--start-maximized");
            return new ChromeDriver(service, options);
        }
    }
}
