using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ways.Client.Composant_utilisateur_de_communication;
using Ways.Middleware.Metier.Mappage;

namespace Ways.Middleware._6.Metier.Controleur_workflow
{
    class controleur
    {
        //contrôle l'accès et la vérification des différentes parties
        //différent du technique car pas ou peu de calculs


        public static bool verifSurnom(string name)
        {
            if (name == "")
            {
                MessageBox.Show("Entrez un surnom!");
                return false;
            }
            else if (name.Length > 20)
            {
                MessageBox.Show("Entrez un surnom de moins de 20 caractères!");
                return false;
            }
            else
            {
                return true;
            }

        }

        public static bool verifSurnomDoublons(string name)
        {
            if (name == "")
            {
                MessageBox.Show("Entrez un surnom!");
                return false;
            }
            else if (name.Length > 20)
            {
                MessageBox.Show("Entrez un surnom de moins de 20 caractères!");
                return false;
            }
            else if (isThatNameAlreadyUse(name))
            {
                MessageBox.Show("Surnom déjà utilisé, entrez un nouveau surnom!");
                return false;
            }
            else
            {
                return true;
            }


        }

        public static bool isThatNameAlreadyUse(string name)
        {
            BindingList<User> allUser = Mappage.getClassement().users;

            if (allUser != null)
            {
                foreach (User user in allUser)
                {
                    if (name == user.Nom)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

    }
}
