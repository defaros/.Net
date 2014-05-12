using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AcessData;
using System.Data.SqlClient;
using PointDeSortie;
using System.Xml;
using System.Data;

namespace Jeu
{
    public class Jouer
    {
        /////////////////////////////////////////
        //Utilitaires lecture SQL
        static SqlCommand StockageQueryProcedure;
        static SqlDataReader StockageQuery;
        static SqlDataReader ReadStoredProcedure;
        static XmlNodeList xnListContent;
        ////////////////////////////////////////

        static AccessDataDB Query = new AccessDataDB();
        static SortieXML SortieXML = new SortieXML();
        static string IDQuestion, pseudo, id;
        static int scoreJeu;

        // Time logs
        static DateTime time = DateTime.Now;
        static string format = "h:mm:ss";

        public void AfficherQuestions(string ip)
        {
            Console.WriteLine("PLS - Afficher les Questions - Jeu");

            SqlDataReader StockageQuery = null;

            XmlDocument doc = new XmlDocument();// On crée le document xml
            XmlDeclaration indentite = doc.CreateXmlDeclaration("1.0", null, null); // On déclare la version
            doc.AppendChild(indentite); // On affiche son identite
            XmlElement trame = doc.CreateElement("trame"); // On déclare trame
            doc.AppendChild(trame); // On affiche trame
            //Genre
            XmlElement genre = doc.CreateElement("genre"); // On déclare IP
            XmlElement typeGenre = doc.CreateElement("type"); // On déclare type
            typeGenre.InnerText = "Traitement Client";
            trame.AppendChild(genre); // On affiche ip dans trame
            genre.AppendChild(typeGenre); // On affiche type dans genre
            //ACTION
            XmlElement action = doc.CreateElement("action");
            XmlElement typeAction = doc.CreateElement("type");
            typeAction.InnerText = "Afficher reponse";
            trame.AppendChild(action); // On affiche ip dans trame
            action.AppendChild(typeAction); // On affiche type dans genre
            //DOMAINE
            XmlElement domaine = doc.CreateElement("domaine");
            XmlElement typeDomaine = doc.CreateElement("type");
            typeDomaine.InnerText = "Jeu";
            trame.AppendChild(domaine); // On affiche ip dans trame
            domaine.AppendChild(typeDomaine); // On affiche type dans genre
            //TRAITEMENT
            XmlElement traitement = doc.CreateElement("traitement");
            XmlElement typeTraitement = doc.CreateElement("type");
            typeTraitement.InnerText = "NULL";
            trame.AppendChild(traitement); // On affiche ip dans trame
            traitement.AppendChild(typeTraitement); // On affiche type dans genre


            ///////////////////////////////////////
            //CONTENT
            XmlElement content = doc.CreateElement("content");
            XmlElement question = doc.CreateElement("question");
            XmlElement idQuestion = doc.CreateElement("id");
            XmlElement ordre = doc.CreateElement("ordre");
            XmlElement contenuQuestion = doc.CreateElement("contenu");

            XmlElement reponse = doc.CreateElement("reponse");
            XmlElement idReponse = doc.CreateElement("id");
            XmlElement contenuReponse = doc.CreateElement("contenu");

            trame.AppendChild(content); // On affiche ip dans trame

            Query.Open_Query(); // Ouverture de la connexion

            StockageQuery = Query.Query_RETOUR("EXEC AfficherQuestionsJeu");
            
            while (StockageQuery.Read()) {

                // On doit réinstancier les objet pour corriger le problème de porter de variable
                idQuestion = doc.CreateElement("id");
                ordre = doc.CreateElement("ordre");
                contenuQuestion = doc.CreateElement("contenu");
                //
            
                if (IDQuestion != StockageQuery["ID_JEU"].ToString()) {

                    IDQuestion = StockageQuery["ID_JEU"].ToString();

                    question = doc.CreateElement("question");

                    content.AppendChild(question);

                    idQuestion.InnerText = StockageQuery["ID_JEU"].ToString();
                    question.AppendChild(idQuestion);

                    contenuQuestion.InnerText = StockageQuery["QUEST_JEU"].ToString();
                    question.AppendChild(contenuQuestion); // On affiche type dans genre

                }

                    // On doit réinstancier les objet pour corriger le problème de porter de variable
                    reponse = doc.CreateElement("reponse");
                    idReponse = doc.CreateElement("id");
                    contenuReponse = doc.CreateElement("contenu");
                    //

                    question.AppendChild(reponse); // On affiche question dans reponse

                    idReponse.InnerText = StockageQuery["ID_REP_JEU"].ToString();
                    reponse.AppendChild(idReponse); // On affiche type dans genre

                    contenuReponse.InnerText = StockageQuery["RESULT_REP_JEU"].ToString();
                    reponse.AppendChild(contenuReponse); // On affiche type dans genre

            }

            Query.Close_Query(); // Couper la connexion

            //RETOUR
            string xmlOutput = doc.OuterXml;

            Console.WriteLine(xmlOutput);

            byte[] bytesToSend = Encoding.UTF8.GetBytes(xmlOutput); //file
            byte[] send = new byte[bytesToSend.Length + 70];
            bytesToSend.CopyTo(send, 50);

            SortieXML.EnvoieXML(ip, send);
        }

