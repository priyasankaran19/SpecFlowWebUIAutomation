using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SpecFlowWebUIAutomation.Utility;

namespace SpecFlowWebUIAutomation.Pageobjects
{
    public class Autocomplete
    {
        private IWebDriver driver;
        private PageHelper pageHelper;
        private ConfigHelper config;

        public Autocomplete(IWebDriver driver)
        {
            config = new ConfigHelper("autocompleteProperties");
            this.driver = driver;
            pageHelper = new PageHelper(driver);
        }

        public void navigateToUrl()
        {
            driver.Url = config.EnvironmentVariables["pageUrl"];
        }

        public void autoCompleteSingle()
        {
            WebDriverWait wait = pageHelper.waitUntilTime(20);
            string singleTextBox = config.EnvironmentVariables["autocompleteSingleXpath"];

            wait.Until(ExpectedConditions.ElementExists(By.XPath(singleTextBox)));

            string textValue1 = config.EnvironmentVariables["textValue1"];
            pageHelper.setTextByXpath(singleTextBox, textValue1);

            wait.Until(ExpectedConditions.ElementExists(By.XPath(singleTextBox)));
            pageHelper.setTextByXpath(singleTextBox, Keys.Enter);
        }
        public void autoCompletemultiple()
        {
            WebDriverWait wait = pageHelper.waitUntilTime(20);
            string multiTextBox = config.EnvironmentVariables["autocompleteMultipleXPath"];
            wait.Until(ExpectedConditions.ElementExists(By.XPath(multiTextBox)));

            string textValue1 = config.EnvironmentVariables["textValue1"];
            pageHelper.setTextByXpath(multiTextBox, textValue1);

            wait.Until(ExpectedConditions.ElementExists(By.XPath(multiTextBox)));

            pageHelper.setTextByXpath(multiTextBox, Keys.Enter);

            string textValue2 = config.EnvironmentVariables["textValue2"];
            pageHelper.setTextByXpath(multiTextBox, textValue2);

            wait.Until(ExpectedConditions.ElementExists(By.XPath(multiTextBox)));

            pageHelper.setTextByXpath(multiTextBox, Keys.Enter);
        }

        private void compareAutocompleteText(string path, string textValue)
        {
            string autocompleteTextValue1Path = config.EnvironmentVariables[path];
            string expectedTextValue1 = pageHelper.getTextbyXpath(autocompleteTextValue1Path);
            string textValue1 = config.EnvironmentVariables[textValue];
            Assert.AreEqual(textValue1, expectedTextValue1);
        }

        public void singleAutoCompleteCompare()
        {
            compareAutocompleteText("autocompleteSignleTextValuePath", "textValue1");
        }

        public void multipleAutoCompleteCompare()
        {
            compareAutocompleteText("autocompleteTextValue1Path", "textValue1");
            compareAutocompleteText("autocompleteTextValue2Path", "textValue2");
        }

    }
}
