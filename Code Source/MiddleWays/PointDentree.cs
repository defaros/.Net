using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Xml;
using System.Xml.Linq;
using Orientation;
using Jeu;
using AidezNous;
using Administration;
using Mail;

namespace PointDentree
{
    class PointDentree
    {
        static SMTP mail = new SMTP();

        // declaration des vars
        static string trameXML;
        static string ipServer = "25.188.161.202";
        static string ip;
        static string genre;
        static string action;
        static string domaine;
        static string traitement; // partie admin

        // Time logs
        static DateTime time = DateTime.Now;             
        static string format = "h:mm:ss";

        public static void Main()
        {
            // declaration socket
            Socket socketServeur;
            byte[] buffer = new byte[2048];

            // parametrage socket
            socketServeur = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socketServeur.Bind(new IPEndPoint(IPAddress.Parse(ipServer), 5000));
            socketServeur.Listen(10);
            
            // Affichage
            Console.BufferHeight = 300;
            Console.WindowHeight = 42;
            Console.BufferWidth = 90;
            Console.WindowWidth = 90;

            Console.Title = "MiddleWays : Dedicated server";
            Console.WriteLine("\n                          888       888                            ");
            Console.WriteLine("                          888   o   888                            ");
            Console.WriteLine("                          888  d8b  888                            ");
            Console.WriteLine("                          888 d888b 888  8888b.  888  888 .d8888b  ");
            Console.WriteLine("                          888d88888b888      88b 888  888 88K      ");
            Console.WriteLine("                          88888P Y88888 .d888888 888  888  Y8888b. ");
            Console.WriteLine("                          8888P   Y8888 888  888 Y88b 888      X88 ");
            Console.WriteLine("                          888P     Y888  Y888888   Y88888  88888P' ");
            Console.WriteLine("                                                      888          ");
            Console.WriteLine("                                                 Y8b d88P          ");
            Console.WriteLine("                                                   Y88P            \n");
            Console.WriteLine("                                    **Dedicated Server**                  ");
            Console.WriteLine("\n              --------------------------------------------------------------\n");
            Console.WriteLine("[" + time.ToString(format) + "] : Le serveur Ways est demarré !");
            Console.WriteLine("\n------\n");
            Console.WriteLine("[" + time.ToString(format) + "] : Ecoute sur IP : " + ipServer + ":5000");
            Console.WriteLine("[" + time.ToString(format) + "] : Ecoute sur Port : 5000");
            

            //mail.mail("lacrampe.florian@gmail.com", "sujet", "sujet"); 
            //mail.setSMTPconfig("port", "7459");

            // A reception, traitement a l'infini et l'au-dela
            while (true)
            {
                Socket socketClient = socketServeur.Accept();
                int count = socketClient.Receive(buffer, 0, 2048, SocketFlags.None); // declaration de la taille du buffer en reception
                trameXML = Encoding.ASCII.GetString(buffer, 50, count);
                //System.Console.WriteLine("\nle client a dit : " + trameXML);
                socketClient.Close();
                // appel a la fonction de lecture de la trame
                LireTrame(trameXML);
                // determination de l'action a faire
                if (genre == "Traitement Client")
                {
                    DeterminerActionClient(); // Action Client
                }
                else if (genre == "Traitement Admin")
                {
                    DeterminerActionAdmin(); // Action Admin
                }
                else
                {
                    Console.WriteLine("[" + time.ToString(format) + "] : Attention aucun traitement lié a ce genre d'exécution");
                }
            }
        }

