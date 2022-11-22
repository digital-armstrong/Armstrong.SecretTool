using ArmstrongSecretTools.Models;

namespace ArmstrongSecretTools.Utilits
{
    public static class EnvironmentHelper
    {
        public static string HostEnvName => "CLIENT_HOST";
        public static string DatabaseEnvName => "CLIENT_DATABASE";
        public static string UsernameEnvName => "CLIENT_USERNAME";
        public static string PswdEnvName => "CLIENT_PSWD";

        public static void SetEnvironments(Secret secret)
        {
            Environment.SetEnvironmentVariable(HostEnvName, secret.Host, EnvironmentVariableTarget.User);
            Environment.SetEnvironmentVariable(DatabaseEnvName, secret.Database, EnvironmentVariableTarget.User);
            Environment.SetEnvironmentVariable(UsernameEnvName, secret.Username, EnvironmentVariableTarget.User);
            Environment.SetEnvironmentVariable(PswdEnvName, secret.Password, EnvironmentVariableTarget.User);
        }

        public static void GetEnvironments()
        {
            var host = Environment.GetEnvironmentVariable(HostEnvName, EnvironmentVariableTarget.User);
            var database = Environment.GetEnvironmentVariable(DatabaseEnvName, EnvironmentVariableTarget.User);
            var user = Environment.GetEnvironmentVariable(UsernameEnvName, EnvironmentVariableTarget.User);
            var pswd = Environment.GetEnvironmentVariable(PswdEnvName, EnvironmentVariableTarget.User);

            System.Console.WriteLine($"{HostEnvName}:\t\t{host}\n"
                                     + $"{DatabaseEnvName}:\t{database}\n"
                                     + $"{UsernameEnvName}:\t{user}\n"
                                     + $"{PswdEnvName}:\t\t{pswd}\n");
        }
    }
}