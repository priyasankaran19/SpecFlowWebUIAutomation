using Gherkin.CucumberMessages.Types;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace SpecFlowWebUIAutomation.Pageobjects
{
    public class PageHelper
    {
        private IWebDriver driver;
        private IJavaScriptExecutor executor;
        public WebDriverWait wait;
        Actions action;

        public PageHelper(IWebDriver driver)
        {
            this.driver = driver;
            executor = (IJavaScriptExecutor)driver;
            action = new Actions(driver);
        }

        public void clickById(string id)
        {
            IWebElement ele = driver.FindElement(By.Id(id));
            executor.ExecuteScript("arguments[0].scrollIntoView(true);", ele);
            ele.Click();
        }
        public void rightClickByID(string id)
        {
            WebElement ele = (WebElement)driver.FindElement(By.Id(id));
            action.ContextClick(ele).Perform();
        }

        public void doubleClickById(string id)
        {
            WebElement ele = (WebElement)driver.FindElement(By.Id(id));
            action.DoubleClick(ele).Perform();
        }

        public void click(string elementToClick)
        {
            By ele = By.CssSelector(elementToClick);
            driver.FindElement(ele).Click();
        }

        public void clickByXpath(string xpath)
        {
            By ele = By.XPath(xpath);
            driver.FindElement(ele).Click();
        }

        public string getTextbyXpath(string xpath)
        {
            return driver.FindElement(By.XPath(xpath)).GetAttribute("innerHTML");
        }

        public string getTextbyId(string id) 
        {
            return driver.FindElement(By.Id(id)).Text;
        }

        public bool isElementPresent(string id)
        {
            return driver.FindElements(By.Id(id)).Count > 0;
        }

        public void setTextById(string id, string text)
        {
            driver.FindElement(By.Id(id)).SendKeys(text);
        }

        public void setTextByXpath(string xPath, string text)
        {
            driver.FindElement(By.XPath(xPath)).SendKeys(text);
        }

        public void waitFor(int waitingTime)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(waitingTime);
        }

        public WebDriverWait waitUntilTime(double  waitTime)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTime));
            return wait;
        }
        public void dragAndDrop(string sourceId, string targetId)
        {
            var source = driver.FindElement(By.Id(sourceId));
            var target = driver.FindElement(By.Id(targetId));
            action.DragAndDrop(source, target).Perform();
        }

        public void DragAndDropToOffset(string sourceId)
        {
            var source = driver.FindElement(By.Id(sourceId));
            action.DragAndDropToOffset(source, 100, 100).Perform();
        }
    }

}
