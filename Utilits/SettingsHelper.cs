using Microsoft.Extensions.Configuration;

namespace ArmstrongSecretTools.Utilits
{
  public static class SettingsHelper
  {
    public static IConfigurationRoot? GetConfiguration()
    {
      var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", false);
      var configuration = builder.Build();

      return configuration;
    }
  }
}