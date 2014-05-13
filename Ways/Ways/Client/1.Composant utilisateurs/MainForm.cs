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
                TravailClient.lancerOrientation();
            }
        }

        private void buttonJeu_Click(object sender, EventArgs e)
        {

            //vérification que le surnom est valide (avec gestion dans la BDD
            if (TravailClient.verifSurnomDoublons(textBoxName.Text))
            {
                TravailClient.lancerJeu();
            }
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            //Fenêtre Login
        }

        
    }
}
