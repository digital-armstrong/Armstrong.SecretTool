using ArmstrongSecretTools.Helpers;
using ArmstrongSecretTools.Models;
using ArmstrongSecretTools.Utilits;

namespace ArmstrongSecretTools
{
    public static class Propgram
    {
        public static void Main(string[] args)
        {
            SayHelloWorld.Say();

            System.Console.ReadLine();

            Secret secret = new();

            EnvironmentHelper.SetEnvironments(secret: secret);
            EnvironmentHelper.GetEnvironments();

            System.Console.WriteLine("Done!");
            System.Console.ReadLine();
        }
    }
}