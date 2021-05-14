using Rozetka.WebDriver;
using TechTalk.SpecFlow;

namespace Rozetka.UI.Tests.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        [BeforeFeature]
        public static void BeforeFeature()
        {
            DriverService.Start();
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            DriverService.Quit();
        }
    }
}
