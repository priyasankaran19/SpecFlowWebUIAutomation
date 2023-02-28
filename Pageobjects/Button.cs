using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using AventStack.ExtentReports.Configuration;
using SpecFlowWebUIAutomation.Utility;

namespace SpecFlowWebUIAutomation.Pageobjects
{
    public class Button
    {
        private IWebDriver driver;
        private PageHelper pageHelper;
        private ConfigHelper config;
        Actions action;
        readonly By _doubleClickmsg = By.Id("doubleClickMessage");
        readonly By _dynamicClickmsg = By.Id("dynamicClickMessage");
        String _expdoubleClickmsg = "You have done a double click";
        String _expdynamicClickmsg = "You have done a dynamic click";

        private readonly string _textId = "//div[1]/div/ul/li[5]";
        WebElement ele;
        WebDriverWait wait;

        public Button(IWebDriver driver)
        {
            config = new ConfigHelper("buttonProperties");
            this.driver = driver;
            pageHelper = new PageHelper(driver);
            action = new Actions(driver);
        }

        public void navigateToUrl()
        {
            driver.Url = config.EnvironmentVariables["pageUrl"];
        }

        public void  rightClick()
        {
            pageHelper.rightClickByID(config.EnvironmentVariables["rightClickBtnId"]);
        }

        public void doubleClick()
        {
            pageHelper.doubleClickById(config.EnvironmentVariables["doubleClickBtnId"]);
        }

        public void dynamicClick()
        {
            pageHelper.clickByXpath(config.EnvironmentVariables["dynamicClickXpath"]);
        }

        public void clickTextbox()
        {
            wait = pageHelper.waitUntilTime(20);
            wait.Until(ExpectedConditions.ElementExists(By.XPath(config.EnvironmentVariables["textboxPath"])));
            pageHelper.clickByXpath(config.EnvironmentVariables["textboxPath"]);
        }

        public void verifyrightClick()
        {
            wait = pageHelper.waitUntilTime(20);
            wait.Until(ExpectedConditions.ElementExists(By.Id(config.EnvironmentVariables["rightClickMessageId"])));

            string actualText = pageHelper.getTextbyId(config.EnvironmentVariables["rightClickMessageId"]);
            Assert.IsTrue(config.EnvironmentVariables["expectedRightClickMessageId"].Equals(actualText));
        }

        public void verifydoubleClick()
        {
            wait = pageHelper.waitUntilTime(20);
            wait.Until(ExpectedConditions.ElementExists(By.Id(config.EnvironmentVariables["doubleClickMessageID"])));

            string actualText = pageHelper.getTextbyId(config.EnvironmentVariables["doubleClickMessageID"]);
            Assert.IsTrue(config.EnvironmentVariables["expectedDoubleClickMessage"].Equals(actualText));
        }

        public void verifydynamicClick()
        {
            wait = pageHelper.waitUntilTime(20);
            wait.Until(ExpectedConditions.ElementExists(By.Id(config.EnvironmentVariables["dynamicClickMessageId"])));

            string actualText = pageHelper.getTextbyId(config.EnvironmentVariables["dynamicClickMessageId"]);
            Assert.IsTrue(config.EnvironmentVariables["expectedDynamicClickMessage"].Equals(actualText));

        }
    }
}
