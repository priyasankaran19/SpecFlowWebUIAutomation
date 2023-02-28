using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SpecFlowWebUIAutomation.Pageobjects
{
    public class Textbox
    {
        public class TextForm
        {
            public string fullName { get; set; }
            public string email { get; set; }

            public string currentAddress { get; set; }

            public string permanentAddress { get; set; }
        }

        private IWebDriver driver;
        private PageHelper pageHelper;
        readonly By _name = By.CssSelector("input#userName");
        readonly By _email = By.CssSelector("input#userEmail");
        readonly By _cAddr = By.CssSelector("textarea#currentAddress");
        readonly By _pAddr = By.CssSelector("textarea#permanentAddress");
        readonly By _actualFullname = By.CssSelector("p#name");
        readonly By _actualEmail=By.CssSelector("p#name");
        readonly By _actualcurAddr = By.CssSelector("p#name");
        readonly By _actualpermAddr = By.CssSelector("p#name");
        private readonly string _textId= "//div[1]/div/ul/li[1]";
        public Textbox(IWebDriver driver)
        {
            this.driver = driver;
            pageHelper=new PageHelper(driver);


        }
        public void verify()
        {
            Assert.True(driver.FindElement(_actualFullname).Text.Contains(driver.FindElement(_name).Text));
            Assert.True(driver.FindElement(_actualEmail).Text.Contains(driver.FindElement(_email).Text));
            Assert.True(driver.FindElement(_actualcurAddr).Text.Contains(driver.FindElement(_cAddr).Text));
            Assert.True(driver.FindElement(_actualpermAddr).Text.Contains(driver.FindElement(_pAddr).Text));

        }
        public void setFullName(string name)
        {
            driver.FindElement(_name).SendKeys(name);
        }
        public void setEmail(string email)
        {
            driver.FindElement(_email).SendKeys(email);
        }

        public void setCurrentAddress(string cAddr)
        {
            driver.FindElement(_cAddr).SendKeys(cAddr);
        }

        public void setPermanentAddress(string pAddr)
        {
            driver.FindElement(_pAddr).SendKeys(pAddr);
        }

        public void clickTextbox()
        {
            WebDriverWait wait = pageHelper.waitUntilTime(20);
            wait.Until(ExpectedConditions.ElementExists(By.XPath(_textId)));
            pageHelper.clickByXpath(_textId);
        }

    }
}
