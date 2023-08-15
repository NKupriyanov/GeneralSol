using Microsoft.Extensions.Configuration;

namespace Core.Configuration
{
    public class AppConfiguration
    {
        private readonly static IConfigurationRoot configurationRoot = GetConfigurationRoot();
        public static BrowserConfiguration Browser { get; set; } = BindConfiguration<BrowserConfiguration>();

        private static T BindConfiguration<T>() where T : IConfiguration, new()
        {
            var config = new T();
            configurationRoot.GetSection(config.SectionName).Bind(config);
            return config;
        }

        private static IConfigurationRoot GetConfigurationRoot()
        {
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();
        }
    }
}
