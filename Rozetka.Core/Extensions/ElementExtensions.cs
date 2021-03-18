using OpenQA.Selenium;
using Rozetka.Core.Helpers;

namespace Rozetka.Core.Extensions
{
    public static class ElementExtensions
    {
        public static bool IsDisplayed(this IWebElement element)
        {
            return new Wait()
                .TimeoutMilliseconds(200)
                .PollingIntervalMilliseconds(100)
                .IgnoreWebDriverTimeoutException()
                .Until(() => element.Displayed);
        }
    }
}
