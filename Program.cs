using ArmstrongSecretTools.Helpers;
using ArmstrongSecretTools.Models;
using ArmstrongSecretTools.Utilits;

namespace ArmstrongSecretTools
{
    public static class Propgram
    {
        public static void Main(string[] args)
        {
            JsonParser.GetSecrets();
            SayHelloWorld.Say();

            Console.ReadLine();

            int input;

            Console.WriteLine(Constants.TextConstants.ActionChoice);
            Console.Write(Constants.TextConstants.PromptToInput);

            while (!(int.TryParse(Console.ReadLine(), out input) && (input > 0 && input < 4)))
            {
                Console.Write(Constants.TextConstants.WrongInput);
            }

            Secrets secrets = JsonParser.GetSecrets() as Secrets;

            EnvironmentHelper.SetEnvironments(secrets: secrets, (SecretType)input);

            Console.WriteLine("Done!");

            Console.ReadLine();
        }
    }
}