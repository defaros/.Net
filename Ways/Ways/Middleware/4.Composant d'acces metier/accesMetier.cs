using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
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
        //Fait la liaison entre la couche métier et la couche client
        //Decide si la demande doit être traitée dans le processus, le controleur, le composant technique ou dans le mappage


        //Section Processus
        


        public static void finDeLaPartie(List<Reponse> reponsesDonnees, User currentUser)
        {
            processus.finDeLaPartie(reponsesDonnees, currentUser);
        }

        public static void finDuQuizz(List<Reponse> reponsesDonnees, User currentUser)
        {
            processus.finDuQuizz(reponsesDonnees, currentUser);
        }

        public static void addQuestion(string enonce, string type, string reponse1Enonce, string reponse1Points, string reponse2Enonce, string reponse2Points, string reponse3Enonce, string reponse3Points, string reponse4Enonce, string reponse4Points)
        {
            processus.addQuestion(enonce, type, reponse1Enonce, reponse1Points, reponse2Enonce, reponse2Points, reponse3Enonce, reponse3Points, reponse4Enonce, reponse4Points);
        }

        public static void modifQuestion(int IDQuestion, string enonce, string reponse1Enonce, string reponse1Points, string reponse2Enonce, string reponse2Points, string reponse3Enonce, string reponse3Points, string reponse4Enonce, string reponse4Points)
        {
            processus.modifQuestion(IDQuestion, enonce, reponse1Enonce, reponse1Points, reponse2Enonce, reponse2Points, reponse3Enonce, reponse3Points, reponse4Enonce, reponse4Points);
        }

        public static void supprQuestion(int IDQuestion)
        {
            processus.supprQuestion(IDQuestion);
        }


        public static void showAdminForm()
        {
            processus.showAdminForm();
        }


        public static void sendEmail(string mailDestinataire, Filiere metier)
        {
            processus.sendEmail(mailDestinataire, metier);
        }

        public static void sendEmail(string mailDestinataire, string NomExpediteur, string PrenomExpediteur)
        {
            processus.sendEmail(mailDestinataire, NomExpediteur, PrenomExpediteur);
        }






        //Section Technique
        public static void saveEmailConfig(string URL, string port, string compte, string mdp)
        {
            technique.saveEmailConfig(URL, port, compte, mdp);
        }


        public static int calculScore(List<Reponse> reps)
        {
            return technique.calculScore(reps);
        }





        //Section Controleur
        public static bool verifSurnom(string name)
        {
            return controleur.verifSurnom(name);
        }

        public static bool verifSurnomDoublons(string name)
        {
            return controleur.verifSurnomDoublons(name);
        }





        //Section Mappage

        public static bool verifLogin(string identifiant, string psw)
        {
            return Mappage.verifLogin(identifiant, psw);
        }
        

        public static void storeScore(User user)
        {

        }

        public static Classement getClassement()
        {
            //return Mappage.getClassement();
            return null;
        }

        public static Question[] getAllQuestionsOfType(string type)
        {
            //return Mappage.getClassement();
            return null;
        }

        public static List<Ways.Client.Composant_utilisateur_de_communication.Filiere> getAllMetier()
        {
            //return Mappage.getAllMetier();
            return null;
        }







        //Vers la couche client

        public static Reponse showAidezNous()
        {
            return TravailClient.showAidezNousForm();
        }

        public static void showClassementForm(Classement classement, User curentUser)
        {
            TravailClient.showClassementForm(classement, curentUser);
        }

        public static void showMainForm()
        {
            TravailClient.showMainForm();
        }

        public static void showOrientationForm(Filiere f)
        {
            TravailClient.showOrientationForm(f);
        }
    }
}
