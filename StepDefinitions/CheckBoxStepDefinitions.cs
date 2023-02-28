using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SpecFlowWebUIAutomation.Pageobjects;

namespace SpecFlowWebUIAutomation.StepDefinitions
{
    [Binding]
    public class CheckBoxStepDefinitions
    {
        private IWebDriver driver;
        private Checkbox checkbox;

        public CheckBoxStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            checkbox = new Checkbox(driver);
        }

        [Given(@"The url for the checkbox webpage")]
        public void GivenTheUrlForTheCheckboxWebpage()
        {
           checkbox.navigateToUrl();
        }


        [Given(@"Click Nav item Check Box")]
        public void GivenClickNavItemCheckBox()
        {
            checkbox.clickFirstNavItem();
           
        }

        [Given(@"I click ""([^""]*)"" toggle")]
        public void GivenIClickToggle(string nodeName)
        {
            checkbox.clickTreeNode(nodeName);
        }

        [Given(@"I select ""([^""]*)""")]
        public void GivenISelect(string itemTobeSelected)
        {
            checkbox.selectLeafNode(itemTobeSelected);
        }

        [Then(@"""([^""]*)"" should be selected")]
        public void ThenShouldBeSelected(string selectedItem)
        {
        }


        [Then(@"""([^""]*)"" should NOT be selected")]
        public void ThenShouldNotBeSelected(string selectedItem)
        {
            Assert.AreEqual(checkbox.doesResultExists(), false);
        }

    }
}
