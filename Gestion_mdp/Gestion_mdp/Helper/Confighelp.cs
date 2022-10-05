using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace Gestion_mdp.Helper
{
    public static class Confighelp
    {
        private static readonly string configDirPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Gestion_mdp");

        private static readonly string configFileName = "Gestion_mdp.json";
        private static readonly string configFilePath = Path.Combine(configDirPath, configFileName);

        public static void Saveconfig(Configuration configuration)
        {
            var json = JsonSerializer.Serialize(configuration, new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(UnicodeRanges.All)
            });

            if (!Directory.Exists(configDirPath))
                Directory.CreateDirectory(configDirPath);

            File.WriteAllText(configDirPath, json);

        }
    }
}
