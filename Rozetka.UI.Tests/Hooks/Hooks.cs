using Rozetka.Core.WebDriver;
using TechTalk.SpecFlow;

namespace Rozetka.UI.Tests.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            SeleniumDriver.Start();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            SeleniumDriver.Quit();
        }
    }
}
