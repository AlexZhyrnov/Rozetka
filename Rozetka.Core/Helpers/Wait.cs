using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Rozetka.Core.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rozetka.Core.Helpers
{
    public class Wait
    {
        private static readonly TimeSpan DefaultTimeout = TimeSpan.FromMinutes(1);
        private static readonly TimeSpan DefaultPollingInterval = TimeSpan.FromMilliseconds(200);
        private readonly WebDriverWait _webDriverWait;
        private readonly List<Type> _exceptionTypes;

        public Wait()
        {
            _webDriverWait = new WebDriverWait(WebDriver.Driver, DefaultTimeout) { PollingInterval = DefaultPollingInterval };
            _exceptionTypes = new List<Type>();
        }

        public Wait TimeoutSeconds(int seconds)
        {
            _webDriverWait.Timeout = TimeSpan.FromSeconds(seconds);
            return this;
        }

        public Wait TimeoutMilliseconds(int milliseconds)
        {
            _webDriverWait.Timeout = TimeSpan.FromMilliseconds(milliseconds);
            return this;
        }

        public Wait PollingIntervalMilliseconds(int milliseconds)
        {
            _webDriverWait.PollingInterval = TimeSpan.FromMilliseconds(milliseconds);
            return this;
        }

        public Wait Message(string messageText)
        {
            _webDriverWait.Message = messageText;
            return this;
        }

        public Wait IgnoreExceptions(params Type[] exceptionTypes)
        {
            _exceptionTypes.AddRange(exceptionTypes);
            return this;
        }

        public Wait IgnoreWebDriverTimeoutException()
        {
            _exceptionTypes.Add(typeof(WebDriverTimeoutException));
            return this;
        }

        public bool Until(Func<bool> condition)
        {
            try
            {
                _webDriverWait.IgnoreExceptionTypes(_exceptionTypes.Distinct().ToArray());
                return _webDriverWait.Until(d => condition.Invoke());
            }
            catch (Exception e)
            {
                if (_exceptionTypes.Contains(e.GetType())) return false;
                throw;
            }
        }
    }
}
