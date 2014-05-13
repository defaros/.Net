using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ways.Client.Composant_utilisateur_de_communication;
using Ways.Client.Composant_utilisateurs;
using Ways.Middleware.Composant_d_acces_metier;

namespace Ways.Client.Composant_de_travail
{
    class TravailClient
    {
        //Exécute les processus liés à l'affichage utilisateur (affichage d'une fenêtre, remplissage d'une liste...), ne nécéssitant pas ou peu de calculs
        //Fait également la liason avec la couche métier

        



        


        //Lance une GameForm en mode orientation
        public static void lancerOrientation()
        {
            //Type 0 = Orientation
            //int type = 0;
            //Question[] questions = getAllQuestionsOfType(type);
            //GameForm GF = new GameForm(questions, type);
            //GF.ShowDialog();

        }


        //Lance une GameForm en mode jeu
        public static void lancerJeu()
        {
            //Type 1 = Jeu
            //int type = 1;
            //Question[] questions = getAllQuestionsOfType(type);
            //GameForm GF = new GameForm(questions, type);
            //GF.ShowDialog();         
        }


        //Lance l'interface Administrateur
        public static void lancerAdmin()
        {
            LoginForm logForm = new LoginForm();
            logForm.ShowDialog();
        }


        //Verifie les informations Administrateurs
        public static void verifAdmin(string identifiant, string password)
        {

        }



        public static int calculerScore(List<Reponse> reps)
        {
            int score = 0;



            return score;
        }

        public static Classement setNewClassement(User newScore)
        {
            return new Classement(null);
        }

        public static void saveEmailConfig(string URL, string port, string compte, string mdp)
        {
            accesMetier.saveEmailConfig(URL, port, compte, mdp);
        }

        public static bool verifSurnom(string name)
        {
            return accesMetier.verifSurnom(name);
        }

        public static bool verifSurnomDoublons(string name)
        {
            return accesMetier.verifSurnomDoublons(name);
        }

        public static bool verifLogin(string identifiant, string psw)
        {
            return accesMetier.verifLogin(identifiant, psw);
        }

        public static void modifQuestionJeu(int IDQuestion, string enonce, string reponse1Enonce, string reponse1Points, string reponse2Enonce, string reponse2Points, string reponse3Enonce, string reponse3Points, string reponse4Enonce, string reponse4Points)
        {
            //Si IDQuestion est <0 alors nouvelle question
            int num;
            if (int.TryParse("string", out num))
            {
                // code si conversion OK
            }
            else
            {
                // code si conversion KO
            }
        }

    }
}
