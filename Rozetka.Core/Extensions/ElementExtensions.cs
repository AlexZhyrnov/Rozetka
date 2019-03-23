﻿using System;
using OpenQA.Selenium;
using Rozetka.Core.Helpers;

namespace Rozetka.Core.Extensions
{
    public static class ElementExtensions
    {
        public static bool IsDisplayed(this IWebElement element)
        {
            try
            {
                return Wait.Timeout(TimeSpan.FromSeconds(5)).Until(d => element.Displayed);
            }
            catch
            {
                return false;
            }
        }
    }
}
