using Gestion_mdp.Entity;
using Gestion_mdp.Helper;
using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace Gestion_mdp
{
    public partial class OpenDatabaseForm : Form
    {

        private string dbFile;

        public OpenDatabaseForm(string dbFile)
        {
            InitializeComponent();

            this.dbFile = dbFile;

            Text += $" - {Path.GetFileName(dbFile)}";
        }

        private void Accept(object sender, EventArgs e)
        {
            var hash = sécurité.GetHash(textBox1.Text);
            var file = sécurité.DecryptFile(hash, dbFile);

            if (!string.IsNullOrWhiteSpace(file))
            {
                var json = File.ReadAllText(file);
                File.Delete(file);

                ((Form1)Owner).Database = JsonSerializer.Deserialize<Database>(json);
                ((Form1)Owner).Database.Hash = hash;

            }
            else
            {
                MessageBox.Show("Le mot de passe est invalide ! ", "GestionMdp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                DialogResult = DialogResult.None;
            }
        }

        private void OpenDatabaseForm_Load(object sender, EventArgs e)
        {
            textBox1.Select();
        }

        private void TooglePasswordChar(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = !textBox1.UseSystemPasswordChar;
        }
    }
}
