using Gestion_mdp.Entity;
using System;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
namespace Gestion_mdp.Helper
{
    public static class Confighelp
    {
        private static readonly string configDirPath = Path.Combine(
             Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Gestionmdp");

        private static readonly string configFileName = "Gestionmdp.config.json";
        private static readonly string configFilePath = Path.Combine(configDirPath, configFileName);

        public static void SaveConfig(Configuration configuration)
        {
            var json = JsonSerializer.Serialize(configuration, new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
            });

            if (!Directory.Exists(configDirPath))
                Directory.CreateDirectory(configDirPath);

            File.WriteAllText(configFilePath, json);
        }

        public static Configuration LoadConfiguration()
        {
            Configuration configuration = new();

            if (!Directory.Exists(configDirPath))
            {
                Directory.CreateDirectory(configDirPath);

                SaveConfig(configuration);

                return configuration;
            }

            var json = File.ReadAllText(configFilePath);

            return JsonSerializer.Deserialize<Configuration>(json);
        }

    }
}
