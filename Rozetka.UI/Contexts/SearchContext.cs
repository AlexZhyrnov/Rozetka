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
        private readonly SearchResults _searchResults;

        public SearchContext()
        {
            _searchBar = new SearchBar();
            _searchResults = new SearchResults();
        }

        public void Search(string text)
        {
            Wait.Until(() => _searchBar.SearchInput.Displayed);
            Wait.Until(() => _searchBar.SearchButton.Displayed);
            _searchBar.SearchInput.Clear();
            _searchBar.SearchInput.SendKeys(text);
            _searchBar.SearchButton.Click();
            WaitResultsLoaded();
        }

        public void WaitResultsLoaded()
        {
            Wait.Until(() => _searchResults.ProductItems.Any());
            Wait.Until(() => _searchResults.ProductItems.All(i => i.Displayed));
        }

        public IList<IWebElement> GetProductItems()
        {
            return _searchResults.ProductItems;
        }

        public IWebElement GetLoadMoreButton()
        {
            return _searchResults.LoadMoreButton;
        }
    }
}
