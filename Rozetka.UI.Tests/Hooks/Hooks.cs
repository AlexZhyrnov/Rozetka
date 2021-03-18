using Rozetka.Core.Driver;
using TechTalk.SpecFlow;

namespace Rozetka.UI.Tests.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            WebDriver.Start();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            WebDriver.Quit();
        }
    }
}