        public void ValidationQuestionsJeu(string ip, string trameXML)
        {
            SqlCommand StockageQueryProcedure = null;
            SqlDataReader ReadStoredProcedure = null;
            XmlNodeList xnListContent = null;

            pseudo = null;
            scoreJeu = 0;

            // lecture de la seconde partie de la trame
            System.Console.WriteLine("\nle client a dit : " + trameXML + " \n");
            XmlDocument XMLDoc = new XmlDocument();
            XMLDoc.LoadXml(trameXML);

            xnListContent = XMLDoc.SelectNodes("trame");
            foreach (XmlNode xn in xnListContent)
            {
                pseudo = xn["pseudo"].InnerText;
            }

            // recuperation de "traitement"
            xnListContent = XMLDoc.SelectNodes("trame/entree");
            foreach (XmlNode xn in xnListContent)
            {
                // lecture XML
                string id_q = xn["id_q"].InnerText;
                string id_r = xn["id_r"].InnerText;

                Query.Open_Query(); // Ouverture de la connexion
                //SqlDataReader StockageQuery = Query.Query_StoredProcedure("EXEC SelectBarJeu", "@IDJEU", id_q);

                StockageQueryProcedure = Query.Query_StoredProcedure("SelectBarJeu");
                StockageQueryProcedure.Parameters.Add("@ID_JEU", SqlDbType.VarChar).Value = id_q;
                ReadStoredProcedure = StockageQueryProcedure.ExecuteReader(); // On l'execute et on le stock dans l'objet SqlDataReader


                

                while (ReadStoredProcedure.Read())
                {
                    if (id_r == ReadStoredProcedure["ID_REP_JEU"].ToString())
                    {
                        scoreJeu = scoreJeu + int.Parse(ReadStoredProcedure["BAREME_JEU"].ToString());
                    }
                }
                Query.Close_Query();
            }

            Query.Open_Query(); // Ouverture de la connexion


            StockageQueryProcedure = Query.Query_StoredProcedure("AjoutPseudo");
            StockageQueryProcedure.Parameters.Add("@pseudo", SqlDbType.VarChar).Value = pseudo;
            StockageQueryProcedure.Parameters.Add("@score", SqlDbType.VarChar).Value = scoreJeu;
            ReadStoredProcedure = StockageQueryProcedure.ExecuteReader(); // On l'execute et on le stock dans l'objet SqlDataReader

            ReadStoredProcedure.Read();

            string idJoueur = ReadStoredProcedure["ID_VISITEUR"].ToString();

            Query.Close_Query(); // fermeture connexion

            Console.WriteLine(scoreJeu);

            XmlDocument doc = new XmlDocument();// On crée le document xml
            XmlDeclaration indentite = doc.CreateXmlDeclaration("1.0", null, null); // On déclare la version
            doc.AppendChild(indentite); // On affiche son identite
            XmlElement trame = doc.CreateElement("trame"); // On déclare trame
            doc.AppendChild(trame); // On affiche trame
            //Genre
            XmlElement genre = doc.CreateElement("genre"); // On déclare IP
            XmlElement typeGenre = doc.CreateElement("type"); // On déclare type
            typeGenre.InnerText = "Traitement Client";
            trame.AppendChild(genre); // On affiche ip dans trame
            genre.AppendChild(typeGenre); // On affiche type dans genre
            //ACTION
            XmlElement action = doc.CreateElement("action");
            XmlElement typeAction = doc.CreateElement("type");
            typeAction.InnerText = "Afficher score joueur";
            trame.AppendChild(action); // On affiche ip dans trame
            action.AppendChild(typeAction); // On affiche type dans genre
            //DOMAINE
            XmlElement domaine = doc.CreateElement("domaine");
            XmlElement typeDomaine = doc.CreateElement("type");
            typeDomaine.InnerText = "Jeu";
            trame.AppendChild(domaine); // On affiche ip dans trame
            domaine.AppendChild(typeDomaine); // On affiche type dans genre
            //TRAITEMENT
            XmlElement traitement = doc.CreateElement("traitement");
            XmlElement typeTraitement = doc.CreateElement("type");
            typeTraitement.InnerText = "NULL";
            trame.AppendChild(traitement); // On affiche ip dans trame
            traitement.AppendChild(typeTraitement); // On affiche type dans genre


            ///////////////////////////////////////
            //CONTENT
            XmlElement content = doc.CreateElement("content");
            XmlElement score = doc.CreateElement("score");
            XmlElement id = doc.CreateElement("id");

            trame.AppendChild(content);

            score.InnerText = scoreJeu.ToString();
            content.AppendChild(score); // On affiche question dans reponse

            id.InnerText = idJoueur;
            content.AppendChild(id); // On affiche question dans reponse

            //RETOUR
            string xmlOutput = doc.OuterXml;

            Console.WriteLine(xmlOutput);

            byte[] bytesToSend = Encoding.ASCII.GetBytes(xmlOutput); //file
            byte[] send = new byte[bytesToSend.Length + 70];
            bytesToSend.CopyTo(send, 50);

            SortieXML.EnvoieXML(ip, send);
        }

