using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AcessData;
using System.Data.SqlClient;
using PointDeSortie;

namespace Administration
{
    class Admin
    {
        static AccessDataDB Query = new AccessDataDB();
        static SortieXML SortieXML = new SortieXML();

        /* Fonction d'actions relatives aux Questions */
        public void AjouterQuestionOrientation(string ip)
        {
            Console.WriteLine("PLS - Ajouter Question - Orientation - Admin");

            SqlDataReader StockageQuery = Query.Query_RETOUR("SELECT ID_ADMIN from dbo.ADMINISTRATEUR");

            while (StockageQuery.Read())
            {
                Console.WriteLine(StockageQuery["ID_ADMIN"].ToString());
            }

            Query.Close_Query(); // Couper la connexion

            byte[] bytesToSend = Encoding.ASCII.GetBytes("PLS - Ajouter Question - Orientation - Admin : Recu !"); //file
            byte[] send = new byte[bytesToSend.Length + 50];
            bytesToSend.CopyTo(send, 50);

            SortieXML.EnvoieXML(ip, send);
        }
        public void ModifierQuestionOrientation(string ip)
        {
            Console.WriteLine("PLS - Modifier Question - Orientation - Admin");

            SqlDataReader StockageQuery = Query.Query_RETOUR("SELECT ID_ADMIN from dbo.ADMINISTRATEUR");

            while (StockageQuery.Read())
            {
                Console.WriteLine(StockageQuery["ID_ADMIN"].ToString());
            }

            Query.Close_Query(); // Couper la connexion

            byte[] bytesToSend = Encoding.ASCII.GetBytes("PLS - Modifier Question - Orientation - Admin : Recu !"); //file
            byte[] send = new byte[bytesToSend.Length + 50];
            bytesToSend.CopyTo(send, 50);
            SortieXML.EnvoieXML(ip, send);
        }
        public void SupprQuestionOrientation(string ip)
        {
            Console.WriteLine("PLS - Supprimer Question - Orientation - Admin");

            SqlDataReader StockageQuery = Query.Query_RETOUR("SELECT ID_ADMIN from dbo.ADMINISTRATEUR");

            while (StockageQuery.Read())
            {
                Console.WriteLine(StockageQuery["ID_ADMIN"].ToString());
            }

            Query.Close_Query(); // Couper la connexion

            byte[] bytesToSend = Encoding.ASCII.GetBytes("PLS - Supprimer Question - Orientation - Admin : Recu !"); //file
            byte[] send = new byte[bytesToSend.Length + 50];
            bytesToSend.CopyTo(send, 50);
            SortieXML.EnvoieXML(ip, send);
        }

        public void AjouterQuestionJeu(string ip)
        {
            Console.WriteLine("PLS - Ajouter Question - Jeu - Admin");

            SqlDataReader StockageQuery = Query.Query_RETOUR("SELECT ID_ADMIN from dbo.ADMINISTRATEUR");

            while (StockageQuery.Read())
            {
                Console.WriteLine(StockageQuery["ID_ADMIN"].ToString());
            }

            Query.Close_Query(); // Couper la connexion

            byte[] bytesToSend = Encoding.ASCII.GetBytes("PLS - Ajouter Question - Jeu - Admin : Recu !"); //file
            byte[] send = new byte[bytesToSend.Length + 50];
            bytesToSend.CopyTo(send, 50);
            SortieXML.EnvoieXML(ip, send);
        }
        public void ModifierQuestionJeu(string ip)
        {
            Console.WriteLine("PLS - Modifier Question - Jeu - Admin");

            SqlDataReader StockageQuery = Query.Query_RETOUR("SELECT ID_ADMIN from dbo.ADMINISTRATEUR");

            while (StockageQuery.Read())
            {
                Console.WriteLine(StockageQuery["ID_ADMIN"].ToString());
            }

            Query.Close_Query(); // Couper la connexion

            byte[] bytesToSend = Encoding.ASCII.GetBytes("PLS - Modifier Question - Jeu - Admin : Recu !"); //file
            byte[] send = new byte[bytesToSend.Length + 50];
            bytesToSend.CopyTo(send, 50);
            SortieXML.EnvoieXML(ip, send);
        }
        public void SupprQuestionJeu(string ip)
        {
            Console.WriteLine("PLS - Supprimer Question - Jeu - Admin");

            SqlDataReader StockageQuery = Query.Query_RETOUR("SELECT ID_ADMIN from dbo.ADMINISTRATEUR");

            while (StockageQuery.Read())
            {
                Console.WriteLine(StockageQuery["ID_ADMIN"].ToString());
            }

            Query.Close_Query(); // Couper la connexion

            byte[] bytesToSend = Encoding.ASCII.GetBytes("PLS - Supprimer Question - Jeu - Admin : Recu !"); //file
            byte[] send = new byte[bytesToSend.Length + 50];
            bytesToSend.CopyTo(send, 50);
            SortieXML.EnvoieXML(ip, send);
        }

