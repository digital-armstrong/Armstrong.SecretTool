using Armstrong.SecretTool.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Armstrong.SecretTool.Utilits
{
    public static class JsonParser
    {
        public static string FilePath => $"{AppContext.BaseDirectory}/appsettings.json";

        public static Object GetSecrets()
        {
            using (StreamReader reader = File.OpenText(FilePath))
            {
                JObject jsonObj = (JObject)JToken.ReadFrom(new JsonTextReader(reader));
                Secrets json = JsonConvert.DeserializeObject<Secrets>(jsonObj.ToString());

                return json;
            }
        }
    }
}
