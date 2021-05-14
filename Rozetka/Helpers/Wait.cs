using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using DriverService = Rozetka.WebDriver.DriverService;

namespace Rozetka.Helpers
{
    public static class Wait
    {
        public static WaitOptions With => new();

        public static bool Until(Func<bool> condition) => With.Until(condition);
    }

    public class WaitOptions
    {
        private static readonly TimeSpan DefaultTimeout = TimeSpan.FromMinutes(1);
        private static readonly TimeSpan DefaultPollingInterval = TimeSpan.FromMilliseconds(200);
        private readonly WebDriverWait _webDriverWait;
        private readonly List<Type> _exceptionTypes;

        public WaitOptions()
        {
            _webDriverWait = new WebDriverWait(DriverService.Driver, DefaultTimeout) { PollingInterval = DefaultPollingInterval };
            _exceptionTypes = new List<Type>();
        }

        public WaitOptions Timeout(TimeSpan timeSpan)
        {
            _webDriverWait.Timeout = timeSpan;
            return this;
        }

        public WaitOptions PollingInterval(TimeSpan timeSpan)
        {
            _webDriverWait.PollingInterval = timeSpan;
            return this;
        }

        public WaitOptions Message(string messageText)
        {
            _webDriverWait.Message = messageText;
            return this;
        }

        public WaitOptions IgnoreExceptions(params Type[] exceptionTypes)
        {
            _exceptionTypes.AddRange(exceptionTypes);
            return this;
        }

        public WaitOptions IgnoreTimeoutException()
        {
            IgnoreExceptions(typeof(WebDriverTimeoutException));
            return this;
        }

        public bool Until(Func<bool> condition)
        {
            try
            {
                _webDriverWait.IgnoreExceptionTypes(_exceptionTypes.Distinct().ToArray());
                return _webDriverWait.Until(_ => condition());
            }
            catch (Exception e)
            {
                if (_exceptionTypes.Contains(e.GetType())) return false;
                throw;
            }
        }
    }
}