        public void AjouterQuestionAidezNous(string ip)
        {
            Console.WriteLine("PLS - Ajouter Question - Aidez Nous - Admin");

            SqlDataReader StockageQuery = Query.Query_RETOUR("SELECT ID_ADMIN from dbo.ADMINISTRATEUR");

            while (StockageQuery.Read())
            {
                Console.WriteLine(StockageQuery["ID_ADMIN"].ToString());
            }

            Query.Close_Query(); // Couper la connexion

            byte[] bytesToSend = Encoding.ASCII.GetBytes("PLS - Ajouter Question - Aidez Nous - Admin : Recu !"); //file
            byte[] send = new byte[bytesToSend.Length + 50];
            bytesToSend.CopyTo(send, 50);
            SortieXML.EnvoieXML(ip, send);
        }
        public void ModifierQuestionAidezNous(string ip)
        {
            Console.WriteLine("PLS - Modifier Question - Aidez Nous - Admin");

            SqlDataReader StockageQuery = Query.Query_RETOUR("SELECT ID_ADMIN from dbo.ADMINISTRATEUR");

            while (StockageQuery.Read())
            {
                Console.WriteLine(StockageQuery["ID_ADMIN"].ToString());
            }

            Query.Close_Query(); // Couper la connexion

            byte[] bytesToSend = Encoding.ASCII.GetBytes("PLS - Modifier Question - Aidez Nous - Admin : Recu !"); //file
            byte[] send = new byte[bytesToSend.Length + 50];
            bytesToSend.CopyTo(send, 50);
            SortieXML.EnvoieXML(ip, send);
        }
        public void SupprQuestionAidezNous(string ip)
        {
            Console.WriteLine("PLS - Supprimer Question - Aidez Nous - Admin");

            SqlDataReader StockageQuery = Query.Query_RETOUR("SELECT ID_ADMIN from dbo.ADMINISTRATEUR");

            while (StockageQuery.Read())
            {
                Console.WriteLine(StockageQuery["ID_ADMIN"].ToString());
            }

            Query.Close_Query(); // Couper la connexion

            byte[] bytesToSend = Encoding.ASCII.GetBytes("PLS - Supprimer Question - Aidez Nous - Admin : Recu !"); //file
            byte[] send = new byte[bytesToSend.Length + 50];
            bytesToSend.CopyTo(send, 50);
            SortieXML.EnvoieXML(ip, send);
        }

