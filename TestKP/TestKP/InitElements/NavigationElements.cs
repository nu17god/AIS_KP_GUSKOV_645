using OpenQA.Selenium;

namespace TestKP.InitElements
{
    static class NavigationElements
    {
        public static void InitNavigationElements(IWebDriver driver, Page page)
        {
            page.News = driver.FindElement(By.XPath("/html/body/div[1]/ul/li[1]/a"));
            page.About = driver.FindElement(By.XPath("/html/body/div[1]/ul/li[2]/a"));
            page.SubMenu = driver.FindElement(By.XPath("/html/body/div[1]/ul/li[2]/ul/li[1]/a"));
        }
    }

}
