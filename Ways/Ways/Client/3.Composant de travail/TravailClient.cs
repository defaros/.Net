using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ways.Client._1.Composant_utilisateurs;
using Ways.Client.Composant_utilisateur_de_communication;
using Ways.Client.Composant_utilisateurs;
using Ways.Middleware.Composant_d_acces_metier;
using System.Data.SqlClient;
using Ways.Middleware.Metier.Mappage;

namespace Ways.Client.Composant_de_travail
{
    class TravailClient
    {
        //Exécute les processus liés à l'affichage utilisateur (affichage d'une fenêtre, remplissage d'une liste...), ne nécéssitant pas ou peu de calculs
        //Fait également la liason avec la couche métier

        


        /*********************************MainForm**************************************************/

        public static void showMainForm()
        {
            MainForm main = new MainForm();
            main.Show();
        }


        //Lance l'interface Administrateur
        public static void lancerAdmin()
        {
            LoginForm logForm = new LoginForm();
            logForm.ShowDialog();
        }


        public static bool verifSurnom(string name)
        {
            return accesMetier.verifSurnom(name);
        }

        public static bool verifSurnomDoublons(string name)
        {
            return accesMetier.verifSurnomDoublons(name);
        }


        /***************************LoginForm******************************/

        //Verifie les informations Administrateurs
        public static bool verifLogin(string identifiant, string psw)
        {
            return accesMetier.verifLogin(identifiant, psw);
        }





        /***************************GameForm******************************/



        public static int calculScore(List<Reponse> reps)
        {
            return accesMetier.calculScore(reps);
        }

        public static Classement setNewClassement(User newScore)
        {
            return new Classement(null);
        }

        //Lance une GameForm en mode orientation
        public static void lancerOrientation(User currentUser)
        {
            //Type 0 = Orientation
            string type = "Orientation";
            Question[] questions = accesMetier.getAllQuestionsOfType(type);
            foreach (Question quest in questions)
            {
                quest.reponses = Mappage.getReponseByIdQuestion(quest.ID);
            }
            GameForm GF = new GameForm(currentUser, questions, type);
            GF.ShowDialog();

        }


        //Lance une GameForm en mode jeu
        public static void lancerJeu(User currentUser)
        {
            //Type 1 = Jeu
            string type = "Jeu";
            Question[] questions = accesMetier.getAllQuestionsOfType(type);
            foreach (Question quest in questions)
            {
                quest.reponses = Mappage.getReponseByIdQuestion(quest.ID);
            }
            GameForm GF = new GameForm(currentUser, questions, type);
            GF.ShowDialog();
        }

        

        

        

        public static void finDeLaPartie(List<Reponse> reponsesDonnees, User currentUser)
        {
            accesMetier.finDeLaPartie(reponsesDonnees, currentUser);
        }

        public static void finDuQuizz(List<Reponse> reponsesDonnees, User currentUser)
        {
            accesMetier.finDuQuizz(reponsesDonnees, currentUser);
        }



        /********************************************************AidezNousForm******************************************************/

        public static Reponse showAidezNousForm()
        {
            AidezNousForm AideForm = new AidezNousForm();
            AideForm.ShowDialog();

            return AideForm.reponse;
        }


        /********************************************************ClassementForm******************************************************/

        public static void showClassementForm(Classement classement, User currentUser)
        {
            ClassementForm CLForm = new ClassementForm(classement, currentUser);
            CLForm.ShowDialog();
        }



        /**********************************************************OrientationForm*****************************************************/

        public static void showOrientationForm(Filiere f)
        {
            OrientationForm orientForm = new OrientationForm(f);
            orientForm.ShowDialog();
        }



        /**********************************************************AdminForm*****************************************************/

        public static void showAdminForm()
        {
            accesMetier.showAdminForm();
        }

        public static void showAdminForm(List<Question> listQuestJeu, List<Question> listQuestOrientation, string[] paramEmail)
        {
            AdminForm adForm = new AdminForm(listQuestJeu, listQuestOrientation, paramEmail);
            adForm.ShowDialog();
        }


        public static void saveEmailConfig(string URL, string port, string compte, string mdp)
        {
            accesMetier.saveEmailConfig(URL, port, compte, mdp);
        }


        public static void afficherDonneesAdmin(List<Question> questionsJeu, List<Question> questionsOrientation, string[] paramEmail)
        {

        }





        /********************************************************Vers couche metier******************************************************/
        public static void modifQuestion(int IDQuestion, string enonce, string type, string reponse1Enonce, string reponse1Points, string reponse2Enonce, string reponse2Points, string reponse3Enonce, string reponse3Points, string reponse4Enonce, string reponse4Points)
        {
            bool verif = true;
            List<string> listReponse = new List<string>();
            listReponse.Add(reponse1Points);
            listReponse.Add(reponse2Points);
            listReponse.Add(reponse3Points);
            listReponse.Add(reponse4Points);

            foreach (string point in listReponse)
            {
                int num;
                if (int.TryParse(point, out num))
                { }
                else
                {
                    verif = false;
                }
            }
            

            //Si IDQuestion est <0 alors nouvelle question
            if(verif)
            {
                if (IDQuestion < 0)
                {
                    accesMetier.addQuestion(enonce, type, reponse1Enonce, reponse1Points, reponse2Enonce, reponse2Points, reponse3Enonce, reponse3Points, reponse4Enonce, reponse4Points);
                }
                else
                {
                    accesMetier.modifQuestion(IDQuestion, type, enonce, reponse1Enonce, reponse1Points, reponse2Enonce, reponse2Points, reponse3Enonce, reponse3Points, reponse4Enonce, reponse4Points);
                }
            }
            else
            {
                MessageBox.Show("Entrez un nombre pour les points");
            }
        }

        public static void supprQuestion(int ID)
        {
            accesMetier.supprQuestion(ID);
        }



        public static void sendEmail(string mailDestinataire, Filiere metier)
        {
            accesMetier.sendEmail(mailDestinataire, metier);
        }

        public static void sendEmail(string mailDestinataire, string NomExpediteur, string PrenomExpediteur)
        {
            accesMetier.sendEmail(mailDestinataire, NomExpediteur, PrenomExpediteur);
        }

        

    }
}
