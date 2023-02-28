using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using NUnit.Framework;
using AventStack.ExtentReports.Reporter.Configuration;

namespace SpecFlowWebUIAutomation.Utility
{
    public class ExtentReport
    { 
        public static ExtentReports extent;
        public static ExtentTest feature;
        public static ExtentTest scenario;
        public static String directory = AppDomain.CurrentDomain.BaseDirectory;
        public static String resultPath = directory.Replace("bin\\Debug\\net6.0", "TestResults");

    public static void ExtentReportInit()
    {
            var htmlReporter = new ExtentHtmlReporter(resultPath);
            htmlReporter.Config.ReportName = "Test Report";
            htmlReporter.Config.DocumentTitle = "Test Report";
            htmlReporter.Config.Theme = Theme.Dark;
            htmlReporter.Start();
            extent =new ExtentReports();
            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Application", "Demoqa");
            extent.AddSystemInfo("Browser", "Chrome");
            extent.AddSystemInfo("OS", "Windows");

        }

    [OneTimeTearDown]
    public static void ExtentReportTearDown()
    {
            extent.Flush();
    }
}
}
