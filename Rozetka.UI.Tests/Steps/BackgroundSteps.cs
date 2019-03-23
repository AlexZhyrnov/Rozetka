using OpenQA.Selenium;
using Rozetka.Core.WebDriver;
using TechTalk.SpecFlow;
using System.Configuration;
using Rozetka.Core.Helpers;

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

        [Given(@"I am on Rozetka '(.*)' page")]
        public void GivenIAmOnRozetkaPage(string pageName)
        {
            _driver.Navigate().GoToUrl(ConfigurationManager.AppSettings[pageName]);
            Wait.Timeout(10).Until(d => PageIsLoaded(pageName));
        }

        private bool PageIsLoaded(string pageName)
        {
            return 
                _driver.Url.Contains(ConfigurationManager.AppSettings[pageName]) && 
                _driver.Title.ToLowerInvariant().Contains("rozetka");
        }
    }
}
