using Microsoft.Extensions.Configuration;

namespace SpecFlowWebUIAutomation.Utility
{
    public class ConfigHelper
    {
        public Dictionary<string, string> EnvironmentVariables = new Dictionary<string, string>();

        public IConfiguration Configuration { get; set; }


        public ConfigHelper(string pageName)
        {
            Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            Configuration.GetSection(pageName).Bind(EnvironmentVariables);
        }
    }
}
