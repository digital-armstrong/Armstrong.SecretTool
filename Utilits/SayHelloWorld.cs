using ArmstrongSecretTools.Models;
using Microsoft.Extensions.Configuration;

namespace ArmstrongSecretTools.Helpers
{
  public static class SayHelloWorld
  {
    public static void Say()
    {
      System.Console.WriteLine(Constants.TextConstants.Licence);
    }
  }
}