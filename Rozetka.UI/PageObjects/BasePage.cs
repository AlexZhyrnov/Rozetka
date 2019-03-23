using Rozetka.Core.WebDriver;
using SeleniumExtras.PageObjects;

namespace Rozetka.UI.PageObjects
{
    public abstract class BasePage
    {
        protected BasePage()
        {
            PageFactory.InitElements(SeleniumDriver.Driver, this);
        }
    }
}
