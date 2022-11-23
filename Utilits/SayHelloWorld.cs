using Armstrong.SecretTool.Models;
using Microsoft.Extensions.Configuration;

namespace Armstrong.SecretTool.Helpers
{
  public static class SayHelloWorld
  {
    public static void Say()
    {
      System.Console.WriteLine(Constants.TextConstants.Licence);
    }
  }
}