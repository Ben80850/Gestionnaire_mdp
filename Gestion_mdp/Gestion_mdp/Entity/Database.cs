using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Gestion_mdp.Entity
{
    public class Database
    {
        private string hash;

        [JsonIgnore]
        public string Hash
        {
            get => hash;
            set => hash = value;
        }
        private BindingList<Entree> entree;

        public BindingList<Entree> Entree
        {
            get => entree;
            set => entree = value;
        }

        public Database()
        {
            entree = new BindingList<Entree>();
        }


    }
}
