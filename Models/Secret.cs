using ArmstrongSecretTools.Utilits;
using Microsoft.Extensions.Configuration;

namespace ArmstrongSecretTools.Models
{
    public class Secret
    {
        public string? Host { get; set; }
        public string? Database { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }

        public Secret()
        {
            var config = SettingsHelper.GetConfiguration();
            var secretConfig = config.GetSection("Secrets").Get<SecretConfig>();

            Host = secretConfig.Host;
            Database = secretConfig.Database;
            Username = secretConfig.Username;
            Password = secretConfig.Password;
        }
    }
}