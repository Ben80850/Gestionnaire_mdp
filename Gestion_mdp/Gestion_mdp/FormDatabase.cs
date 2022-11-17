using Gestion_mdp.Helper;
using System;
using System.Windows.Forms;


namespace Gestion_mdp
{
    public partial class NewDatabase : Form
    {
        public NewDatabase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Accept(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(textBox2.Text))
            {
                MessageBox.Show("Les mot de passe ne correspondent pas !", "Gestion-mdp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;

            }
            else
            {
                ((Form1)Owner).Database.Hash = sécurité.GetHash(textBox1.Text);
            }
        }

        private void TogglePassword(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = !textBox1.UseSystemPasswordChar;
            textBox2.UseSystemPasswordChar = !textBox2.UseSystemPasswordChar;
        }
    }
}
