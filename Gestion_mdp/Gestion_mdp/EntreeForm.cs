using Gestion_mdp.Entity;
using Gestion_mdp.Helper;
using System;
using System.Windows.Forms;

namespace Gestion_mdp
{
    public partial class EntreeForm : Form
    {
        public Entree Entree;
        private Entree initentree;

        public EntreeForm(Entree entree = null)
        {
            InitializeComponent();

            if (entree != null)
            {

                Entree = entree;
            }
        }

        private void Btncancel_Click(object sender, EventArgs e)
        {

        }

        private void Accept(object sender, EventArgs e)
        {
            if (textBox3.Text.Equals(textBox4.Text))
            {
                Entree = new()
                {
                    UUID = Guid.NewGuid().ToString().ToUpper(),
                    Titre = textBox1.Text,
                    Utilisateur = textBox2.Text,
                    MDP = sécurité.Encrypt(textBox3.Text, ((Form1)Owner).Database.Hash),
                    CreatedAt = DateTime.Now
                };
            }
            else
            {
                MessageBox.Show("Les mot de passe ne correspondent pas !", "Gestionmdp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
            }
        }

        private void ToogleBtnChar(object sender, EventArgs e)
        {
            textBox3.UseSystemPasswordChar = !textBox3.UseSystemPasswordChar;
            textBox4.UseSystemPasswordChar = !textBox4.UseSystemPasswordChar;
        }

        private void EntreeForm_Load(object sender, EventArgs e)
        {
            textBox1.Select();

            if (Entree != null)
            {
                initentree = (Entree)Entree.Clone();
                textBox1.DataBindings.Add("Text", Entree, "Titre");
                textBox2.DataBindings.Add("Text", Entree, "Utilisateur");
                textBox3.DataBindings.Add("Text", Entree, "MDP");
                textBox4.Text = textBox3.Text;

            }
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.Cancel)
            {
                Entree.Titre = initentree.Titre;
                Entree.Utilisateur = initentree.Utilisateur;
                Entree.MDP = initentree.MDP;
            }
        }
    }
}
