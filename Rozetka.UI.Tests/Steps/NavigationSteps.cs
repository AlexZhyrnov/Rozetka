using Rozetka.WebDriver;
using TechTalk.SpecFlow;

namespace Rozetka.UI.Tests.Steps
{
    [Binding]
    public sealed class NavigationSteps
    {
        [Given(@"I am on page Rozetka")]
        public static void GivenIAmOnPageRozetka()
        {
            DriverService.Driver.Navigate().GoToUrl("https://rozetka.com.ua");
        }
    }
}
