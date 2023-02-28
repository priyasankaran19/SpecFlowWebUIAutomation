using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SpecFlowWebUIAutomation.Pageobjects;

namespace SpecFlowWebUIAutomation.StepDefinitions
{
    [Binding]
    public class ButtonsStepDefinitions
    {
        private IWebDriver driver;
        private Button buttonPageHelper;
        Actions action;

        public ButtonsStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            buttonPageHelper = new Button(driver);
            action=new Actions(driver);
        }

        [Given(@"The url for the Button webpage")]
        public void GivenTheUrlForTheButtonWebpage()
        {
            buttonPageHelper.navigateToUrl();
        }


        [Given(@"Click Nav item Buttons")]
        public void GivenClickNavItemButtons()
        {
            buttonPageHelper.clickTextbox();
        }
        [When(@"I click Right Click me button")]
        public void WhenIClickRightClickMeButton()
        {
       
           buttonPageHelper.rightClick();
        }

        [Then(@"The message You have done a right click should be displayed")]
        public void ThenTheMessageYouHaveDoneARightClickShouldBeDisplayed()
        {
            buttonPageHelper.verifyrightClick();
        }
        [When(@"I click Double Click me button")]
        public void WhenIClickDoubleClickMeButton()
        {
            buttonPageHelper.doubleClick();
        }
        [Then(@"The message You have done a double click should be displayed")]
        public void ThenTheMessageYouHaveDoneADoubleClickShouldBeDisplayed()
        {
            buttonPageHelper.verifydoubleClick();
        }

        [When(@"I click Click me button")]
        public void WhenIClickClickMeButton()
        {
            buttonPageHelper.dynamicClick();
        }


        [Then(@"The message You have done a dynamic click should be displayed")]
        public void ThenTheMessageYouHaveDoneADynamicClickShouldBeDisplayed()
        {
            buttonPageHelper.verifydynamicClick();  
        }

    }
}
