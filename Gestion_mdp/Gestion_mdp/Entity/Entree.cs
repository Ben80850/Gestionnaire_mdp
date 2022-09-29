using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_mdp.Entity
{
    public class Entree
    {
        private string uuid;
        public string UUID
        {
            get => uuid;
            set => uuid = value;

        }

        private string titre;
        public string Titre
        {
            get => titre;
            set => titre = value;

        }


        private string utilisateur;

        public string Utilisateur
        {
            get => utilisateur;
            set => utilisateur = value;
        }

        private string mdp;

        public string MDP
        {
            get => mdp;
            set => mdp = value;
        }


        private DateTime createdAt;

        public DateTime CreatedAt
        {
            get => createdAt;
            set => createdAt = value;
        }

    }
}
