using OpenQA.Selenium;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SpecFlowWebUIAutomation.Utility;

namespace SpecFlowWebUIAutomation.Pageobjects
{
    public class Login
    {
        private IWebDriver driver;
        private PageHelper pageHelper;
        private ConfigHelper config;

        public class LoginForm
        {
            public string firstName { get; set; }
            public string lastName { get; set; }

            public string userName { get; set; }

            public string password { get; set; }
        }

        public Login(IWebDriver driver)
        {
            config = new ConfigHelper("loginProperties");
            this.driver = driver;
            pageHelper = new PageHelper(driver);
        }
        public void gotoLoginUrl()
        {
            driver.Url = config.EnvironmentVariables["pageUrl"];
        }
        public void clickNewUser()
        {
            string newUserId = config.EnvironmentVariables["newUserId"];
            WebDriverWait wait = pageHelper.waitUntilTime(20);
            wait.Until(ExpectedConditions.ElementExists(By.Id(newUserId)));
            pageHelper.clickById(newUserId);
        }

        public void updateUserDetails(Table table)
        {
            LoginForm userInfo = table.CreateInstance<LoginForm>();
            pageHelper.setTextById(config.EnvironmentVariables["firstnameId"], userInfo.firstName);
            pageHelper.setTextById(config.EnvironmentVariables["lastnameId"], userInfo.lastName);
            pageHelper.setTextById(config.EnvironmentVariables["userNameId"], userInfo.userName);
            pageHelper.setTextById(config.EnvironmentVariables["passwordId"], userInfo.password);
        }

        public void updateLoginDetails(Table table)
        {
            LoginForm userInfo = table.CreateInstance<LoginForm>();
            pageHelper.setTextById(config.EnvironmentVariables["userNameId"], userInfo.userName);
            pageHelper.setTextById(config.EnvironmentVariables["passwordId"], userInfo.password);
        }

        public void clickRegister() 
        {
            pageHelper.clickById(config.EnvironmentVariables["registerBtnId"]);
        }

        public void clickLogin()
        {
            pageHelper.clickById(config.EnvironmentVariables["loginBtnId"]);
        }

        public string getOutputText()
        {
            WebDriverWait wait =  pageHelper.waitUntilTime(5);
            wait.Until(ExpectedConditions.ElementExists(By.Id("name")));
            return pageHelper.getTextbyId("name");
        }

        public string getLoggedinUser() 
        {
            string userNameTextId = config.EnvironmentVariables["userNameTextId"];
            WebDriverWait wait = pageHelper.waitUntilTime(30);
            wait.Until(ExpectedConditions.ElementExists(By.Id(userNameTextId)));
            return pageHelper.getTextbyId(userNameTextId);
        }

    }
}
