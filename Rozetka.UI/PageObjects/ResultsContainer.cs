using System.Linq;
using System.Collections.Generic;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Rozetka.Core.Extensions;

namespace Rozetka.UI.PageObjects
{
    public class ResultsContainer : BasePage
    {
        [FindsBy(How = How.ClassName, Using = "g-i-tile-i")]
        public IList<IWebElement> ProductItems { get; set; }

        [FindsBy(How = How.ClassName, Using = "g-i-more-link-text")]
        public IWebElement Load32MoreBtn { get; set; }


        public bool IsLoaded()
        {
            return ProductItems.Any(i => i.Displayed);
        }

        public bool AllProductsContain(string searchText)
        {
            searchText = searchText.ToLowerInvariant();
            try
            {
                return ProductItems.All(i => i.Text.ToLowerInvariant().Contains(searchText));
            }
            catch
            {
                return false;
            }
        }

        public bool Load32MoreIsDisplayed()
        {
            return Load32MoreBtn.IsDisplayed();
        }

        public string Load32MoreGetText()
        {
            return Load32MoreBtn.Text.Trim().Replace("\r\n", " ");
        }
    }
}
