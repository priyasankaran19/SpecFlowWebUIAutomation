using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowWebUIAutomation.Pageobjects;

namespace SpecFlowWebUIAutomation.StepDefinitions
{
    [Binding]
    public class AlertsStepDefinitions
    {
        private IWebDriver driver;
        private readonly Alerts alert;
        public AlertsStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            alert = new Alerts(driver);
        }
        [Given(@"The url for the Alerts webpage")]
        public void GivenTheUrlForTheAlertsWebpage()
        {
            alert.navigateToUrl();
        }

        [When(@"I click the click me button to check the prompt box")]
        public void WhenIClickTheClickMeButtonToCheckThePromptBox()
        {
            alert.clickPrompt();
            alert.enterDefaultTextToPrompt();
        }

        [Then(@"Entered Text appeat on the screen")]
        public void ThenEnteredTextAppeatOnTheScreen()
        {
            string actualText = alert.getScreenText();
            string expectedText = alert.getPromptText();
            Assert.IsTrue(actualText.Contains(expectedText));
        }
    }
}
