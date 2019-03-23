using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Rozetka.UI.PageObjects
{
    public class SearchBar : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "input.search-form__input")]
        public IWebElement SearchInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button.search-form__submit")]
        public IWebElement SearchButton { get; set; }
    }
}
