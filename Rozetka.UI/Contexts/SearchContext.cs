using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Rozetka.Core.Helpers;
using Rozetka.UI.PageObjects;

namespace Rozetka.UI.Contexts
{
    public class SearchContext
    {
        public readonly SearchBar SearchBar;
        public readonly ResultsContainer Results;

        public SearchContext()
        {
            SearchBar = new SearchBar();
            Results = new ResultsContainer();
        }

        public void Search(string text)
        {
            Wait.Timeout(TimeSpan.FromSeconds(10)).Until(d => SearchBar.SearchInput.Displayed);
            SearchBar.SearchInput.Clear();
            SearchBar.SearchInput.SendKeys(text);
            Wait.Timeout(TimeSpan.FromSeconds(10)).Until(d => SearchBar.SearchButton.Displayed);
            SearchBar.SearchButton.Click();
        }

        public void WaitResultsAreLoaded()
        {
            Wait.Timeout(TimeSpan.FromSeconds(10)).Until(d => Results.ProductItems.Any(i => i.Displayed));
        }

        public List<IWebElement> GetProductItems()
        {
            return Results.ProductItems.ToList();
        }
    }
}
