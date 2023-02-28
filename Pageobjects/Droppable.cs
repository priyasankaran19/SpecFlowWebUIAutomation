using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SpecFlowWebUIAutomation.Utility;

namespace SpecFlowWebUIAutomation.Pageobjects
{
    public class Droppable
    {

        private IWebDriver driver;
        private PageHelper pageHelper;
        private ConfigHelper config;

        public Droppable(IWebDriver driver)
        {
            config = new ConfigHelper("dragAndDropProperties");
            this.driver = driver;
            pageHelper = new PageHelper(driver);
        }

        public void navigateToUrl()
        {
            driver.Url = config.EnvironmentVariables["pageUrl"];
        }

        public void dragAnddrop()
        {
            pageHelper.dragAndDrop(config.EnvironmentVariables["draggableId"], config.EnvironmentVariables["droppableId"]);
        }

        public void dropOffset()
        {

            pageHelper.DragAndDropToOffset(config.EnvironmentVariables["draggableId"]);
        }

        public void ValidateWithinTheBox()
        {
            var value = pageHelper.getTextbyId(config.EnvironmentVariables["droppableId"]);
            
            Assert.AreEqual("Dropped!", value);

        }

        public void ValidateOutsideTheBox()
        {
            var value = pageHelper.getTextbyId(config.EnvironmentVariables["droppableId"]);

            Assert.AreNotEqual("Dropped!", value);

        }

    }
    }
