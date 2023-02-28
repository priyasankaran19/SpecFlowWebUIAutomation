# Specflow Web UI Automation
This is a sample project to demonstrate how to use Specflow to automate web UI testing.

 ## Prerequisites
- Visual Studio 2022
- .NET 7.0
- Specflow 3.9.22
- Selenium.WebDriver 4.0.0
- Selenium.WebDriver.ChromeDriver 103.0
- Selenium.Support 4.0.0

## How to run

1. Clone the repository
2. Open the solution in Visual Studio
3. Build the solution
4. Run the tests


## How to add new tests

1. Create a new feature file in the Features folder
2. Add a new class in the StepDefinitions folder
3. Add a new class in the PageObjects folder

### Reading Page Objects
All the page objects are from appsettings.json file. You can add new page objects in the file.

### Reading Configuration
All the configuration are from appsettings.json file. You can add new configuration in the file.

```
string config = ConfigurationManager.AppSettings["key"];
```

