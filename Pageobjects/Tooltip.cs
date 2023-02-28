using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SpecFlowWebUIAutomation.Pageobjects
{
    public class Tooltip
    {
        private IWebDriver driver;
        private PageHelper pageHelper;
        private readonly string url = "https://demoqa.com/tool-tips";
        readonly By toolTipButton = By.Id("toolTipButton");
        Actions action;       
        public Tooltip(IWebDriver driver)
        {
            this.driver = driver;
            pageHelper = new PageHelper(driver);
            action=new Actions(driver); 
        }
        public void geturl()
        {
            driver.Url = url;
        }
        public void mouseOver()
        {
            WebElement ele = (WebElement)driver.FindElement(toolTipButton);
            if (ele != null)
            {
                action.MoveToElement(ele);
            }

        }
        public void validate()
        {
   
            Console.WriteLine("You hovered over the Button");

        }
    }
    }