        public void GetScoreGeneral(string ip)
        {
            SqlCommand StockageQueryProcedure = null;
            SqlDataReader ReadStoredProcedure = null;
            XmlNodeList xnListContent = null;

            Console.WriteLine("PLS - Afficher les Scores - Jeu");

            XmlDocument doc = new XmlDocument();// On crée le document xml
            XmlDeclaration indentite = doc.CreateXmlDeclaration("1.0", null, null); // On déclare la version
            doc.AppendChild(indentite); // On affiche son identite
            XmlElement trame = doc.CreateElement("trame"); // On déclare trame
            doc.AppendChild(trame); // On affiche trame
            //Genre
            XmlElement genre = doc.CreateElement("genre"); // On déclare IP
            XmlElement typeGenre = doc.CreateElement("type"); // On déclare type
            typeGenre.InnerText = "Traitement Client";
            trame.AppendChild(genre); // On affiche ip dans trame
            genre.AppendChild(typeGenre); // On affiche type dans genre
            //ACTION
            XmlElement action = doc.CreateElement("action");
            XmlElement typeAction = doc.CreateElement("type");
            typeAction.InnerText = "Afficher score";
            trame.AppendChild(action); // On affiche ip dans trame
            action.AppendChild(typeAction); // On affiche type dans genre
            //DOMAINE
            XmlElement domaine = doc.CreateElement("domaine");
            XmlElement typeDomaine = doc.CreateElement("type");
            typeDomaine.InnerText = "Jeu";
            trame.AppendChild(domaine); // On affiche ip dans trame
            domaine.AppendChild(typeDomaine); // On affiche type dans genre
            //TRAITEMENT
            XmlElement traitement = doc.CreateElement("traitement");
            XmlElement typeTraitement = doc.CreateElement("type");
            typeTraitement.InnerText = "NULL";
            trame.AppendChild(traitement); // On affiche ip dans trame
            traitement.AppendChild(typeTraitement); // On affiche type dans genre


            ///////////////////////////////////////
            //CONTENT
            XmlElement content = doc.CreateElement("content");
            XmlElement score = doc.CreateElement("score");
            XmlElement entree = doc.CreateElement("entree");
            XmlElement surnom = doc.CreateElement("pseudo");
            XmlElement points = doc.CreateElement("points");

            trame.AppendChild(content); // On affiche ip dans trame

            Query.Open_Query(); // Couper la connexion


            StockageQueryProcedure = Query.Query_StoredProcedure("AfficherScore");
            ReadStoredProcedure = StockageQueryProcedure.ExecuteReader(); // On l'execute et on le stock dans l'objet SqlDataReader

            content.AppendChild(score); // On affiche question dans reponse

            while (ReadStoredProcedure.Read())
            {

                // On doit réinstancier les objet pour corriger le problème de porter de variable
                entree = doc.CreateElement("entree");
                surnom = doc.CreateElement("pseudo");
                points = doc.CreateElement("points");
                //

                score.AppendChild(entree); // On affiche question dans reponse

                surnom.InnerText = ReadStoredProcedure["SURNOM_VISITEUR"].ToString();
                entree.AppendChild(surnom); // On affiche type dans genre

                points.InnerText = ReadStoredProcedure["SCORE_VISITEUR"].ToString();
                entree.AppendChild(points); // On affiche type dans genre

            }

            Query.Close_Query(); // Couper la connexion

            //RETOUR
            string xmlOutput = doc.OuterXml;

            Console.WriteLine(xmlOutput);

            byte[] bytesToSend = Encoding.UTF8.GetBytes(xmlOutput); //file
            byte[] send = new byte[bytesToSend.Length + 70];
            bytesToSend.CopyTo(send, 50);

            SortieXML.EnvoieXML(ip, send);
        }

