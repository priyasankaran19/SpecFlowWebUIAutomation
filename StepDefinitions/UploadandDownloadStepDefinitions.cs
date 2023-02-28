using OpenQA.Selenium;
using SpecFlowWebUIAutomation.Pageobjects;

namespace SpecFlowWebUIAutomation.StepDefinitions
{
    [Binding]
    public class UploadandDownloadStepDefinitions
    {
        private IWebDriver driver;
        private readonly UploadandDownload uploadpageHelper;
        public UploadandDownloadStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            uploadpageHelper = new UploadandDownload(driver);
        }

        [Given(@"The url for the uploadDownload webpage")]
        public void GivenTheUrlForTheUploadDownloadWebpage()
        {
            uploadpageHelper.navigateToUrl();
        }

        [Given(@"Click Nav item UploadandDownload")]
    public void GivenClickNavItemUploadandDownload()
    {
            uploadpageHelper.clickTextbox();
        }

    [When(@"Click the upload Option")]
        public void WhenClickTheUploadOption()
        {
            uploadpageHelper.uploadFile();  
        }

        [Then(@"File should get uploaded successfully")]
        public void ThenFileShouldGetUploadedSuccessfully()
        {

            uploadpageHelper.verifyUpload();

        }
        [When(@"Click the download Option")]
        public void WhenClickTheDownloadOption()
        {
            uploadpageHelper.downloadFile();
        }

        [Then(@"File should get downloaded successfully")]
        public void ThenFileShouldGetDownloadedSuccessfully()
        {
           
        }

    }
}
