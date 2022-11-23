namespace Armstrong.SecretTool.Models
{
    public class Secrets
    {
        public Dictionary<string, string> ClientSecrets { get; set; }
        public Dictionary<string, string> ServerSecrets { get; set; }
    }
}