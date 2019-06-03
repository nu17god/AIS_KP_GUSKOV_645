using OpenQA.Selenium;
using TestKP.InitElements;

namespace TestKP
{
    abstract class Page
    {
        protected IWebDriver Driver;
        public IWebElement News;
        public IWebElement About;
        public IWebElement SubMenu;

        protected Page(IWebDriver driver)
        {
            this.Driver = driver;
            NavigationElements.InitNavigationElements(driver, this);
        }

        public NewsPage OpenNewsPage()
        {
            News.Click();
            return new NewsPage(Driver);
        }

        public AboutPage OpenAboutPage()
        {
            About.Click();
            return new AboutPage(Driver);
        }
    }
}   
