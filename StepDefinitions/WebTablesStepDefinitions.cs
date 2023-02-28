using OpenQA.Selenium;
using SpecFlowWebUIAutomation.Pageobjects;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowWebUIAutomation.StepDefinitions
{
    [Binding]
    public class WebTablesStepDefinitions
    {
        private IWebDriver driver;
        private Webtable webtablePageHelper;
        private PageHelper pageHelper;
      
        public WebTablesStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            webtablePageHelper = new Webtable(driver);
            pageHelper= new PageHelper(driver);
        }
        [Given(@"Click Nav item Web Tables")]
        public void GivenClickNavItemWebTables()
        {
            webtablePageHelper.clickTextbox();
        }

        [When(@"Click the edit button")]
        public void WhenClickTheEditButton()
        {
            webtablePageHelper.clickEdit();
        }

        [When(@"Edit the table with the following data")]
        public void WhenEditTheTableWithTheFollowingData(Table table)
        {
            Webtable.WebtableForm textFields = table.CreateInstance<Webtable.WebtableForm>();
            webtablePageHelper.setirstName(textFields.firstName);
            webtablePageHelper.setlastName(textFields.lastName);
            webtablePageHelper.setEmail(textFields.email);
            webtablePageHelper.setage(textFields.age);
            webtablePageHelper.setSalary(textFields.salary);
            webtablePageHelper.setdepartment(textFields.department);
        }

        [When(@"Click the submit button")]
        public void WhenClickTheSubmitButton()
        {
            webtablePageHelper.clickSubmit();
        }

        [Then(@"Data should get saved successfully")]
        public void ThenDataShouldGetSavedSuccessfully()
        {
        
                Console.WriteLine("Success");
        }

    }
}
