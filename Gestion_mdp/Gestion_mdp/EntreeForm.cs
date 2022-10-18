using Gestion_mdp.Entity;
using Gestion_mdp.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_mdp
{
    public partial class EntreeForm : Form
    {
        public Entree Entree;
    
        public EntreeForm(Entree entree = null)
        {
            InitializeComponent();

            if(entree != null)
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EntreeForm_Load(object sender, EventArgs e)
        {
            textBox1.Select();
        }
    }
}
