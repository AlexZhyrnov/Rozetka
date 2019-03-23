using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Rozetka.Core.WebDriver.DriverCreator
{
    public class EdgeChromiumCreator : IDriverCreator
    {
        public IWebDriver CreateDriver()
        {
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(AppDomain.CurrentDomain.BaseDirectory, "msedgedriver.exe");
            service.LogPath = $"{AppDomain.CurrentDomain.BaseDirectory}EdgeChromiumDriver.log";
            
            ChromeOptions options = new ChromeOptions();
            //options.AddExcludedArgument("enable-automation");
            options.AddAdditionalCapability("useAutomationExtension", false);
            options.BinaryLocation = @"C:\Program Files (x86)\Microsoft\Edge Dev\Application\msedge.exe";
            options.AddUserProfilePreference("download.default_directory", AppDomain.CurrentDomain.BaseDirectory);
            options.AddUserProfilePreference("download.prompt_for_download", true);
            options.AddUserProfilePreference("disable-popup-blocking", true);
            options.AddUserProfilePreference("credentials_enable_service", false);
            options.AddUserProfilePreference("profile.password_manager_enabled", false);
            options.AddArguments(
                "--disable-extensions",
                "--disable-web-security",
                "--disable-popup-blocking",
                "--start-maximized");
            return new ChromeDriver(service, options);
        }
    }
}
