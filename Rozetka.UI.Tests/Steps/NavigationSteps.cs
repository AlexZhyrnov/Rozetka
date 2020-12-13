﻿using Rozetka.Core.WebDriver;
using TechTalk.SpecFlow;

namespace Rozetka.UI.Tests.Steps
{
    [Binding]
    public sealed class NavigationSteps
    {
        [Given(@"I am on page Rozetka")]
        public void GivenIAmOnPageRozetka()
        {
            SeleniumDriver.Driver.Navigate().GoToUrl("https://rozetka.com.ua");
        }
    }
}
