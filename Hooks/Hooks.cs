using AventStack.ExtentReports.Gherkin.Model;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowWebUIAutomation.Utility;

namespace SpecFlowWebUIAutomation.Hooks
{
    [Binding]
    public sealed class Hooks : ExtentReport
    {
       
        private readonly IObjectContainer container;
        public Hooks(IObjectContainer container)
        {
            this.container = container;
        }
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Console.Write("Before Test Run");
            ExtentReportInit();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Console.Write("After Test Run");
            ExtentReportTearDown();
        }
        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            Console.WriteLine("Before feature");
            feature = extent.CreateTest<Feature>(featureContext.FeatureInfo.Title);

        }
        [AfterFeature]
        public static void AfterFeature()
        {
            Console.WriteLine("After feature");
        }

        [BeforeScenario("@Test")]
        public  void BeforeScenarioWithTag()
        {
            Console.WriteLine("Running inside tagged hooks in specflow");

        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario(ScenarioContext scenarioContext)
        {
            Console.WriteLine("Before Scenario");
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            container.RegisterInstanceAs<IWebDriver>(driver);
            scenario = feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var driver = container.Resolve<IWebDriver>();
            if (driver != null)
            {
                driver.Close();
                driver.Quit();
            }
        }
        [AfterStep]
        public void AfterStep(ScenarioContext scenarioContext)
        {
            Console.WriteLine("After Step");
            string stepType = scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();
            string stepName = scenarioContext.StepContext.StepInfo.Text;
            if (scenarioContext.TestError == null)
            {
                if (stepType == "Given")
                {
                    scenario.CreateNode<Given>(stepName);
                }
                else if (stepType == "When")
                {
                    scenario.CreateNode<When>(stepName);
                }
                else if (stepType == "Then")
                {
                    scenario.CreateNode<Then>(stepName);
                }
            }
            if (scenarioContext.TestError != null)
            {
                if (stepType == "Given")
                {
                    scenario.CreateNode<Given>(stepName).Fail(scenarioContext.TestError.Message);
                }
                else if (stepType == "When")
                {
                    scenario.CreateNode<When>(stepName).Fail(scenarioContext.TestError.Message);
                }
                else if (stepType == "Then")
                {
                    scenario.CreateNode<Then>(stepName).Fail(scenarioContext.TestError.Message);
                }
            }
        }
    }
}