using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace TestKP
{
    [SetUpFixture]
    [TestFixture(typeof(FirefoxDriver))]
    [TestFixture(typeof(ChromeDriver))]
    public class TestNavigation<TWebDriver> where TWebDriver : IWebDriver, new()
    {
        private NewsPage newsPage;
        private AboutPage aboutPage;
        private IWebDriver driver;

        [OneTimeSetUp]
        public void TestSetUp()
        {
            this.driver = new TWebDriver();
            driver.Url = "http://127.0.0.1:8080/";
            newsPage = new NewsPage(driver);
        }

        [Test, Order(1)]
        public void TestOpenNewsPageFromNewsPage()
        {
            newsPage = newsPage.OpenNewsPage();
            bool condition = newsPage.MainBlock.Displayed;

            Assert.True(condition);
        }

        [Test, Order(2)]
        public void TestOpenAboutPageFromNewsPage()
        {
            aboutPage = newsPage.OpenAboutPage();
            bool condition = aboutPage.MainBlock.Displayed;

            Assert.True(condition);
        }

        [Test, Order(3)]
        public void TestOpenAboutPageFromAboutPage()
        {
            aboutPage = aboutPage.OpenAboutPage();
            bool condition = aboutPage.MainBlock.Displayed;

            Assert.True(condition);
        }

        [Test, Order(4)]
        public void TestOpenNewsPageFromAboutPage()
        {
            newsPage = aboutPage.OpenNewsPage();
            bool condition = newsPage.MainBlock.Displayed;

            Assert.True(condition);
        }

        [OneTimeTearDown]
        public void TestsTearDown()
        {
            driver.Quit();
        }
    }
}

