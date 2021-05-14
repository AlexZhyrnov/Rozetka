using OpenQA.Selenium;
using OpenQA.Selenium.IE;

namespace Rozetka.WebDriver.DriverCreator
{
    public class InternetExplorerCreator : IDriverCreator
    {
        public IWebDriver CreateDriver()
        {
            InternetExplorerOptions options = new()
            {
                UnhandledPromptBehavior = UnhandledPromptBehavior.Ignore,
                EnablePersistentHover = true,
                EnableNativeEvents = true,
                IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                EnsureCleanSession = true,
                RequireWindowFocus = true,
                IgnoreZoomLevel = true
            };
            InternetExplorerDriver driver = new(options);
            //driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}
