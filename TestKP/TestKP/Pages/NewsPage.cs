using OpenQA.Selenium;
using TestKP.InitElements;

namespace TestKP
{
    class NewsPage : Page
    {
        public IWebElement MainBlock;
        public IWebElement SubmitButton;
        public IWebElement ClearButton;
        public IWebElement LastNameField;
        public IWebElement FirstNameField;
        public IWebElement SecondNameField;
        public IWebElement EmailField;
        public IWebElement RankDropBox;
        public IWebElement BirthDayField;
        public IWebElement MaleRadioButton;
        public IWebElement FemaleRadioButton;
        public IWebElement CommentField;
        public IWebElement FirstCheckBox;
        public IWebElement SecondCheckBox;

        public NewsPage(IWebDriver driver): base(driver)
        {
            NewsPageElements.InitNewsPageElements(driver, this);
        }

        public void FillRequiredFields(string lastName, string firstName, string email)
        {
            LastNameField.SendKeys(lastName);
            FirstNameField.SendKeys(firstName);
            EmailField.SendKeys(email);
            FirstCheckBox.Click();
        }

        public bool IsRequiredFieldsClear()
        {
            if (string.IsNullOrEmpty(LastNameField.Text) &&
                string.IsNullOrEmpty(FirstNameField.Text) &&
                string.IsNullOrEmpty(EmailField.Text) &&
                !(FirstCheckBox.Selected))
            {
                return true;
            }

            return false;
        }

        public bool IsAlertDisplayed()
        {
            if (Driver.SwitchTo().Alert() != null)
            {
                Driver.SwitchTo().Alert().Accept();
                return true;
            }
            Driver.SwitchTo().Alert().Accept();
            return false;
        }
    }
}
