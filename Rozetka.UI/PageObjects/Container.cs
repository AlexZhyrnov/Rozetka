using Rozetka.Core.Driver;
using SeleniumExtras.PageObjects;

namespace Rozetka.UI.PageObjects
{
    public abstract class Container
    {
        protected Container()
        {
            PageFactory.InitElements(WebDriver.Driver, this);
        }
    }
}
