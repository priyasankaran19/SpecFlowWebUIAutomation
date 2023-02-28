using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SpecFlowWebUIAutomation.Pageobjects
{
    public class Sortable
    {
        private IWebDriver driver;
        private readonly string url = "https://demoqa.com/sortable";
        readonly By prompt = By.Id("promtButton");
        readonly By promptresult = By.Id("promptResult");
        Actions action;
        By d1 = By.XPath("//*[@id=\"demo-tabpane-list\"]/div/div[1]");
        By d2 = By.XPath("//*[@id=\"demo-tabpane-list\"]/div/div[2]");
        By d3 = By.XPath("//*[@id=\"demo-tabpane-list\"]/div/div[3]");
        By d4 = By.XPath("//*[@id=\"demo-tabpane-list\"]/div/div[4]");
        By d5 = By.XPath("//*[@id=\"demo-tabpane-list\"]/div/div[5]");
        By d6=By.XPath("//*[@id=\"demo-tabpane-list\"]/div/div[6]");

        public Sortable(IWebDriver driver)
        {
            this.driver = driver;
            action = new Actions(driver);
        }
        public void geturl()
        {
            driver.Url = url;
        }

        public void validate()
        {
                IWebElement ele = driver.FindElement(d1);
                IWebElement destination1 = driver.FindElement(d1);
                IWebElement destination2 = driver.FindElement(d2);
                IWebElement destination3 = driver.FindElement(d3);
                IWebElement destination4 = driver.FindElement(d4);
                IWebElement destination5 = driver.FindElement(d5);
                IWebElement destination6 = driver.FindElement(d6);
                if (ele != null)
                {
                 Console.WriteLine("Success");
                action.DragAndDrop(ele, destination6).Perform();
                action.DragAndDrop(ele, destination5).Perform();
                action.DragAndDrop(ele, destination4).Perform();
                action.DragAndDrop(ele, destination3).Perform();
                action.DragAndDrop(ele, destination2).Perform();
                action.DragAndDrop(ele, destination1).Perform();
                action.DragAndDrop(ele, destination1).Perform();
                action.DragAndDrop(destination6, destination1).Perform();
                action.DragAndDrop(destination1, destination3).Perform();
                Console.WriteLine("Test Success");
            }
            else
                {
                    Console.WriteLine("Failed");
                }
            

        }
    }
}
