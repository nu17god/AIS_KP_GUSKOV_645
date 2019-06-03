using OpenQA.Selenium;

namespace TestKP.InitElements
{
    static class NewsPageElements
    {
        public static void InitNewsPageElements(IWebDriver driver, NewsPage newsPage)
        {
            newsPage.MainBlock = driver.FindElement(By.Id("NewsPage"));
            newsPage.ClearButton = driver.FindElement(By.XPath("//div[2]/div[2]/div[2]/form/div[10]/input[2]"));
            newsPage.SubmitButton = driver.FindElement(By.XPath("//div[2]/div[2]/div[2]/form/div[10]/input[1]"));
            newsPage.LastNameField = driver.FindElement(By.XPath("//*[@id='lastname']"));
            newsPage.FirstNameField = driver.FindElement(By.XPath("//*[@id='name']"));
            newsPage.SecondNameField = driver.FindElement(By.XPath("//*[@id='secondname']"));
            newsPage.EmailField = driver.FindElement(By.XPath("//*[@id='email']"));
            newsPage.RankDropBox = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[5]/select"));
            newsPage.BirthDayField = driver.FindElement(By.XPath("//*[@id='date']"));
            newsPage.MaleRadioButton = driver.FindElement(By.XPath("//*[@id='Male']"));
            newsPage.FemaleRadioButton = driver.FindElement(By.XPath("//*[@id='Female']"));
            newsPage.CommentField = driver.FindElement(By.XPath("//*[@id='comment']"));
            newsPage.FirstCheckBox = driver.FindElement(By.XPath("//*[@id='license']"));
            newsPage.SecondCheckBox = driver.FindElement(By.XPath("//*[@id='spam']"));
        }
    }
}
