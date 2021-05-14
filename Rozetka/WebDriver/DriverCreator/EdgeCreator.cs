using Microsoft.Edge.SeleniumTools;
using OpenQA.Selenium;
using System;

namespace Rozetka.WebDriver.DriverCreator
{
    public class EdgeCreator : IDriverCreator
    {
        public IWebDriver CreateDriver()
        {
            EdgeDriverService service = EdgeDriverService.CreateChromiumService(AppDomain.CurrentDomain.BaseDirectory);
            service.LogPath = $"{AppDomain.CurrentDomain.BaseDirectory}MsEdgeDriver.log";

            EdgeOptions options = new() { UseChromium = true };
            //options.AddExcludedArgument("enable-automation");
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
            return new EdgeDriver(service, options);
        }
    }
}
