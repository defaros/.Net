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
    public partial class OrientationForm : Form
    {
        //Filière à afficher
        Filiere filiereToDisplay;

        public OrientationForm( Filiere f)
        {
            InitializeComponent();

            this.filiereToDisplay = f;

            labelMetierName.Text = f.name;
            richTextBoxDescriptionMetier.Text = f.description;
        }

        private void buttonSendMail_Click(object sender, EventArgs e)
        {
            TravailClient.sendEmail(textBoxEmail.Text, filiereToDisplay);
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
