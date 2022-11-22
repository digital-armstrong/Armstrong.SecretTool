using ArmstrongSecretTools.Utilits;
using Microsoft.Extensions.Configuration;

namespace ArmstrongSecretTools.Models
{
    public class SecretConfig
    {
        public string? Host { get; set; }
        public string? Database { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}