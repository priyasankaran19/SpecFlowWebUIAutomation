using OpenQA.Selenium;
using SpecFlowWebUIAutomation.Pageobjects;

namespace SpecFlowWebUIAutomation.StepDefinitions
{
    [Binding]
    public class SortableStepDefinitions
    {
        private IWebDriver driver;
        private Sortable sortableHelper;
        public SortableStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            sortableHelper = new Sortable(driver);
        }
        [Given(@"The url for the Sortable webpage")]
        public void GivenTheUrlForTheSortableWebpage()
        {
            sortableHelper.geturl();
        }

        [When(@"Move the elements in descending order")]
        public void WhenMoveTheElementsInDescendingOrder()
        {
            sortableHelper.validate();
        }

        [Then(@"The elements should be sorted")]
        public void ThenTheElementsShouldBeSorted()
        {

        }
        }
    }
