using OpenQA.Selenium;

namespace TestKP.InitElements
{
    class AboutPageElements
    {
        public static void InitNewsPageElements(IWebDriver driver, AboutPage newsPage)
        {
            newsPage.MainBlock = driver.FindElement(By.Id("AboutPage"));
        }
    }
}
