using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ways.Client.Composant_de_travail;
using Ways.Client.Composant_utilisateur_de_communication;
using Ways.Middleware._6.Metier.Controleur_workflow;
using Ways.Middleware.Groupe_de_processus;
using Ways.Middleware.Metier.Composant_technique;
using Ways.Middleware.Metier.Mappage;

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



        public static void showClassement(List<Reponse> reps)
        {
            processus.showClassement(reps);
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





        //Section Mappage
        public static void addQuestion(int IDQuestion, string enonce, string reponse1Enonce, string reponse1Points, string reponse2Enonce, string reponse2Points, string reponse3Enonce, string reponse3Points, string reponse4Enonce, string reponse4Points)
        {
            Mappage.addQuestion(IDQuestion, enonce, reponse1Enonce, reponse1Points, reponse2Enonce, reponse2Points, reponse3Enonce, reponse3Points, reponse4Enonce, reponse4Points);
        }

        public static void modifQuestion(int IDQuestion, string enonce, string reponse1Enonce, string reponse1Points, string reponse2Enonce, string reponse2Points, string reponse3Enonce, string reponse3Points, string reponse4Enonce, string reponse4Points)
        {
            Mappage.modifQuestion(IDQuestion, enonce, reponse1Enonce, reponse1Points, reponse2Enonce, reponse2Points, reponse3Enonce, reponse3Points, reponse4Enonce, reponse4Points);
        }

        public static void supprQuestion(int IDQuestion, string enonce, string reponse1Enonce, string reponse1Points, string reponse2Enonce, string reponse2Points, string reponse3Enonce, string reponse3Points, string reponse4Enonce, string reponse4Points)
        {
            Mappage.supprQuestion(IDQuestion, enonce, reponse1Enonce, reponse1Points, reponse2Enonce, reponse2Points, reponse3Enonce, reponse3Points, reponse4Enonce, reponse4Points);
        }







        //Vers la couche client

        public static void showAidezNous()
        {
            TravailClient.showAidezNousForm();
        }

        public static void showEmailForm()
        {
            TravailClient.showEmailForm();
        }

        public static void showClassementForm()
        {

        }
    }
}
