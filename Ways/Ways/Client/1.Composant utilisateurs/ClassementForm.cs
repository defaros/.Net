using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ways.Client.Composant_utilisateur_de_communication;

namespace Ways.Client.Composant_utilisateurs
{
    public partial class ClassementForm : Form
    {
        public ClassementForm(Classement classement, User curentUser)
        {
            InitializeComponent();

            //displayClassement(classement);

            //displayUserScore(curentUser);
        }

        public void displayClassement(Classement classement)
        {
            //Display un classement
        }

        public void displayUserScore(User curentUser)
        {
            //Display le score d'un User
        }

    }
}
