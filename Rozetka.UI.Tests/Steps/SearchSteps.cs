using System;
using System.Linq;
using NUnit.Framework;
using Rozetka.Core.Extensions;
using Rozetka.UI.Contexts;
using TechTalk.SpecFlow;

namespace Rozetka.UI.Tests.Steps
{
    [Binding]
    public sealed class SearchSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly SearchContext _searchContext;

        public SearchSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext ?? throw new ArgumentNullException(nameof(scenarioContext));
            _searchContext = new SearchContext();
        }

        [When(@"I search '(.*)' in search bar")]
        public void WhenISearchProductsInSearchBar(string searchText)
        {
            _searchContext.Search(searchText);
            _searchContext.WaitResultsAreLoaded();
        }

        [Then(@"Results show only products with '(.*)' name")]
        public void ThenResultsShowOnlyProductsWithName(string searchText)
        {
            var productItems = _searchContext.GetProductItems();
            Assert.IsTrue(productItems.All(i => i.Text.ToLowerInvariant().Contains(searchText.ToLowerInvariant())), 
                $"Not all products are '{searchText}'!");
        }

        [Then(@"Button with text '(.*)' is displayed")]
        public void ThenButtonWithTextIsDisplayed(string buttonText)
        {
            Assert.IsTrue(_searchContext.Results.LoadMoreBtn.IsDisplayed(), "Button is not displayed!");
            Assert.AreEqual(buttonText, _searchContext.Results.LoadMoreBtn.Text, $"Text '{buttonText}' is not displayed!");
        }
    }
}
