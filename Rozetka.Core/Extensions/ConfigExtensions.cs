using Microsoft.Extensions.Configuration;
using System;

namespace Rozetka.Core.Extensions
{
    public static class ConfigExtensions
    {
        private static IConfiguration _configuration;

        private static IConfiguration Configuration =>
            _configuration ??= new ConfigurationBuilder().AddJsonFile("appsettings.json", true, true).Build();

        public static T GetValue<T>(string configSection, string keyName)
        {
            return (T)Convert.ChangeType(Configuration[$"{configSection}:{keyName}"], typeof(T));
        }

        public static string GetAppSettings(string keyName)
        {
            return GetValue<string>("AppSettings", keyName);
        }
    }
}
