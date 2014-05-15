using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ways.Client.Composant_de_travail;
using Ways.Client.Composant_utilisateur_de_communication;

namespace Ways.Client.Composant_utilisateurs
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonOrien_Click(object sender, EventArgs e)
        {
            //vérification que le surnom est valide
            if (TravailClient.verifSurnom(textBoxName.Text))
            {
                TravailClient.lancerOrientation(new User(textBoxName.Text));
            }
        }

        private void buttonJeu_Click(object sender, EventArgs e)
        {

            //vérification que le surnom est valide (avec gestion dans la BDD
            if (TravailClient.verifSurnomDoublons(textBoxName.Text))
            {
                TravailClient.lancerJeu(new User(textBoxName.Text));
            }
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            //Fenêtre Login
            LoginForm logForm = new LoginForm();
            logForm.ShowDialog();
        }



        private void buttonClassement_Click(object sender, EventArgs e)
        {
            TravailClient.finDeLaPartie(null, null);
        }





















        private void labelHello_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}
