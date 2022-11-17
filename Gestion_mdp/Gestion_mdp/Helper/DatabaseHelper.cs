using Gestion_mdp.Entity;
using System;
using System.IO;
using System.Text.Json;


namespace Gestion_mdp.Helper
{
    public class DatabaseHelper
    {
        public static void Sauvegarde(string path, Database database)
        {
            var filename = Guid.NewGuid().ToString() + ".tmp";
            var TempFile = Path.Combine(Path.GetTempPath(), filename);

            File.WriteAllText(TempFile, JsonSerializer.Serialize(database));

            sécurité.EncryptFile(database.Hash, TempFile, path);

            File.Delete(TempFile);
        }
    }
}
