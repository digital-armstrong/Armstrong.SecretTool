using Armstrong.SecretTool.Models;

namespace Armstrong.SecretTool.Utilits
{
    public enum SecretType { Client = 1, Server, Both }
    public static class EnvironmentHelper
    {
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
    }
}