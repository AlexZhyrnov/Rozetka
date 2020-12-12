using OpenQA.Selenium;
using Rozetka.Core.Helpers;
using Rozetka.UI.PageObjects;
using System.Collections.Generic;
using System.Linq;

namespace Rozetka.UI.Contexts
{
    public class SearchContext
    {
        private readonly SearchBar _searchBar;
        private readonly ResultsContainer _results;

        public SearchContext()
        {
            _searchBar = new SearchBar();
            _results = new ResultsContainer();
        }

        public void Search(string text)
        {
            Wait.Until(d => _searchBar.SearchInput.Displayed);
            _searchBar.SearchInput.Clear();
            _searchBar.SearchInput.SendKeys(text);
            Wait.Until(d => _searchBar.SearchButton.Displayed);
            _searchBar.SearchButton.Click();
            WaitResultsAreLoaded();
        }

        public void WaitResultsAreLoaded()
        {
            Wait.Until(d => _results.ProductItems.Any(i => i.Displayed));
        }

        public IList<IWebElement> GetProductItems()
        {
            return _results.ProductItems;
        }

        public IWebElement GetLoadMoreButton()
        {
            return _results.LoadMoreButton;
        }
    }
}
