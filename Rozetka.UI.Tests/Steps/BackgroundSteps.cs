using System;
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

        [Given(@"I am on page '(.*)'")]
        public void GivenIAmOnPage(string pageName)
        {
            string pageUrl = ConfigurationManager.AppSettings[pageName.Trim().Replace(" ", string.Empty)];
            _driver.Navigate().GoToUrl(pageUrl);
            Wait.Timeout(TimeSpan.FromSeconds(10)).Until(d => _driver.Url.Contains(pageUrl));
        }
    }
}
