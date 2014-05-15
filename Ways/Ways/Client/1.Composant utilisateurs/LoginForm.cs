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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            //vérification des données envoyées

            if (TravailClient.verifLogin(textBoxIdentifiant.Text, textBoxPsw.Text))
            {
                TravailClient.showAdminForm();
            }

        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
