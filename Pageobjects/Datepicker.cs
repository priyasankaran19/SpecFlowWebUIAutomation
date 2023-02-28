using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowWebUIAutomation.Utility;


namespace SpecFlowWebUIAutomation.Pageobjects
{
    public class Datepicker
    {

        private IWebDriver driver;
        private PageHelper pageHelper;
        private ConfigHelper config;

        private readonly string url = "https://demoqa.com/date-picker";
        //Select Date fields
        readonly By date = By.Id("datePickerMonthYearInput");
        readonly By month = By.ClassName("react-datepicker__month-select");
        readonly By year = By.ClassName("react-datepicker__year-select");
        readonly By days = By.CssSelector("div.react-datepicker__day");
        //Dateandtime fields
        By dateandtime = By.Id("dateAndTimePickerInput");

        public Datepicker(IWebDriver driver)
        {
            config = new ConfigHelper("datepickerProperties");
            this.driver = driver;
            pageHelper = new PageHelper(driver);

        }

        public void navigateToUrl()
        {
            driver.Url = config.EnvironmentVariables["pageUrl"];
        }

        public void enterDate(string dateValue)
        {
            string datePickerMonthYearInput = config.EnvironmentVariables["datePickerInputId"];
            pageHelper.setTextById(datePickerMonthYearInput, dateValue);
        }
        
        public void enterDateTime(string dateTimeValue)
        {
            string datePickerTimeInput = config.EnvironmentVariables["dateAndTimePickerInputId"];
            pageHelper.setTextById(datePickerTimeInput, dateTimeValue);
        }

}
}
