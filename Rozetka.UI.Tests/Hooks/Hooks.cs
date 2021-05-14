using Rozetka.Core.Driver;
using TechTalk.SpecFlow;

namespace Rozetka.UI.Tests.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        [BeforeFeature]
        public static void BeforeFeature()
        {
            WebDriver.Start();
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            WebDriver.Quit();
        }
    }
}
