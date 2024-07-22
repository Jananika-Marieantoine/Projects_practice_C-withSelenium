using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Practice
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            /*//Initializing Chrome Driver
            string chromeDriverPath = @"C:\Users\91971\chromedriver-win64\chromedriver.exe";
            ChromeOptions options = new();
            ChromeDriver chromeDriver = new(chromeDriverPath, options);
            using IWebDriver driver = chromeDriver;*/
        }

        [Test]
        public void Test1()
        {
            //initiating a brower
            IWebDriver driver = new ChromeDriver();
            //navigate to URl
            driver.Navigate().GoToUrl("https://letcode.in/forms");
            //Maximize window
            driver.Manage().Window.Maximize();
            //Enter fristName
            IWebElement webElement = driver.FindElement(By.Id("firstname"));
            webElement.SendKeys("Jananika");
            //Enter LastName
            IWebElement webElement1 = driver.FindElement(By.Id("lasttname"));
            webElement1.SendKeys("Marieantoine");
            //Enter EmailID
            IWebElement email = driver.FindElement(By.Id("email"));
            Thread.Sleep(1000);
            //performing key actions
            Actions actions = new Actions(driver);
            actions.Click(email)
                   .KeyDown(Keys.Control)
                   .SendKeys("a")
                   .KeyUp(Keys.Control)
                   .SendKeys(Keys.Delete)
                   .Perform();
            //Giving email as input
            email.SendKeys("jenijananika31799@gmail.com");
            Thread.Sleep(1000);
            //dropdown
            IWebElement country = driver.FindElement(By.XPath("//option[@data-countrycode='IN']"));
            country.Click();
            //number
            IWebElement Number = driver.FindElement(By.Id("Phno"));
            Number.SendKeys("7397707936");
            //Address
            IWebElement Adr1 = driver.FindElement(By.Id("Addl1"));
            Adr1.SendKeys("n0226,rara naga");
            IWebElement Adr2 = driver.FindElement(By.Id("Addl2"));
            Adr2.SendKeys("Chennai");
            IWebElement State = driver.FindElement(By.Id("state"));
            State.SendKeys("TamilNadu");
            IWebElement code = driver.FindElement(By.Id("postalcode"));
            code.SendKeys("603202");
            //country
            IWebElement webElement2 = driver.FindElement(By.XPath("//option[@value='India']"));
            webElement2.Click();
            //DOB
            IWebElement DOB = driver.FindElement(By.Id("Date"));
            DOB.SendKeys("31-07-1999");
            //Gender
            IWebElement Gender = driver.FindElement(By.Id("female"));
            Gender.Click();
            //Conditions
            IWebElement Con = driver.FindElement(By.XPath("//input[@type='checkbox']"));
            Con.Click();
            //Submit
            IWebElement Submit = driver.FindElement(By.XPath("//input[@type='submit']"));
            Submit.Click();
            Thread.Sleep(1000);
            //Closing driver
            driver.Quit();


        }
    }
}