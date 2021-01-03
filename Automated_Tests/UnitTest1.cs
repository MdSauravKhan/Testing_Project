using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NewTest
{
    public class Tests

    {
        IWebDriver driver;

        //Test case 1
        [Test]
        public void InitializeHomePage()
        {
            driver = new ChromeDriver();
            driver.Url = "file:///G:/8040_project/Main.html";

        }

        //Test case 2
        [Test]
        public void LaunchHomePage_ClickNewButton_LaunchSallerInformationPage()
        {

            driver.FindElement(By.ClassName("Name")).Click();
            driver.FindElement(By.Id("home")).Click();
        }


        //Test case 3
        [Test]
         public void LaunchHomePage_ClickSearchButton_LaunchSearchPage()
        {
            driver.FindElement(By.ClassName("Search")).Click();
            driver.FindElement(By.Id("home")).Click();
        }

        //Test case 4
        [Test]
        public void LaunchSellerInformationPage_ClickSubmitButton_DisplaySubmit()
        {
            driver.FindElement(By.ClassName("Name")).Click();
            driver.FindElement(By.Id("fname")).SendKeys("Saurav");
            driver.FindElement(By.Id("lname")).SendKeys("khan");
            driver.FindElement(By.Id("city")).SendKeys("Cambridge");
            driver.FindElement(By.Id("email")).SendKeys("mkhan@conestoga.on.ca");
            driver.FindElement(By.Id("number")).SendKeys("215646321");
            driver.FindElement(By.Id("address")).SendKeys("Linden Drive");
            driver.FindElement(By.Id("make")).SendKeys("Toyota");
            driver.FindElement(By.Id("model")).SendKeys("Camry");
            driver.FindElement(By.Id("year")).SendKeys("2019");
            driver.FindElement(By.Id("submit")).Click();           

        }


    }
}