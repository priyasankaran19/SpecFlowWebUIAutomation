using OpenQA.Selenium;
using SpecFlowWebUIAutomation.Pageobjects;

namespace SpecFlowWebUIAutomation.StepDefinitions
{
    [Binding]
    public class BrowserwindowsStepDefinitions
    {
        private IWebDriver driver;
        private readonly Browserwindow browserpageHelper;
        public BrowserwindowsStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            browserpageHelper = new Browserwindow(driver);
        }
        [Given(@"The url for the Browserwindows webpage")]
        public void GivenTheUrlForTheBrowserwindowsWebpage()
        {
            browserpageHelper.navigateToUrl();
        }

        [Given(@"Click Nav item Browser windows")]
        public void GivenClickNavItemBrowserWindows()
        {
            browserpageHelper.clickTextbox();

        }

        [When(@"I click the New Tab button")]
        public void WhenIClickTheNewTabButton()
        {
            browserpageHelper.clicknewTab();
        }

        [Then(@"The New Tab will be opened with sample message")]
        public void ThenTheNewTabWillBeOpenedWithSampleMessage()
        {
           
        }

        [When(@"I click the New Window button")]
        public void WhenIClickTheNewWindowButton()
        {
            browserpageHelper.clicknewWindow();
            
        }

        [Then(@"The New Window will be opened sample message")]
        public void ThenTheNewWindowWillBeOpenedSampleMessage()
        {
           
        }

        [When(@"I click the New Window Message button")]
        public void WhenIClickTheNewWindowMessageButton()
        {
            browserpageHelper.clicknewWindowMessage();
        }

        [Then(@"The New Window message will be opened")]
        public void ThenTheNewWindowMessageWillBeOpened()
        {
            
        }
    }
}
