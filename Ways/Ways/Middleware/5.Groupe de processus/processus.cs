using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ways.Client.Composant_de_travail;
using Ways.Middleware._6.Metier.Controleur_workflow;
using Ways.Middleware.Metier.Composant_technique;
using Ways.Middleware.Metier.Mappage;

namespace Ways.Middleware.Groupe_de_processus
{
    class processus
    {
        //Décris une suit de processus redondants appartenant au technique, controleur ou mappage

        public static bool verifSurnom(string name)
        {
            if (name == null)
            {
                //display ErrorMessageSurnomNull
                return false;
            }
            else if (name.Length > 20)
            {
                //display ErrorMessageSurnomLong
                return false;
            }
            else
            {
                return true;
            }

        }

        public static bool verifSurnomDoublons(string name)
        {
            if (name == null)
            {
                //display ErrorMessageSurnomNull
                return false;
            }
            else if (name.Length > 20)
            {
                //display ErrorMessageSurnomLong
                return false;
            }
            else if (isThatNameAlreadyUse(name))
            {
                //display ErrorMessageSurnomAlreadyUse
                return false;
            }
            else
            {
                return true;
            }

        }

        public static bool isThatNameAlreadyUse(string name)
        {
            string[] allNames = Requetes.getAllNames();

            foreach (string varName in allNames)
            {
                if (name == varName)
                {
                    return false;
                }
            }

            return false;
        }

        public static void saveEmailConfig(string URL, string port, string compte, string mdp)
        {
            technique.saveEmailConfig(URL, port, compte, mdp);
        }

        public static bool verifLogin(string identifiant, string psw)
        {
            return controleur.verifLogin(identifiant, psw);
        }

    }
}
