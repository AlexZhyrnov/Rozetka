using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace Rozetka.UI.PageObjects
{
    public class ResultsContainer : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = ".goods-tile")]
        public IList<IWebElement> ProductItems { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".catalog-more__link")]
        public IWebElement LoadMoreButton { get; set; }
    }
}
