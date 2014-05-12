using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Encrypt;
using System.Data.SqlClient;
using AcessData;
using System.Data;
using Jeu;

namespace Mail
{
    class SMTP
    {
        static SqlCommand StockageQueryProcedure;
        static SqlDataReader ReadStoredProcedure;
        static AccessDataDB Query = new AccessDataDB();

        static string value;
        static string mail, nom, prenom, pseudo, id;

        XmlDocument getdocConfig()
        {
            XmlDocument XMLDoc = new XmlDocument();
            XMLDoc.Load("config.xml");

            return XMLDoc;
        }

        public string getSMTPconfig(string config) {

            XmlNodeList xnList = getdocConfig().SelectNodes("smtp");
            foreach (XmlNode xn in xnList)
            {
                value = xn[config].InnerText;
            }
            return value;
        }

        public void setSMTPconfig(string config, string value)
        {
            XmlDocument XMLDoc = getdocConfig();
            XmlNode root = XMLDoc.DocumentElement[config];
            root.FirstChild.InnerText = value; 
            XMLDoc.Save("config.xml");
        }

        

        public void sendMail(string trameXML)
        {

            string url = getSMTPconfig("url");
            int port = int.Parse(getSMTPconfig("port"));
            string compte = getSMTPconfig("compte");
            string pass = getSMTPconfig("pass");

            XmlDocument XMLDoc = new XmlDocument();
            XmlNodeList xnListContent = null;
            XMLDoc.LoadXml(trameXML);

            xnListContent = XMLDoc.SelectNodes("trame/content");
            foreach (XmlNode xn in xnListContent)
            {
                id = xn["id"].InnerText;
                mail = xn["mail"].InnerText;
                nom = xn["nom"].InnerText;
                prenom = xn["prenom"].InnerText;
                pseudo = xn["pseudo"].InnerText;
            }

            //////////////////////////////////////
            // On assigne le bonus 1 lors de l'envoie du mail. Le bonus est fixé dans la procedure stockée
            Jouer jeu = new Jouer();
            jeu.setBonus1(id);
            //////////////////////////////////////

            
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            message.From = new MailAddress("contact@cesi.fr");
            message.To.Add(new MailAddress(mail));
            message.From = new MailAddress("contact@cesi.fr");
            message.IsBodyHtml = true;
            message.Subject = pseudo + " vous recommande l'eXia.CESI, école superieure d'informatique !";
            message.Body = "<html>Bonjour " + nom + ","+"<br /><br />" + pseudo + " vous recommande l'eXia.CESI</html>";

            smtp.Port = port;
            smtp.Host = url;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(compte, pass);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            try
            {
            smtp.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exeption erreur lors de l'envoie du mail: {0}", ex.ToString()); 
            }
        }
    }
}
