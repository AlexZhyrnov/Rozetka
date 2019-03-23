using System;
using NUnit.Framework;
using Rozetka.Core.Helpers;
using Rozetka.UI.PageObjects;
using TechTalk.SpecFlow;

namespace Rozetka.UI.Tests.Steps
{
    [Binding]
    public sealed class SearchSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly SearchBar _searchBar;
        private readonly ResultsContainer _resultsContainer;
        private const string SearchQueryKey = "searchQuery";

        public SearchSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext ?? throw new ArgumentNullException(nameof(scenarioContext));
            _searchBar = new SearchBar();
            _resultsContainer = new ResultsContainer();
        }


        [When(@"I search for '(.*)' in search bar")]
        public void WhenISearchForProductsInSearchBar(string searchText)
        {
            _searchBar.SetText(searchText);
            _searchBar.ClickFind();
            Wait.Timeout(10).Until(d => _resultsContainer.IsLoaded());
            _scenarioContext.Add(SearchQueryKey, searchText);
        }

        [Then(@"I see only products that I searched for")]
        public void ThenISeeOnlyProductsThatISearchedFor()
        {
            string searchText = _scenarioContext.Get<string>(SearchQueryKey);
            Assert.IsTrue(_resultsContainer.AllProductsContain(searchText), $"Not all of the products are '{searchText}'!");
        }

        [Then(@"Button '(.*)' is displayed")]
        public void ThenButtonIsDisplayed(string buttonText)
        {
            Assert.IsTrue(_resultsContainer.Load32MoreIsDisplayed(), "Button is not displayed!");
            Assert.AreEqual(buttonText, _resultsContainer.Load32MoreGetText(), $"Text '{buttonText}' is not displayed!");
        }
    }
}
