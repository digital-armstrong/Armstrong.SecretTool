using Armstrong.SecretTool.Models;

namespace Armstrong.SecretTool.Utilits
{
    public enum SecretType { Client = 1, Server, Both }
    public static class EnvironmentHelper
    {
        public static void GetEnvironments(Secrets secrets, SecretType secretType)
        {
            switch (secretType)
            {
                case SecretType.Client:
                    Get(secrets.ClientSecrets);
                    break;
                case SecretType.Server:
                    Get(secrets.ServerSecrets);
                    break;
                case SecretType.Both:
                    Get(secrets.ClientSecrets);
                    Get(secrets.ServerSecrets);
                    break;
            }
        }

        public static void SetEnvironments(Secrets secrets, SecretType secretType)
        {
            switch (secretType)
            {
                case SecretType.Client:
                    Set(secrets.ClientSecrets);
                    break;
                case SecretType.Server:
                    Set(secrets.ServerSecrets);
                    break;
                case SecretType.Both:
                    Set(secrets.ClientSecrets);
                    Set(secrets.ServerSecrets);
                    break;
            }
        }

        private static void Set(Dictionary<string, string> secrets)
        {
            foreach (var secret in secrets)
            {
                Environment.SetEnvironmentVariable(secret.Key,
                                                   secret.Value,
                                                   EnvironmentVariableTarget.User);
            }
        }

        private static void Get(Dictionary<string, string> secrets)
        {
            foreach (var secret in secrets)
            {
                var environmentValue = Environment.GetEnvironmentVariable(secret.Key,
                                                                          EnvironmentVariableTarget.User);
                Console.WriteLine($"Key:\t{secret.Key}\nValue:\t{environmentValue}\n\n");
            }
        }
    }
}