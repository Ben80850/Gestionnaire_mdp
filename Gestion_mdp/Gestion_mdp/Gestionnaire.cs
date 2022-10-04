using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_mdp.Entity;
using Gestion_mdp.Helper;

namespace Gestion_mdp
{
    public partial class Form1 : Form
    {
        public Database Database;

        private Configuration configuration;

        public Form1()
        {
            InitializeComponent();
            Database = new Database();
            configuration = new Configuration();
        }

        private void copierleNomDutilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NewDatabase(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new();
            sfd.FileName = "Base de données.mpm ";
            sfd.Filter = "Fichier MPM de Gestion_mdp | *.mpm";

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                var dbFile = sfd.FileName;
                NewDatabase newDatabase = new();

                if (newDatabase.ShowDialog(this) == DialogResult.OK)
                {

                    Database.Entree = new BindingList<Entree>();
                    DtgEntries.DataSource = Database.Entree;
                    configuration.LastUsedFile = dbFile;

                    DatabaseHelper.Sauvegarde(dbFile, Database);

                    Text = $"Gestion_mdp - {Path.GetFileName(dbFile)}";
                }
            }
        }
    }
}
