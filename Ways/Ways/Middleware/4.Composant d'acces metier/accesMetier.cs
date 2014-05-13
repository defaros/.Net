using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ways.Middleware._6.Metier.Controleur_workflow;
using Ways.Middleware.Groupe_de_processus;
using Ways.Middleware.Metier.Composant_technique;

namespace Ways.Middleware.Composant_d_acces_metier
{
    class accesMetier
    {
        //Fait la liason entre la couche métier et la couche client
        //Decide si la demande doit être traitée dans le processus, le controleur, le composant technique ou dans le mappage


        //Section Processus
        public static bool verifSurnom(string name)
        {
            return processus.verifSurnom(name);
        }

        public static bool verifSurnomDoublons(string name)
        {
            return processus.verifSurnomDoublons(name);
        }








        //Section Technique
        public static void saveEmailConfig(string URL, string port, string compte, string mdp)
        {
            technique.saveEmailConfig(URL, port, compte, mdp);
        }

        




        //Section Controleur
        public static bool verifLogin(string identifiant, string psw)
        {
            return controleur.verifLogin(identifiant, psw);
        }
    }
}
