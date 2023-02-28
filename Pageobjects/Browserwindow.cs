using AventStack.ExtentReports.Configuration;
using OpenQA.Selenium;
using SpecFlowWebUIAutomation.Utility;

namespace SpecFlowWebUIAutomation.Pageobjects
{
    public class Browserwindow
    {
        private IWebDriver driver;
        private PageHelper pageHelper;
        private ConfigHelper config;

        public Browserwindow(IWebDriver driver)
        {
            config = new ConfigHelper("browserWindowProperties");
            this.driver = driver;
            pageHelper = new PageHelper(driver);
        }

        public void navigateToUrl()
        {
            driver.Url = config.EnvironmentVariables["pageUrl"];
        }

        public void clicknewTab()
        {
            pageHelper.clickById(config.EnvironmentVariables["newTabId"]);
        }

        public void clicknewWindow()
        {
            pageHelper.clickById(config.EnvironmentVariables["newWindowId"]);
        }

        public void clicknewWindowMessage()
        {
            pageHelper.clickById(config.EnvironmentVariables["newWindowMessageId"]);
        }

        public void clickTextbox()
        {
            pageHelper.clickByXpath(config.EnvironmentVariables["textBoxPath"]);
        }
    }
}
