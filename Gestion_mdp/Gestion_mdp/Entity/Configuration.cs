﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_mdp.Entity
{
    public class Configuration
    {
        private string lastUsedFile;
        public string LastUsedFile
        {
            get => lastUsedFile;
            set => lastUsedFile = value;
        }
    }
}
