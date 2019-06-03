using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace TestKP
{
    [SetUpFixture]
    [TestFixture(typeof(FirefoxDriver))]
    [TestFixture(typeof(ChromeDriver))]
    public class TestFields<TWebDriver> where TWebDriver : IWebDriver, new()
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
        public void TestLastNameFiled()
        {
            newsPage.LastNameField.SendKeys("Guskov");

            bool result = newsPage.LastNameField.GetAttribute("value").Equals("Guskov");

            Assert.True(result);
        }

        [Test]
        public void TestFirstNameFiled()
        {
            newsPage.FirstNameField.SendKeys("Pavel");
            bool result = newsPage.FirstNameField.GetAttribute("value").Equals("Pavel");

            Assert.True(result);
        }

        [Test]
        public void TestEmailFiled()
        {
            newsPage.EmailField.SendKeys("pagusskov62@gmail.com");
            bool result = newsPage.EmailField.GetAttribute("value").Equals("pagusskov62@gmail.com");

            newsPage.ClearButton.Click();

            Assert.True(result);
        }

        [OneTimeTearDown]
        public void TestsTearDown()
        {
            driver.Quit();
        }
    }
}
