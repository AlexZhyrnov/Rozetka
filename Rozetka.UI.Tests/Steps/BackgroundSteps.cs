using OpenQA.Selenium;
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

        [Given(@"I am on page Rozetka")]
        public void GivenIAmOnPageRozetka()
        {
            _driver.Navigate().GoToUrl("https://rozetka.com.ua");
        }
    }
}
