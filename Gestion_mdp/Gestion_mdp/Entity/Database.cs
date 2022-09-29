﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Gestion_mdp.Entity
{
    public class Database
    {
        private string hash;
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
