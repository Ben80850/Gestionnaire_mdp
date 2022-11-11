using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_mdp.Entity
{
    public class Entree: ICloneable
    {
        private string uuid;
        [Browsable(false)]
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
        [DisplayName("Mot de passe")]
        public string MDP
        {
            get => mdp;
            set => mdp = value;
        }


        private DateTime createdAt;
        [DisplayName("Créer le ")]
        public DateTime CreatedAt
        {
            get => createdAt;
            set => createdAt = value;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
