using Rozetka.WebDriver;
using SeleniumExtras.PageObjects;

namespace Rozetka.UI.PageObjects
{
    public abstract class Container
    {
        protected Container()
        {
            PageFactory.InitElements(DriverService.Driver, this);
        }
    }
}
