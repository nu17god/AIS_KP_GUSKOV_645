using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace TestKP
{
    [SetUpFixture]
    [TestFixture(typeof(FirefoxDriver))]
    [TestFixture(typeof(ChromeDriver))]
    public class TestButtons<TWebDriver> where TWebDriver : IWebDriver, new()
    {
        private NewsPage newsPage;
        private IWebDriver driver;

        [OneTimeSetUp]
        public void TestSetUp()
        {
            this.driver = new TWebDriver();
            driver.Url = "http://127.0.0.1:8080/";
            newsPage = new NewsPage(driver);
        }

        [Test]
        public void TestSubmit()
        {
            newsPage.FillRequiredFields("Guskov", "Pavel", "pagusskov@gmail.com");
            newsPage.SubmitButton.Click();

            bool result = newsPage.IsAlertDisplayed();
            newsPage.ClearButton.Click();

            Assert.True(result);
        }

        [Test]
        public void TestClear()
        {
            newsPage.FillRequiredFields("Guskov", "Pavel", "pagusskov@gmail.com");
            newsPage.ClearButton.Click();

            bool result = newsPage.IsRequiredFieldsClear();

            Assert.True(result);
        }

        [OneTimeTearDown]
        public void TestsTearDown()
        {
            driver.Quit();
        }
    }
}
