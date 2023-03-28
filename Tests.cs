using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    public class UnitTests
    {
        private IWebDriver driver;
        private const string baseUrl = "https://rahulshettyacademy.com/loginpagePractise/";

        [SetUp]
        public void SetUp()
        {
            this.driver = new ChromeDriver();
            driver.Url = baseUrl;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            
        }
        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(4000);
            driver.Quit();
        }

        [Test]
        public void Tests()
        {
            username.SendKeys("rahulshettyacademy");
            password.SendKeys("learning");
            user.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("okayBtn")));
            okay.Click();
            terms.Click();
            signIn.Click();
            addIphone.Click();
            addSamsung.Click();
            addNokia.Click();
            checkOut.Click();
            btnOrder.Click();
            country.SendKeys("Bulgaria");
            bulgaria.Click();
            checkBox.Click();
            purchase.Click();
            Assert.That(success.Text, Is.EqualTo("Success!"));
        }

        public IWebElement username => driver.FindElement(By.Id("username"));
        public IWebElement password => driver.FindElement(By.Id("password"));
        public IWebElement user => driver.FindElement(By.XPath("(//span[contains(@class,'checkmark')])[2]"));
        public IWebElement okay => driver.FindElement(By.Id("okayBtn"));
        public IWebElement dropdown => driver.FindElement(By.XPath("//select[contains(@class,'form-control')]"));
        public IWebElement terms => driver.FindElement(By.Id("terms"));
        public IWebElement signIn => driver.FindElement(By.Id("signInBtn"));
        public IWebElement addIphone => driver.FindElement(By.XPath("(//button[@class='btn btn-info'][contains(.,'Add')])[1]"));
        public IWebElement addSamsung => driver.FindElement(By.XPath("(//i[contains(@class,'zmdi zmdi-shopping-cart')])[2]"));
        public IWebElement addNokia => driver.FindElement(By.XPath("(//button[@class='btn btn-info'][contains(.,'Add')])[3]"));
        public IWebElement checkOut => driver.FindElement(By.XPath("//a[contains(@class,'nav-link btn btn-primary')]"));
        public IWebElement btnOrder => driver.FindElement(By.ClassName("btn-success"));
        public IWebElement country => driver.FindElement(By.Id("country"));
        public IWebElement bulgaria => driver.FindElement(By.XPath("//a[contains(.,'Bulgaria')]"));
        public IWebElement checkBox => driver.FindElement(By.XPath("//label[contains(@for,'checkbox2')]"));
        public IWebElement purchase => driver.FindElement(By.ClassName("btn-lg"));
        public IWebElement success => driver.FindElement(By.XPath("//strong[contains(.,'Success!')]"));
    }
}