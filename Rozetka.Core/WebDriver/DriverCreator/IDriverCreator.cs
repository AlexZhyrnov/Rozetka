using OpenQA.Selenium;

namespace Rozetka.Core.WebDriver.DriverCreator
{
    public interface IDriverCreator
    {
        IWebDriver CreateDriver();
    }
}
