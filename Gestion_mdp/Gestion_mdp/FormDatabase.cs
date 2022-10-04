using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_mdp.Helper;


namespace Gestion_mdp
{
    public partial class NewDatabase : Form
    {
        public NewDatabase()
        {
            InitializeComponent();
        }

        private void Créerunmotdepassemaitre_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Accept(object sender, EventArgs e)
        {
            if(!textBox1.Text.Equals(textBox2.Text))
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