        public void GetScorePlayer(string ip, string trameXML)
        {
            SqlCommand StockageQueryProcedure = null;
            SqlDataReader ReadStoredProcedure = null;
            XmlNodeList xnListContent = null;

            Console.WriteLine("PLS - Afficher les Scores - Jeu");

            XmlDocument doc = new XmlDocument();// On crée le document xml
            XmlDeclaration indentite = doc.CreateXmlDeclaration("1.0", null, null); // On déclare la version
            doc.AppendChild(indentite); // On affiche son identite
            XmlElement trame = doc.CreateElement("trame"); // On déclare trame
            doc.AppendChild(trame); // On affiche trame
            //Genre
            XmlElement genre = doc.CreateElement("genre"); // On déclare IP
            XmlElement typeGenre = doc.CreateElement("type"); // On déclare type
            typeGenre.InnerText = "Traitement Client";
            trame.AppendChild(genre); // On affiche ip dans trame
            genre.AppendChild(typeGenre); // On affiche type dans genre
            //ACTION
            XmlElement action = doc.CreateElement("action");
            XmlElement typeAction = doc.CreateElement("type");
            typeAction.InnerText = "Afficher score total joueur";
            trame.AppendChild(action); // On affiche ip dans trame
            action.AppendChild(typeAction); // On affiche type dans genre
            //DOMAINE
            XmlElement domaine = doc.CreateElement("domaine");
            XmlElement typeDomaine = doc.CreateElement("type");
            typeDomaine.InnerText = "Jeu";
            trame.AppendChild(domaine); // On affiche ip dans trame
            domaine.AppendChild(typeDomaine); // On affiche type dans genre
            //TRAITEMENT
            XmlElement traitement = doc.CreateElement("traitement");
            XmlElement typeTraitement = doc.CreateElement("type");
            typeTraitement.InnerText = "NULL";
            trame.AppendChild(traitement); // On affiche ip dans trame
            traitement.AppendChild(typeTraitement); // On affiche type dans genre


            ///////////////////////////////////////
            //CONTENT
            XmlElement content = doc.CreateElement("content");
            XmlElement score = doc.CreateElement("score");
            XmlElement surnom = doc.CreateElement("surnom");
            XmlElement points = doc.CreateElement("points");

            trame.AppendChild(content); // On affiche ip dans trame


            XmlDocument XMLDoc = new XmlDocument();
            xnListContent = null;
            XMLDoc.LoadXml(trameXML);

            xnListContent = XMLDoc.SelectNodes("trame");
            foreach (XmlNode xn in xnListContent)
            {
                id = xn["id_joueur"].InnerText;
            }



            Query.Open_Query(); // Couper la connexion




            StockageQueryProcedure = Query.Query_StoredProcedure("SelectScore");
            StockageQueryProcedure.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            ReadStoredProcedure = StockageQueryProcedure.ExecuteReader(); // On l'execute et on le stock dans l'objet SqlDataReader


            while (ReadStoredProcedure.Read())
            {

                // On doit réinstancier les objet pour corriger le problème de porter de variable
                points = doc.CreateElement("points");
                //

                content.AppendChild(score); // On affiche question dans reponse

                points.InnerText = ReadStoredProcedure["SCORE_VISITEUR"].ToString();
                score.AppendChild(points); // On affiche type dans genre

            }

            Query.Close_Query(); // Couper la connexion

            //RETOUR
            string xmlOutput = doc.OuterXml;

            Console.WriteLine(xmlOutput);

            byte[] bytesToSend = Encoding.UTF8.GetBytes(xmlOutput); //file
            byte[] send = new byte[bytesToSend.Length + 70];
            bytesToSend.CopyTo(send, 50);

            SortieXML.EnvoieXML(ip, send);
        }

        public void setBonus1(string id) {

            Query.Open_Query(); // Ouverture de la connexion

            StockageQueryProcedure = Query.Query_StoredProcedure("AjoutBonus1");
            StockageQueryProcedure.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            ReadStoredProcedure = StockageQueryProcedure.ExecuteReader(); // On l'execute et on le stock dans l'objet SqlDataReader

            Query.Close_Query(); // Ouverture de la connexion

        }

    }
}