        /* Fonctions d'action relatives a la Liste de Users */
        public void AjouterListeUser(string ip)
        {
            Console.WriteLine("PLS - Ajouter Liste User - Admin");

            SqlDataReader StockageQuery = Query.Query_RETOUR("SELECT ID_ADMIN from dbo.ADMINISTRATEUR");

            while (StockageQuery.Read())
            {
                Console.WriteLine(StockageQuery["ID_ADMIN"].ToString());
            }

            Query.Close_Query(); // Couper la connexion

            byte[] bytesToSend = Encoding.ASCII.GetBytes("PLS - Ajouter Liste User - Admin : Recu !"); //file
            byte[] send = new byte[bytesToSend.Length + 50];
            bytesToSend.CopyTo(send, 50);
            SortieXML.EnvoieXML(ip, send);
        }
        public void ModifierListeUser(string ip)
        {
            Console.WriteLine("PLS - Modifier Liste User - Admin");

            SqlDataReader StockageQuery = Query.Query_RETOUR("SELECT ID_ADMIN from dbo.ADMINISTRATEUR");

            while (StockageQuery.Read())
            {
                Console.WriteLine(StockageQuery["ID_ADMIN"].ToString());
            }

            Query.Close_Query(); // Couper la connexion

            byte[] bytesToSend = Encoding.ASCII.GetBytes("PLS - Modifier Liste User - Admin : Recu !"); //file
            byte[] send = new byte[bytesToSend.Length + 50];
            bytesToSend.CopyTo(send, 50);
            SortieXML.EnvoieXML(ip, send);
        }
        public void SupprListeUser(string ip)
        {
            Console.WriteLine("PLS - Supprimer Liste User - Admin");

            SqlDataReader StockageQuery = Query.Query_RETOUR("SELECT ID_ADMIN from dbo.ADMINISTRATEUR");

            while (StockageQuery.Read())
            {
                Console.WriteLine(StockageQuery["ID_ADMIN"].ToString());
            }

            Query.Close_Query(); // Couper la connexion

            byte[] bytesToSend = Encoding.ASCII.GetBytes("PLS - Supprimer Liste User - Admin : Recu !"); //file
            byte[] send = new byte[bytesToSend.Length + 50];
            bytesToSend.CopyTo(send, 50);
            SortieXML.EnvoieXML(ip, send);
        }

        /* Fonction relative a la modification des params SMTP */
        public void ModifierParamSMTP(string ip)
        {
            Console.WriteLine("PLS - Modifier Params SMTP - Admin");

            SqlDataReader StockageQuery = Query.Query_RETOUR("SELECT ID_ADMIN from dbo.ADMINISTRATEUR");

            while (StockageQuery.Read())
            {
                Console.WriteLine(StockageQuery["ID_ADMIN"].ToString());
            }

            Query.Close_Query(); // Couper la connexion

            byte[] bytesToSend = Encoding.ASCII.GetBytes("PLS - Modifier Params SMTP - Admin : Recu !"); //file
            byte[] send = new byte[bytesToSend.Length + 50];
            bytesToSend.CopyTo(send, 50);
            SortieXML.EnvoieXML(ip, send);
        }

        /* Fonctions d'affichages liés à l'interface Admin */
        public void AfficherListeUser(string ip)
        {
            Console.WriteLine("PLS - Afficher Liste User - Admin");

            SqlDataReader StockageQuery = Query.Query_RETOUR("SELECT ID_ADMIN from dbo.ADMINISTRATEUR");

            while (StockageQuery.Read())
            {
                Console.WriteLine(StockageQuery["ID_ADMIN"].ToString());
            }

            Query.Close_Query(); // Couper la connexion

            byte[] bytesToSend = Encoding.ASCII.GetBytes("PLS - Afficher Liste User - Admin : Recu !"); //file
            byte[] send = new byte[bytesToSend.Length + 50];
            bytesToSend.CopyTo(send, 50);
            SortieXML.EnvoieXML(ip, send);
        }
        public void AfficherParamSMTP(string ip)
        {
            Console.WriteLine("PLS - Afficher Params SMTP - Admin");

            SqlDataReader StockageQuery = Query.Query_RETOUR("SELECT ID_ADMIN from dbo.ADMINISTRATEUR");

            while (StockageQuery.Read())
            {
                Console.WriteLine(StockageQuery["ID_ADMIN"].ToString());
            }

            Query.Close_Query(); // Couper la connexion

            byte[] bytesToSend = Encoding.ASCII.GetBytes("PLS - Afficher Params SMTP - Admin : Recu !"); //file
            byte[] send = new byte[bytesToSend.Length + 50];
            bytesToSend.CopyTo(send, 50);
            SortieXML.EnvoieXML(ip, send);
        }

    }
}
