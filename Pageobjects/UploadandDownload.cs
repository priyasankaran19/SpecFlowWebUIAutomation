using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SpecFlowWebUIAutomation.Utility;

namespace SpecFlowWebUIAutomation.Pageobjects
{
    public class UploadandDownload
    {
        private IWebDriver driver;
        private PageHelper pageHelper;
        private ConfigHelper config;


        By _upload = By.Id("uploadFile");
        String dir = AppDomain.CurrentDomain.BaseDirectory;
        By _download = By.Id("downloadButton");
        By _uploadPath = By.Id("uploadedFilePath");
        private readonly string _textId = "//div[1]/div/ul/li[8]";


        public UploadandDownload(IWebDriver driver)
        {
            config = new ConfigHelper("uploadDownloadProperties");
            this.driver = driver;
            pageHelper = new PageHelper(driver);
        }

        public void navigateToUrl()
        {
            driver.Url = config.EnvironmentVariables["pageUrl"];
        }


        public void uploadFile()
        {
            WebElement ele = (WebElement)driver.FindElement(_upload);
            Console.WriteLine(dir + "\\sampleFile.jpeg");
            ele.SendKeys(dir+"\\sampleFile.jpeg");
        }
        public void downloadFile()
        {
    driver.FindElement(_download).Click();
        }
        public void clickTextbox()
        {
            WebDriverWait wait = pageHelper.waitUntilTime(20);
            wait.Until(ExpectedConditions.ElementExists(By.XPath(_textId)));
            pageHelper.clickByXpath(_textId);
        }
        public void verifyUpload()
        {
            if (driver.FindElement(_uploadPath).Text.Contains("C:\fakepath"))
            {
                Console.WriteLine("Uploaded Successfully");
            }
            else
            {
                Console.WriteLine("File Upload failed..");

            }
        }

    }
}
