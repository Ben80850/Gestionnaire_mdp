using Gestion_mdp.Entity;
using Gestion_mdp.Helper;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Gestion_mdp
{
    public partial class Form1 : Form
    {
        private const int DTG_PASSWORD_COLUMN_INDEX = 2;
        private const int NUMBER_OF_PASSWORD_CHAR = 8;

        public Database Database;

        private Configuration configuration;

        private Entree selectionEntree;

        public Form1()
        {
            InitializeComponent();

            Database = new();

            FormClosing += OnFormClosing;
            Load += OnFormLoad;

            Shown += OnFormShown;
        }
        #region Evenement Form

        private void OnFormShown(object sender, EventArgs e)
        {
            if (configuration.LastUsedFile is not null)
            {

                OpenDatabaseForm openDatabaseForm = new OpenDatabaseForm(configuration.LastUsedFile);

                if (openDatabaseForm.ShowDialog(this) == DialogResult.OK)
                {
                    DtgEntries.DataSource = Database.Entree;
                    Text = $"Gestion_mdp - {Path.GetFullPath(configuration.LastUsedFile)}";
                }
            }
        }

        private void OnFormLoad(object sneder, EventArgs e)
        {
            configuration = Confighelp.LoadConfiguration();

            if (!File.Exists(configuration.LastUsedFile))
            {
                configuration.LastUsedFile = null;
            }

        }
        #endregion

        #region TEST

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            Confighelp.SaveConfig(configuration);

            if (Database != null)
            {
                DatabaseHelper.Sauvegarde(configuration.LastUsedFile, Database);
            }
        }

        private void copierleNomDutilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Database
        private void NewDatabase(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new();
            sfd.FileName = "Base de données";
            sfd.Filter = "Fichier MPM de Gestion_mdp | *.mpm";

            if (sfd.ShowDialog() == DialogResult.OK)
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

        private void OpenDatabase(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                OpenDatabaseForm openDatabaseForm = new(ofd.FileName);

                if (ofd.ShowDialog(this) == DialogResult.OK)
                {
                    DtgEntries.DataSource = Database.Entree;
                    Text = $"Gestion_mdp - {Path.GetFileName(ofd.FileName)}";
                    configuration.LastUsedFile = ofd.FileName;
                }
            }
        }

        private void quitterMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseDatabase(object sender, EventArgs e)
        {
            Database = new();
            DtgEntries.DataSource = null;
            Text = "Gestion_mdp";
            configuration.LastUsedFile = null;
        }

        private void SauvegardeDatabase(object sender, EventArgs e)
        {
            DatabaseHelper.Sauvegarde(configuration.LastUsedFile, Database);
        }
        #endregion

        #region Menu


        private void AddEntree(object sender, EventArgs e)
        {
            EntreeForm entreeForm = new();

            if (entreeForm.ShowDialog(this) == DialogResult.OK)
            {
                Database.Entree.Add(entreeForm.Entree);
                DatabaseHelper.Sauvegarde(configuration.LastUsedFile, Database);
            }
        }
        private void MenuFileOpen(object sender, EventArgs e)
        {
            if (Database.Hash is not null)
                TogglerFileMenu(isEnabled: true);
            else
                TogglerFileMenu(isEnabled: false);
        }

        private void Menuentrée(object sender, EventArgs e)
        {
            if (Database.Hash is not null)
                ToggleEntryMenu(isEnabled: true);
            else
                ToggleEntryMenu(isEnabled: false);
        }

        #endregion

        #region Méthode
        private void TogglerFileMenu(bool isEnabled)
        {
            sauvegarderMenu.Enabled = isEnabled;
            fermerMenu.Enabled = isEnabled;
        }

        private void ToggleEntryMenu(bool isEnabled)
        {
            entréeMenu.Enabled = isEnabled;
            copierMenu.Enabled = isEnabled;
            copierMdpMenu.Enabled = isEnabled;
        }

        #endregion

        #region Copie

        private void CopierUtilisateur(object sender, EventArgs e)
        {
            SetSelectedEntree();

            if (selectionEntree != null)
            {
                Clipboard.SetText(selectionEntree.Utilisateur);
            }
        }

        private void Copiemdp(object sender, EventArgs e)
        {
            SetSelectedEntree();
            if (selectionEntree != null)
            {
                Clipboard.SetText(sécurité.Decrypt(selectionEntree.MDP, Database.Hash));
            }
        }
        #endregion


        #region Modification entrée

        private void DtgEntriesCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == DTG_PASSWORD_COLUMN_INDEX)
            {
                e.Value = new string('*', NUMBER_OF_PASSWORD_CHAR);
            }
        }

        private void ModifierEntrée(object sender, EventArgs e)
        {
            if (DtgEntries.SelectedRows.Count == 1)
            {
                SetSelectedEntree();

                EntreeForm entreeForm = new(selectionEntree);
                selectionEntree.MDP = sécurité.Decrypt(selectionEntree.MDP, Database.Hash);

                if (entreeForm.ShowDialog(this) == DialogResult.OK)
                {
                    DtgEntries.RefreshEdit();
                    selectionEntree.MDP = sécurité.Encrypt(selectionEntree.MDP, Database.Hash);
                    DatabaseHelper.Sauvegarde(configuration.LastUsedFile, Database);
                }
            }
        }
        private void SupprimerEntree(object sender, EventArgs e)
        {
            SetSelectedEntree();
            var result = MessageBox.Show($"Êtes-vous sur de vouloir supprimer l'entrée sélectionnée ?\n\n " + $"- {selectionEntree.Titre}", "Gestion_mdp",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Database.Entree.Remove(selectionEntree);
            }
        }

        private void SetSelectedEntree()
        {
            selectionEntree = (Entree)DtgEntries.CurrentRow.DataBoundItem;
        }
    }
    #endregion
}
