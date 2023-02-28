using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SpecFlowWebUIAutomation.Pageobjects
{
    public class Webtable
    {
        public class WebtableForm
        {
            public String firstName { get; set; }
            public String lastName { get; set; }
            public String email { get; set; }
            public String age { get; set; }
            public String salary { get; set; }
            public String department { get; set; }


        }
        private IWebDriver driver;
        PageHelper pageHelper;
        readonly By _firstName = By.Id("firstName");
        readonly By _lastName = By.Id("lastName");
        readonly By _userEmail = By.Id("userEmail");
        readonly By _age = By.Id("age");
        readonly By _salary = By.Id("salary");
        readonly By _department = By.Id("department");
        readonly By _edit = By.XPath("//span[@id=\"edit-record-1\"]/*[name()='svg']/*[name()='path']");
      
        private readonly string _submit= "submit";
        private readonly string _textId = "//div[1]/div/ul/li[4]";

        public Webtable(IWebDriver driver)
        {
            this.driver = driver;
            pageHelper=new PageHelper(driver);
        }
        public void setirstName(string firstName) 
        {
            driver.FindElement(_firstName).Clear();
            driver.FindElement(_firstName).SendKeys(firstName);
        }
        public void setlastName(string lastName) 
        {
            driver.FindElement(_lastName).Clear();
            driver.FindElement(_lastName).SendKeys(lastName);
    }
        public void setEmail(string userEmail)
        {
            driver.FindElement(_userEmail).Clear();
            driver.FindElement(_userEmail).SendKeys(userEmail);
        }
        public void setage(string age) 
        {
            driver.FindElement(_age).Clear();
            driver.FindElement(_age).SendKeys(age);
        }

        public void setSalary(string salary)
        {
            driver.FindElement(_salary).Clear();
            driver.FindElement(_salary).SendKeys(salary);
        }  
        public void setdepartment(string department)
        {
            driver.FindElement(_department).Clear();
            driver.FindElement(_department).SendKeys(department);
        }
        public void clickEdit()
        {
            driver.FindElement(_edit).Click();
        }
        public void clickSubmit()
        {
            pageHelper.clickById(_submit);
        }
        public void clickTextbox()
        {
            WebDriverWait wait = pageHelper.waitUntilTime(20);
            wait.Until(ExpectedConditions.ElementExists(By.XPath(_textId)));
            pageHelper.clickByXpath(_textId);
        }
    }
}
