using OpenQA.Selenium;
using SpecFlowWebUIAutomation.Pageobjects;

namespace SpecFlowWebUIAutomation.StepDefinitions
{
    [Binding]
    public class DroppableStepDefinitions
    {
        private IWebDriver driver;
        private Droppable droppableHelper;

        public DroppableStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            droppableHelper = new Droppable(driver);
        }

        [Given(@"The url for the Drag and Drop webpage")]
        public void GivenTheUrlForTheDragAndDropWebpage()
        {
            droppableHelper.navigateToUrl();
        }

        [When(@"Drag the element to the target")]
        public void WhenDragTheElementToTheTarget()
        {
            droppableHelper.dragAnddrop();
        }

        [Then(@"After dragging the element is within the box")]
        public void ThenAfterDraggingTheElementIsWithinTheBox()
        {
            droppableHelper.ValidateWithinTheBox();
        }
        [When(@"Drag the element not to the target")]
        public void WhenDragTheElementNotToTheTarget()
        {
            droppableHelper.dropOffset();
        }

        [Then(@"After dragging the element is outside the target")]
        public void ThenAfterDraggingTheElementIsOutsideTheTarget()
        {
            droppableHelper.ValidateOutsideTheBox();
        }

    }

}
