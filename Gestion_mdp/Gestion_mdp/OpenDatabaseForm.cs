using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_mdp.Entity;
using Gestion_mdp.Helper;

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
                MessageBox.Show("Le mot de passe est invalide ! ","GestionMdp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                DialogResult = DialogResult.None;
            }
        }

        private void Btncancel_Click(object sender, EventArgs e)
        {

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
