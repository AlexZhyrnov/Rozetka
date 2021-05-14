using NUnit.Framework;
using Rozetka.Core.Extensions;
using Rozetka.UI.Contexts;
using System.Linq;
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
            _scenarioContext = scenarioContext;
            _searchContext = new SearchContext();
        }

        [When(@"I search '(.*)' in search bar")]
        public void WhenISearchProductsInSearchBar(string searchText)
        {
            _searchContext.Search(searchText);
        }

        [Then(@"Results show only products with '(.*)' name")]
        public void ThenResultsShowOnlyProductsWithName(string searchText)
        {
            var productItemsText = _searchContext.GetProductItems().Select(i => i.Text.ToLowerInvariant()).ToList();
            Assert.Multiple(() =>
                productItemsText.ForEach(text =>
                    Assert.That(text, Contains.Substring(searchText.ToLowerInvariant()), $"Product with name '{searchText}' not found!")));
        }

        [Then(@"Button with text '(.*)' is displayed")]
        public void ThenButtonWithTextIsDisplayed(string buttonText)
        {
            Assert.That(_searchContext.GetLoadMoreButton().IsDisplayed(), "Load More button is not displayed!");
            Assert.That(_searchContext.GetLoadMoreButton().Text, Is.EqualTo(buttonText), $"Button text '{buttonText}' does not match!");
        }
    }
}