        /*Fonction determinant les actions a faire a destination de l'Admin*/
        static void DeterminerActionAdmin()
        {
            Admin a = new Admin();

            if (action == "Questions")
            {
                if (domaine == "Orientation")
                {
                    if (traitement == "Ajout")
                    {
                        Console.WriteLine("[" + time.ToString(format) + "] : XML - Ajouter - Question - Orientation - Admin");
                        a.AjouterQuestionOrientation(ip);
                    }
                    else if (traitement == "Modification")
                    {
                        Console.WriteLine("[" + time.ToString(format) + "] : XML - Modifier - Question - Orientation - Admin");
                        a.ModifierQuestionOrientation(ip);
                    }
                    else if (traitement == "Suppression")
                    {
                        Console.WriteLine("[" + time.ToString(format) + "] : XML - Supprimer - Question - Orientation - Admin");
                        a.SupprQuestionOrientation(ip);
                    }
                    else
                    {
                        Console.WriteLine("Attention - Traitement Admin - Questions - Orientation - non defini");
                    }
                }
                else if (domaine == "Jeu")
                {
                    if (traitement == "Ajout")
                    {
                        Console.WriteLine("[" + time.ToString(format) + "] : XML - Ajouter - Question - Jeu - Admin");
                        a.AjouterQuestionJeu(ip);
                    }
                    else if (traitement == "Modification")
                    {
                        Console.WriteLine("[" + time.ToString(format) + "] : XML - Modifier - Question - Jeu - Admin");
                        a.ModifierQuestionJeu(ip);
                    }
                    else if (traitement == "Suppression")
                    {
                        Console.WriteLine("[" + time.ToString(format) + "] : XML - Supprimer - Question - Jeu - Admin");
                        a.SupprQuestionJeu(ip);
                    }
                    else
                    {
                        Console.WriteLine("Attention - Traitement Admin - Questions - Jeu - non defini");
                    }
                }
                else if (domaine == "Aidez Nous")
                {
                    if (traitement == "Ajout")
                    {
                        Console.WriteLine("[" + time.ToString(format) + "] : XML - Ajouter - Question - Aidez Nous - Admin");
                        a.AjouterQuestionAidezNous(ip);
                    }
                    else if (traitement == "Modification")
                    {
                        Console.WriteLine("[" + time.ToString(format) + "] : XML - Modifier - Question - Aidez Nous - Admin");
                        a.ModifierQuestionAidezNous(ip);
                    }
                    else if (traitement == "Suppression")
                    {
                        Console.WriteLine("[" + time.ToString(format) + "] : XML - Supprimer - Question - Aidez Nous - Admin");
                        a.SupprQuestionAidezNous(ip);
                    }
                    else
                    {
                        Console.WriteLine("[" + time.ToString(format) + "] : Attention - Traitement Admin - Questions - Aidez Nous - non defini");
                    }
                }
                else
                {
                    Console.WriteLine("[" + time.ToString(format) + "] : Attention - Traitement Admin - Domaine - non defini");
                }
                

            }
            else if (action == "Users")
            {
                if (traitement == "Ajout")
                {
                    Console.WriteLine("[" + time.ToString(format) + "] : XML - Ajouter - User - Admin");
                    a.AjouterListeUser(ip);
                }
                else if (traitement == "Modification")
                {
                    Console.WriteLine("[" + time.ToString(format) + "] : XML - Modifier - User - Admin");
                    a.ModifierListeUser(ip);
                }
                else if (traitement == "Suppression")
                {
                    Console.WriteLine("[" + time.ToString(format) + "] : XML - Supprimer - User - Admin");
                    a.SupprListeUser(ip);
                }
                else if (traitement == "Affichage")
                {
                    Console.WriteLine("[" + time.ToString(format) + "] : XML - Afficher - User - Admin");
                    a.AfficherListeUser(ip);
                }
                else
                {
                    Console.WriteLine("[" + time.ToString(format) + "] : Attention - Traitement Admin - Users - non defini");
                }
            }
            else if (action == "SMTP")
            {
                if (traitement == "Modification")
                {
                    Console.WriteLine("[" + time.ToString(format) + "] : XML - Modifier - ParamsSMTP - Admin");
                    a.ModifierParamSMTP(ip);
                }

                else if (traitement == "Afficher")
                {
                    Console.WriteLine("[" + time.ToString(format) + "] : XML - Affihcer - ParamsSMTP - Admin");
                    a.AfficherParamSMTP(ip);
                }
                else
                {
                    Console.WriteLine("[" + time.ToString(format) + "] : Attention - Traitement Admin - ParamsSMTP - non defini");
                }
            }
            else
            {
                Console.WriteLine("[" + time.ToString(format) + "] : Attention - Action Admin - non defini");
            }

        }

