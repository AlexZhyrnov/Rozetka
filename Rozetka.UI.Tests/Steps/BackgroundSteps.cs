using OpenQA.Selenium;
using Rozetka.Core.Extensions;
using Rozetka.Core.Helpers;
using Rozetka.Core.WebDriver;
using TechTalk.SpecFlow;

namespace Rozetka.UI.Tests.Steps
{
    [Binding]
    public sealed class BackgroundSteps
    {
        private readonly IWebDriver _driver;

        public BackgroundSteps()
        {
            _driver = SeleniumDriver.Driver;
        }

        [Given(@"I am on page '(.*)'")]
        public void GivenIAmOnPage(string pageName)
        {
            string pageUrl = ConfigExtensions.GetAppSettings(pageName.Replace(" ", string.Empty).Trim());
            _driver.Navigate().GoToUrl(pageUrl);
            Wait.Until(d => _driver.Url.Contains(pageUrl));
        }
    }
}
