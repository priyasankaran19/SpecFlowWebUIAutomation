using OpenQA.Selenium;
using SpecFlowWebUIAutomation.Pageobjects;
using TechTalk.SpecFlow.Assist;
using static SpecFlowWebUIAutomation.Pageobjects.Textbox;

namespace SpecFlowWebUIAutomation.StepDefinitions
{
    [Binding]
    public sealed class TextBoxStepDefinitions
    {
        private IWebDriver driver;
        private Textbox textPageHelper;
        private PageHelper pageHelper;

       public TextBoxStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            pageHelper = new PageHelper(driver);
            textPageHelper = new Textbox(driver);
        }
        [Given(@"The url for the webpage")]
        public void GivenTheUrlForTheWebpage()
        {
            Console.WriteLine("I'm on landing page");
        }

        [Given(@"Click Nav item Text Box")]
        public void GivenClickNavItemTextBox()
        {
            textPageHelper.clickTextbox();
        }


        [Given(@"I entered the following data to the form:")]
        public void GivenIEnteredTheFollowingDataToTheForm(Table table)
        {
            TextForm textFields = table.CreateInstance<TextForm>();
            textFields = table.CreateInstance<Textbox.TextForm>();
            textPageHelper.setFullName(textFields.fullName);
            textPageHelper.setEmail(textFields.email);
            textPageHelper.setCurrentAddress(textFields.currentAddress);
            textPageHelper.setPermanentAddress(textFields.permanentAddress);
        }

        [Given(@"I click Submit button")]
        public void GivenIClickSubmitButton()
        {
            pageHelper.clickById("submit");
        }

        [Then(@"Verify the data post submit")]
        public void ThenVerifyTheDataPostSubmit()
        {
            textPageHelper.verify();
        }


    }

}
