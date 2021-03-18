using Rozetka.Core.Driver;
using TechTalk.SpecFlow;

namespace Rozetka.UI.Tests.Steps
{
    [Binding]
    public sealed class NavigationSteps
    {
        [Given(@"I am on page Rozetka")]
        public void GivenIAmOnPageRozetka()
        {
            WebDriver.Driver.Navigate().GoToUrl("https://rozetka.com.ua");
        }
    }
}
