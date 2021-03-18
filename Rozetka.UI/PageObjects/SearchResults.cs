using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace Rozetka.UI.PageObjects
{
    public class SearchResults : Container
    {
        [FindsBy(How = How.CssSelector, Using = ".goods-tile")]
        public IList<IWebElement> ProductItems { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a.show-more")]
        public IWebElement LoadMoreButton { get; set; }
    }
}
