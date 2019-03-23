using System.Collections.Generic;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Rozetka.UI.PageObjects
{
    public class ResultsContainer : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = ".goods-tile")]
        public IList<IWebElement> ProductItems { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".catalog-more__link")]
        public IWebElement LoadMoreBtn { get; set; }
    }
}
