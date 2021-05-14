using OpenQA.Selenium;

namespace Rozetka.WebDriver.DriverCreator
{
    public interface IDriverCreator
    {
        IWebDriver CreateDriver();
    }
}
