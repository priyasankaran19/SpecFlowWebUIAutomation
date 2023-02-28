using OpenQA.Selenium;
using SpecFlowWebUIAutomation.Utility;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SpecFlowWebUIAutomation.Pageobjects
{
    public class Alerts
    {
        private IWebDriver driver;
        private PageHelper pageHelper;
        private ConfigHelper config;
       
        public Alerts(IWebDriver driver)
        {
            config = new ConfigHelper("alertProperties");
            this.driver = driver;
            pageHelper = new PageHelper(driver);
        }

        public void navigateToUrl()
        {
            driver.Url = config.EnvironmentVariables["pageUrl"];
        }
        public void clickPrompt()
        {
            pageHelper.clickById(config.EnvironmentVariables["promtButtonId"]);
           
        }
        public void enterDefaultTextToPrompt()
        {
            string promptText = config.EnvironmentVariables["promptText"];
            driver.SwitchTo().Alert().SendKeys(promptText);
            driver.SwitchTo().Alert().Accept();
        }

        public string getScreenText()
        {
            string promptResultId = config.EnvironmentVariables["promptResultId"];
            WebDriverWait wait = pageHelper.waitUntilTime(20);
            wait.Until(ExpectedConditions.ElementExists(By.Id(promptResultId)));
            return pageHelper.getTextbyId(promptResultId);
        }

        public string getPromptText()
        {
            return config.EnvironmentVariables["promptText"];
        }

    }
}
