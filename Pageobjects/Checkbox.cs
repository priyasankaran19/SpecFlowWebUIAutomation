using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SpecFlowWebUIAutomation.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowWebUIAutomation.Pageobjects
{
    public class Checkbox
    {
        private IWebDriver driver;
        private PageHelper pageHelper;
        private ConfigHelper config;
        private WebDriverWait wait;

        public Checkbox(IWebDriver driver)
        {
            config = new ConfigHelper("checkboxProperties");
            this.driver = driver;
            pageHelper = new PageHelper(driver);
        }

        public void navigateToUrl()
        {
            driver.Url = config.EnvironmentVariables["pageUrl"];
        }

        public void clickFirstNavItem()
        {
            wait = pageHelper.waitUntilTime(20);
            wait.Until(ExpectedConditions.ElementExists(By.Id(config.EnvironmentVariables["fistNavItemId"])));
            pageHelper.clickById(config.EnvironmentVariables["fistNavItemId"]);
        }

        public void clickTreeNode(string treeNode) {
            string selector = string.Empty;
            switch (treeNode)
            {
                case "Home":
                    selector = config.EnvironmentVariables["fistNodeXpath"];
                    pageHelper.clickByXpath(selector);
                    break;
                case "Downloads":
                    selector = config.EnvironmentVariables["secondNodeXpath"];
                    pageHelper.clickByXpath(selector);
                    break;
            }
        }

        public void selectLeafNode(string leafNode)
        {
            string selector = string.Empty;
            switch (leafNode)
            {
                case "WordFile":
                    selector = config.EnvironmentVariables["leafNodeXpath"];
                    pageHelper.clickByXpath(selector);
                    break;
            }
        }

        public string getSelectedText()
        {
            WebDriverWait wait = pageHelper.waitUntilTime(20);
            string selectedTextXpath = config.EnvironmentVariables["selectedTextXpath"];

            wait.Until(ExpectedConditions.ElementExists(By.XPath(selectedTextXpath)));

            return pageHelper.getTextbyXpath(selectedTextXpath);
        }

        public bool doesResultExists()
        {
            string selectedTextContainerId = config.EnvironmentVariables["selectedTextContainerId"];
            return pageHelper.isElementPresent(selectedTextContainerId);

        }
    }
}
