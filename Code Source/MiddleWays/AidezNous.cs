using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AcessData;
using System.Data.SqlClient;
using System.Xml;
using PointDeSortie;
using System.Data;

namespace AidezNous
{
    class AidonsNous
    {

        static AccessDataDB Query = new AccessDataDB();
        static SortieXML SortieXML = new SortieXML();
        static string IDQuestion, pseudo, id;
        static int scoreJeu;

        public void AfficherQuestions(string ip)
        {
            Console.WriteLine("PLS - Afficher les Questions - Aidez Nous");

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
            typeDomaine.InnerText = "Aidez Nous";
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
            XmlElement idQuestionInRep = doc.CreateElement("idQuestion");
            XmlElement ordre = doc.CreateElement("ordre");
            XmlElement contenuQuestion = doc.CreateElement("contenu");

            XmlElement reponse = doc.CreateElement("reponse");
            XmlElement idReponse = doc.CreateElement("id");
            XmlElement contenuReponse = doc.CreateElement("contenu");

            trame.AppendChild(content); // On affiche ip dans trame

            Query.Open_Query(); // Ouverture de la connexion

            StockageQuery = Query.Query_RETOUR("EXEC AfficherQuestionAiderNous");

            while (StockageQuery.Read())
            {

                // On doit réinstancier les objet pour corriger le problème de porter de variable
                idQuestion = doc.CreateElement("id");
                ordre = doc.CreateElement("ordre");
                contenuQuestion = doc.CreateElement("contenu");
                //

                if (IDQuestion != StockageQuery["ID_AN"].ToString())
                {

                    IDQuestion = StockageQuery["ID_AN"].ToString();

                    question = doc.CreateElement("question");

                    content.AppendChild(question);

                    idQuestion.InnerText = StockageQuery["ID_AN"].ToString();
                    question.AppendChild(idQuestion);

                    contenuQuestion.InnerText = StockageQuery["QUESTION_AN"].ToString();
                    question.AppendChild(contenuQuestion); // On affiche type dans genre

                }

                // On doit réinstancier les objet pour corriger le problème de porter de variable
                reponse = doc.CreateElement("reponse");
                idReponse = doc.CreateElement("id");
                contenuReponse = doc.CreateElement("contenu");
                idQuestionInRep = doc.CreateElement("idQuestion");
                //

                question.AppendChild(reponse); // On affiche question dans reponse

                idQuestionInRep.InnerText = IDQuestion;
                reponse.AppendChild(idQuestionInRep); // On affiche type dans genre

                idReponse.InnerText = StockageQuery["ID_RAN"].ToString();
                reponse.AppendChild(idReponse); // On affiche type dans genre

                contenuReponse.InnerText = StockageQuery["REP_RAN"].ToString();
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

        public void ValidationQuestionsAN(string trameXML)
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

            // recuperation de "traitement"
            xnListContent = XMLDoc.SelectNodes("trame");
            foreach (XmlNode xn in xnListContent)
            {
                // lecture XML
                id = xn["pseudo"].InnerText;
            }

            // recuperation de "traitement"
            xnListContent = XMLDoc.SelectNodes("trame/entree");
            foreach (XmlNode xn in xnListContent)
            {
                // lecture XML
                string id_r = xn["id_r"].InnerText;

                Query.Open_Query(); // Ouverture de la connexion
                //SqlDataReader StockageQuery = Query.Query_StoredProcedure("EXEC SelectBarJeu", "@IDJEU", id_q);

                StockageQueryProcedure = Query.Query_StoredProcedure("AjoutNBRep");
                StockageQueryProcedure.Parameters.Add("@idran", SqlDbType.VarChar).Value = id_r;
                StockageQueryProcedure.ExecuteNonQuery();

                Query.Close_Query();

                Query.Open_Query(); // Ouverture de la connexion

                StockageQueryProcedure = Query.Query_StoredProcedure("AjoutBonus2");
                StockageQueryProcedure.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                ReadStoredProcedure = StockageQueryProcedure.ExecuteReader(); // On l'execute et on le stock dans l'objet SqlDataReader

                Query.Close_Query(); // Ouverture de la connexion
            }

        }
    }
}
