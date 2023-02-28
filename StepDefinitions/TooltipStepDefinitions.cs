using OpenQA.Selenium;
using SpecFlowWebUIAutomation.Pageobjects;

namespace SpecFlowWebUIAutomation.StepDefinitions
{
    [Binding]
    public class TooltipStepDefinitions
    {
        private IWebDriver driver;
        private readonly Tooltip tooltip;
        public TooltipStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            tooltip = new Tooltip(driver);
        }
        [Given(@"Click Nav item Tool tips")]
        public void GivenClickNavItemToolTips()
        {
            tooltip.geturl();
        }

        [When(@"Move the mouse over Hover over me button")]
        public void WhenMoveTheMouseOverHoverOverMeButton()
        {
            tooltip.mouseOver();
        }

        [Then(@"The Tooltip message should be displayed")]
        public void ThenTheTooltipMessageShouldBeDisplayed()
        {
            tooltip.validate();
        }

    }
}
