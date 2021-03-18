using OpenQA.Selenium;
using Rozetka.Core.Helpers;
using System;

namespace Rozetka.Core.Extensions
{
    public static class ElementExtensions
    {
        public static bool IsDisplayed(this IWebElement element)
        {
            return Wait.With
                .Timeout(TimeSpan.FromMilliseconds(200))
                .PollingInterval(TimeSpan.FromMilliseconds(100))
                .IgnoreTimeoutException()
                .Until(() => element.Displayed);
        }
    }
}
