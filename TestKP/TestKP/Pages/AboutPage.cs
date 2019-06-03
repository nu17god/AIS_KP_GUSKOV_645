using OpenQA.Selenium;
using TestKP.InitElements;

namespace TestKP
{
    class AboutPage : Page
    {
        public IWebElement MainBlock;
        public AboutPage(IWebDriver driver) : base(driver)
        {
            AboutPageElements.InitNewsPageElements(driver, this);
        }
    }
}
