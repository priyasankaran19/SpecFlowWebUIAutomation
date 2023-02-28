using OpenQA.Selenium;
using SpecFlowWebUIAutomation.Pageobjects;

namespace SpecFlowWebUIAutomation.StepDefinitions
{
    [Binding]
    public class DatePickerStepDefinitions
    {
        private IWebDriver driver;
        private readonly Datepicker datepageHelper;
        public DatePickerStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            datepageHelper = new Datepicker(driver);
        }
        [Given(@"The url for the Date picker")]
        public void GivenTheUrlForTheDatePicker()
        {
            datepageHelper.navigateToUrl();
        }

        [When(@"Enter the date ""([^""]*)"" in Select Date field")]
        public void WhenEnterTheDateInSelectDateField(string dateValue)
        {
            datepageHelper.enterDate(dateValue);
        }

        [When(@"Enter the datetime ""([^""]*)"" in Date and Time field")]
        public void WhenEnterTheDatetimeInDateAndTimeField(string datetimeValue)
        {
            datepageHelper.enterDateTime(datetimeValue);
        }

        [Then(@"Date should be selected as per the input")]
        public void ThenDateShouldBeSelectedAsPerTheInput()
        {
        }

        [Then(@"Date and Time should be selected as per the input")]
        public void ThenDateAndTimeShouldBeSelectedAsPerTheInput()
        {
        }


    }
}
