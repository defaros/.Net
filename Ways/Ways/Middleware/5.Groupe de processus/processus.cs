using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ways.Client.Composant_de_travail;
using Ways.Client.Composant_utilisateur_de_communication;
using Ways.Middleware._6.Metier.Controleur_workflow;
using Ways.Middleware.Composant_d_acces_metier;
using Ways.Middleware.Metier.Composant_technique;
using Ways.Middleware.Metier.Mappage;
using System.Data.SqlClient;

namespace Ways.Middleware.Groupe_de_processus
{
    class processus
    {
        //Décris une suite de processus appartenants au technique, controleur ou mappage

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
            string[] allNames = Mappage.getAllNames();

            foreach (string varName in allNames)
            {
                if (name == varName)
                {
                    return false;
                }
            }

            return false;
        }


        public static void finDeLaPartie(List<Reponse> reponsesDonnees, User currentUser)
        {
            Reponse repAidez = accesMetier.showAidezNous();
            if (repAidez.points == -1)
            {
                accesMetier.showMainForm();
            }

            reponsesDonnees.Add(repAidez);


            currentUser.Score = technique.calculScore(reponsesDonnees);

            //enregistrer en BDD 
            accesMetier.storeScore(currentUser);

            //calculer classement
            Classement classement = accesMetier.getClassement();

            accesMetier.showClassementForm(classement, currentUser);
        }

        public static void finDuQuizz(List<Reponse> reponsesDonnees, User currentUser)
        {
            currentUser.Score = technique.calculScore(reponsesDonnees);

            //prendre tous les metiers de la BDD 
            List<Filiere> listFiliere= accesMetier.getAllMetier();

            //calculer metier
            Filiere filiereToDisplay = null;
            foreach (Filiere f in listFiliere)
            {
                //A voir comment le calcul s'effectue
            }

            accesMetier.showOrientationForm(filiereToDisplay);
        }


        /**********************************************Technique***************************************************/

        public static void sendEmail(string mailDestinataire, string NomExpediteur, string PrenomExpediteur)
        {
            string[] emailConfig = new string[4];
            //emailConfig = getEmailConfig
            
            
            DateTime dateNow = DateTime.Today;

            string emailSubject = "Invitation evenement eXia du " + dateNow.ToString(" dd MMMM yyyy");

            string emailBody = PrenomExpediteur + " " + NomExpediteur + " vous invite à participer à l’évènement eXia du " + dateNow.ToString(" dd MMMM yyyy");

            technique.sendEmail(emailConfig[0], emailConfig[1], emailConfig[2], emailConfig[3], mailDestinataire, emailSubject, emailBody);


        }

        public static void sendEmail(string mailDestinataire, Filiere metier)
        {
            string[] emailConfig = new string[4];
            //emailConfig = getEmailConfig


            DateTime dateNow = DateTime.Today;

            string emailSubject = "Evenement eXia du " + dateNow.ToString(" dd MMMM yyyy") + ": Votre bilan personnel";

            string emailBody = "Lors l’évènement eXia du " + dateNow.ToString(" dd MMMM yyyy") +", vous avez participé à notre programme de découverte des métiers de l'informatique, voici votre bilan personnalisé:\n\n"+
                               "Votre filière : " + metier.name +"\n\n" +
                                "Description de la filière :\n" + metier.description;

            technique.sendEmail(emailConfig[0], emailConfig[1], emailConfig[2], emailConfig[3], mailDestinataire, emailSubject, emailBody);

        }







        /**********************************************Mappage***************************************************/
        public static void addQuestion(string enonce, string reponse1Enonce, string reponse1Points, string reponse2Enonce, string reponse2Points, string reponse3Enonce, string reponse3Points, string reponse4Enonce, string reponse4Points)
        {
            Mappage.addQuestion(enonce);
            int ID = Mappage.getIDQuestionbyEnonce(enonce);
            Mappage.addReponse(ID, reponse1Enonce, Convert.ToInt32(reponse1Points));
            Mappage.addReponse(ID, reponse2Enonce, Convert.ToInt32(reponse2Points));
            Mappage.addReponse(ID, reponse3Enonce, Convert.ToInt32(reponse3Points));
            Mappage.addReponse(ID, reponse4Enonce, Convert.ToInt32(reponse4Points));



        }

        public static void modifQuestion(int IDQuestion, string enonce, string reponse1Enonce, string reponse1Points, string reponse2Enonce, string reponse2Points, string reponse3Enonce, string reponse3Points, string reponse4Enonce, string reponse4Points)
        {
            Mappage.modifQuestion(IDQuestion, enonce);
            Mappage.modifReponse(IDQuestion, reponse1Enonce, Convert.ToInt32(reponse1Points));
            Mappage.modifReponse(IDQuestion, reponse2Enonce, Convert.ToInt32(reponse2Points));
            Mappage.modifReponse(IDQuestion, reponse3Enonce, Convert.ToInt32(reponse3Points));
            Mappage.modifReponse(IDQuestion, reponse4Enonce, Convert.ToInt32(reponse4Points));
        }

        public static void supprQuestion(int IDQuestion)
        {
            List<int> ids = Mappage.getIDsReponseByIdQuestion(IDQuestion);
            foreach (int id in ids)
            {
                Mappage.supprReponse(id);
            }
            Mappage.supprQuestion(IDQuestion);
        }

    }
}
