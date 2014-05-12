using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AcessData;
using System.Data.SqlClient;
using PointDeSortie;
using System.Xml;
using System.Data;

namespace Orientation
{
    public class Orienter
    {

        static AccessDataDB Query = new AccessDataDB();
        static SortieXML SortieXML = new SortieXML();
        static string IDQuestion;
        static int[,] ListeIDMetier;
        static int i, y;
        static int maxValue, idmaxValue;
        // data en plus


        public void AfficherQuestions(string ip)
        {
            Console.WriteLine("PLS - Afficher les Questions - Orientation");

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
            typeDomaine.InnerText = "Orientation";
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

            Query.Open_Query(); // ouverture de la connexion

            SqlDataReader StockageQuery = Query.Query_RETOUR("EXEC AfficherQuestionsOr");

            while (StockageQuery.Read())
            {

                // On doit réinstancier les objet pour corriger le problème de porter de variable
                idQuestion = doc.CreateElement("id");
                ordre = doc.CreateElement("ordre");
                contenuQuestion = doc.CreateElement("contenu");
                //

                if (IDQuestion != StockageQuery["ID_ORIENT"].ToString())
                {

                    IDQuestion = StockageQuery["ID_ORIENT"].ToString();

                    question = doc.CreateElement("question");

                    content.AppendChild(question);

                    idQuestion.InnerText = StockageQuery["ID_ORIENT"].ToString();
                    question.AppendChild(idQuestion);

                    contenuQuestion.InnerText = StockageQuery["QUEST_ORIENT"].ToString();
                    question.AppendChild(contenuQuestion); // On affiche type dans genre

                }
                // On doit réinstancier les objet pour corriger le problème de porter de variable
                reponse = doc.CreateElement("reponse");
                idReponse = doc.CreateElement("id");
                contenuReponse = doc.CreateElement("contenu");
                //

                question.AppendChild(reponse); // On affiche question dans reponse

                idReponse.InnerText = StockageQuery["ID_REP_ORIENT"].ToString();
                reponse.AppendChild(idReponse); // On affiche type dans genre

                contenuReponse.InnerText = StockageQuery["RESULT_REP_ORIENT"].ToString();
                reponse.AppendChild(contenuReponse); // On affiche type dans genre

            }

            Query.Close_Query(); // Couper la connexion

            //RETOUR
            string xmlOutput = doc.OuterXml;
            Console.WriteLine(xmlOutput);

            Query.Close_Query(); // Couper la connexion

            byte[] bytesToSend = Encoding.ASCII.GetBytes(xmlOutput); //file
            byte[] send = new byte[bytesToSend.Length + 70];
            bytesToSend.CopyTo(send, 50);

            SortieXML.EnvoieXML(ip, send);
        }

        public void AfficherMetier(string ip, string trameXML)
        {

            // récupération des ID metiers
            Query.Open_Query(); // Ouverture de la connexion
            // On increment le score de chaque metier


            SqlCommand StockageQueryProcedure = Query.Query_StoredProcedure("SelectIdMetier");
            SqlDataReader ReadStoredProcedure = StockageQueryProcedure.ExecuteReader(); // On l'execute et on le stock dans l'objet SqlDataReader


            while (ReadStoredProcedure.Read())
            {
                ListeIDMetier[i, 0] = int.Parse(ReadStoredProcedure["ID_METIER"].ToString());
                i++; 
            }
            Query.Close_Query();

            // lecture de la seconde partie de la trame
            System.Console.WriteLine("\nle client a dit : " + trameXML + " \n");
            XmlDocument XMLDoc = new XmlDocument();
            XMLDoc.LoadXml(trameXML);
            // recuperation de "traitement"
            XmlNodeList xnListContent = XMLDoc.SelectNodes("trame/content/entree");
            foreach (XmlNode xn in xnListContent)
            {
                // lecture XML
                string id_q = xn["id_q"].InnerText;
                string id_r = xn["id_r"].InnerText;

                Query.Open_Query(); // Ouverture de la connexion

                StockageQueryProcedure = Query.Query_StoredProcedure("SelectBarTypeOr");
                StockageQueryProcedure.Parameters.Add("@idRep", SqlDbType.VarChar).Value = id_r;
                ReadStoredProcedure = StockageQueryProcedure.ExecuteReader(); // On l'execute et on le stock dans l'objet SqlDataReader

                

                // lecture a la volé + incrémentation du score
                for (i = 0; i < ListeIDMetier.Length; i++)
                {
                    if (ListeIDMetier[i, 0] == int.Parse(ReadStoredProcedure["ID_METIER"].ToString()))
                    {
                        ListeIDMetier[i, 1] = int.Parse(ReadStoredProcedure["BAREME_ORIENT"].ToString());
                    }
                }
                Query.Close_Query();

            }

            for (i = 0; i < ListeIDMetier.Length; i++)
            {

                if (ListeIDMetier[i, 1] > maxValue)
                {
                    maxValue = ListeIDMetier[i, 1];
                    idmaxValue = i;
                }
            }

            Console.WriteLine(idmaxValue);
        }
        void getTabIndex(string trameXML)
        {


        }
    }
}
