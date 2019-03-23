using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Rozetka.UI.PageObjects
{
    public class SearchBar : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "input.search__input, input.rz-header-search-input-text")]
        public IWebElement SearchInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button.search__button, button.js-rz-search-button")]
        public IWebElement SearchButton { get; set; }


        public void SetText(string searchText)
        {
            SearchInput.Clear();
            SearchInput.SendKeys(searchText);
        }

        public void ClickFind()
        {
            SearchButton.Click();
        }
    }
}
