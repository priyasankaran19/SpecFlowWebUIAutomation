using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowWebUIAutomation.Pageobjects;

namespace SpecFlowWebUIAutomation.StepDefinitions
{
    [Binding]
    public class AutocompleteStepDefinitions
    {
        private IWebDriver driver;
        private Autocomplete autocompleteHelper;
        public AutocompleteStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            autocompleteHelper = new Autocomplete(driver);
        }

        [Given(@"The url for the Autocomplete webpage")]
        public void GivenTheUrlForTheAutocompleteWebpage()
        {
            autocompleteHelper.navigateToUrl();
        }

        [When(@"I enter the single colour name in the text box")]
        public void WhenIEnterTheSingleColourNameInTheTextBox()
        {
            autocompleteHelper.autoCompleteSingle();
        }

        [When(@"I enter the multiple colour names in the text box")]
        public void WhenIEnterTheMultipleColourNamesInTheTextBox()
        {
            autocompleteHelper.autoCompletemultiple();
        }

        [Then(@"Autocomplete of multiple names should exists")]
        public void ThenAutocompleteOfMultipleNamesShouldExists()
        {
            autocompleteHelper.multipleAutoCompleteCompare();
        }

        [Then(@"Autocomplete of single names should exists")]
        public void ThenAutocompleteOfSingleNamesShouldExists()
        {
            autocompleteHelper.singleAutoCompleteCompare();
        }

    }
}
