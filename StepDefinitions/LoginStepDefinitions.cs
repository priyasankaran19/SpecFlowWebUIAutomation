using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowWebUIAutomation.Pageobjects;

namespace SpecFlowWebUIAutomation.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private IWebDriver driver;
        private readonly Login loginpageHelper;

        public LoginStepDefinitions(IWebDriver driver)
        {
           this.driver = driver;
            loginpageHelper = new Login(driver);
        }

        [Given(@"I navigate to Login url")]
        public void GivenINavigateToLoginUrl()
        {
            loginpageHelper.gotoLoginUrl();
        }


        [When(@"I Click New User button")]
        public void WhenIClickNewUserButton()
        {
            loginpageHelper.clickNewUser();
        }

        [When(@"Enter the following user details:")]
        public void WhenEnterTheFollowingUserDetails(Table table)
        {
           loginpageHelper.updateUserDetails(table);
        }


        [When(@"I click Register")]
        public void WhenIClickRegister()
        {
            loginpageHelper.clickRegister();
        }


        [Then(@"I get output ""([^""]*)""")]
        public void ThenIGetOutput(string expectedText)
        {
            loginpageHelper.getOutputText();
            Assert.AreEqual(expectedText, loginpageHelper.getOutputText());
        }

        [When(@"I enter the following Login details:")]
        public void WhenIEnterTheFollowingLoginDetails(Table table)
        {
            loginpageHelper.updateLoginDetails(table);
        }

        [When(@"I click Login")]
        public void WhenIClickLogin()
        {
            loginpageHelper.clickLogin();
        }

        [Then(@"I check loggedin_user is ""([^""]*)""")]
        public void ThenICheckLoggedin_UserIs(string expectedUserId)
        {
            string currentUserId = loginpageHelper.getLoggedinUser();
            Assert.AreEqual(expectedUserId, currentUserId); 
        }
    }
}
