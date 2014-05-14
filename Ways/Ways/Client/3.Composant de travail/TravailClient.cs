﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ways.Client._1.Composant_utilisateurs;
using Ways.Client.Composant_utilisateur_de_communication;
using Ways.Client.Composant_utilisateurs;
using Ways.Middleware.Composant_d_acces_metier;

namespace Ways.Client.Composant_de_travail
{
    class TravailClient
    {
        //Exécute les processus liés à l'affichage utilisateur (affichage d'une fenêtre, remplissage d'une liste...), ne nécéssitant pas ou peu de calculs
        //Fait également la liason avec la couche métier

        


        /*********************************MainForm**************************************************/
        


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


        public static bool verifSurnom(string name)
        {
            return accesMetier.verifSurnom(name);
        }

        public static bool verifSurnomDoublons(string name)
        {
            return accesMetier.verifSurnomDoublons(name);
        }

        //Verifie les informations Administrateurs
        public static bool verifLogin(string identifiant, string psw)
        {
            return accesMetier.verifLogin(identifiant, psw);
        }





        /***************************GameForm******************************/

        public static void showClassementForm(List<Reponse> reps)
        {
            accesMetier.showClassement(reps);
        }


        public static int calculerScore()
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

        

        public static void modifQuestion(int IDQuestion, string enonce, string reponse1Enonce, string reponse1Points, string reponse2Enonce, string reponse2Points, string reponse3Enonce, string reponse3Points, string reponse4Enonce, string reponse4Points)
        {
            //Si IDQuestion est <0 alors nouvelle question
            int num;
            if (int.TryParse("string", out num))
            {
                if (num < 0)
                {
                    accesMetier.addQuestion(enonce, reponse1Enonce, reponse1Points, reponse2Enonce, reponse2Points, reponse3Enonce, reponse3Points, reponse4Enonce, reponse4Points);
                }
                else
                {
                    accesMetier.modifQuestion(IDQuestion, enonce, reponse1Enonce, reponse1Points, reponse2Enonce, reponse2Points, reponse3Enonce, reponse3Points, reponse4Enonce, reponse4Points);
                }
            }
            else
            {
                // code si conversion KO
            }


        }

        public static void supprQuestion(int IDQuestion)
        {

        }



        /********************************************************AidezNousForm******************************************************/

        public static Reponse showAidezNousForm()
        {
            AidezNousForm AideForm = new AidezNousForm();
            AideForm.ShowDialog();

            return AideForm.reponse;
        }



        /********************************************************EmailForm******************************************************/


        public static Reponse showEmailForm()
        {
            EmailsForm emailForm = new EmailsForm();
            emailForm.ShowDialog();

            return emailForm.rep;
        }




        

    }
}