        /*Fonction determinant les actions a faire a destination du client*/
        static void DeterminerActionClient()
        {
            // selection du domaine
                // selection du type d'action
            if (domaine == "Orientation")
            {
                // declaration dela classe Orienter
                Orienter o = new Orienter();
                if (action == "Afficher Questions")
                {
                    // appel methode AfficherQuestion de la classe Orientation
                    Console.WriteLine("[" + time.ToString(format) + "] : XML - Afficher Questions - Orientation");
                    o.AfficherQuestions(ip);
                }
                else if (action == "Afficher Metier")
                {
                    // appel methode AfficherReponse de la classe Orientation
                    Console.WriteLine("[" + time.ToString(format) + "] : XML - Afficher Metier - Orientation");
                    o.AfficherMetier(ip,trameXML);
                }
                else
                {
                    Console.WriteLine("[" + time.ToString(format) + "] : Attention - Action Client - Orientation - non defini");
                }
            }
            else if (domaine == "Jeu")
            {
                Jouer o = new Jouer();
                if (action == "Afficher Questions")
                {
                    // appel methode AfficherQuestion de la classe Jeu
                    Console.WriteLine("[" + time.ToString(format) + "] : XML - Afficher Questions - Jeu");
                    o.AfficherQuestions(ip);
                }
                else if (action == "Envoyer Score")
                {
                    // appel methode AfficherReponse de la classe Jeu
                    Console.WriteLine("[" + time.ToString(format) + "] : XML - Envoyer Score - Jeu");
                    o.ValidationQuestionsJeu(ip,trameXML);
                }
                else if (action == "Afficher Liste Score")
                {
                    // appel methode AfficherReponse de la classe Jeu
                    Console.WriteLine("[" + time.ToString(format) + "] : XML - Afficher Liste Score - Jeu");
                    o.GetScoreGeneral(ip);
                }
                else if (action == "Retourner Score Final")
                {
                    // appel methode AfficherReponse de la classe Jeu
                    Console.WriteLine("[" + time.ToString(format) + "] : XML - Afficher Score Joueur - Jeu");
                    o.GetScorePlayer(ip, trameXML);
                }
                else
                {
                    Console.WriteLine("[" + time.ToString(format) + "] : Attention - Action Client - Jeu - non defini");
                }
            }
            else if (domaine == "Aidez Nous")
            {
                AidonsNous o = new AidonsNous();
                if (action == "Afficher Questions")
                {
                    // appel methode AfficherQuestion de la classe Aidez Nous
                    Console.WriteLine("[" + time.ToString(format) + "] : XML - Afficher Questions - Aidez Nous");
                    o.AfficherQuestions(ip);
                }
                else if (action == "Enregistrer Stats")
                {
                    // appel methode AfficherReponse de la classe Jeu
                    Console.WriteLine("[" + time.ToString(format) + "] : XML - Enregistrer stats - Aidez Nous");
                    o.ValidationQuestionsAN(trameXML);
                }
                else
                {
                    Console.WriteLine("Attention - Action Client - Aidez Nous - non defini");
                }
            }
            else if (domaine == "Mail")
            {
                SMTP mail = new SMTP();
                if (action == "Envoie Mail")
                {
                    // appel methode AfficherQuestion de la classe Aidez Nous
                    Console.WriteLine("[" + time.ToString(format) + "] : XML - Envoie Mail");
                    mail.sendMail(trameXML);
                }
                else
                {
                    Console.WriteLine("[" + time.ToString(format) + "] : Attention - Action Client - Aidez Nous - non defini");
                }
            }
            else
            {
                Console.WriteLine("[" + time.ToString(format) + "] : Attention - Domaine Client - non defini");
            }

        }

        /*Fonction capable de lire tout type de trame (Client - Admin)*/
        static void LireTrame(string trameXML)
        {
            /*if (trameXML.Substring(0, 12) == "VjXvTyrhn5i8")
            {*/

                System.Console.WriteLine("\nle client a dit : " + trameXML + " \n");

                XmlDocument XMLDoc = new XmlDocument();
                XMLDoc.LoadXml(trameXML);

                // recuperation de "trame"
                XmlNodeList xnList = XMLDoc.SelectNodes("trame");
                foreach (XmlNode xn in xnList)
                {
                    ip = xn["ip"].InnerText;
                    Console.WriteLine("[" + time.ToString(format) + "] : IP Client : {0}", ip);
                }

                // récupération de "genre"
                XmlNodeList xnListGenre = XMLDoc.SelectNodes("trame/genre");
                foreach (XmlNode xn in xnListGenre)
                {
                    genre = xn["type"].InnerText;
                    Console.WriteLine("[" + time.ToString(format) + "] : Genre - Requete : {0}", genre);
                }

                // recuperation de "action"
                XmlNodeList xnListAction = XMLDoc.SelectNodes("trame/action");
                foreach (XmlNode xn in xnListAction)
                {
                    action = xn["type"].InnerText;
                    Console.WriteLine("[" + time.ToString(format) + "] : Type action : {0}", action);
                }

                // recuperation de "domaine"
                XmlNodeList xnListDomaine = XMLDoc.SelectNodes("trame/domaine");
                foreach (XmlNode xn in xnListDomaine)
                {
                    domaine = xn["type"].InnerText;
                    Console.WriteLine("[" + time.ToString(format) + "] : Type domaine : {0}", domaine);
                }

                // recuperation de "traitement"
                XmlNodeList xnListTraitement = XMLDoc.SelectNodes("trame/traitement");
                foreach (XmlNode xn in xnListTraitement)
                {
                    traitement = xn["type"].InnerText;
                    Console.WriteLine("[" + time.ToString(format) + "] : Type domaine : {0}", traitement + "\n");
                }

            /*}
            else
            {
                Console.WriteLine("Mauvais paquet");
            }*/

        }

    }
}