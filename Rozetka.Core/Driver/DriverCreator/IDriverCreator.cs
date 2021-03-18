using OpenQA.Selenium;

namespace Rozetka.Core.Driver.DriverCreator
{
    public interface IDriverCreator
    {
        IWebDriver CreateDriver();
    }
}
