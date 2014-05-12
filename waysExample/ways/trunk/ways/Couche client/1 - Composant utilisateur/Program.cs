using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;

namespace ways.Couche_client._1___Composant_utilisateur
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Création des fichiers XML au démarrage du programme 
            XML oXml = new XML();
            MSG oMsg = new MSG();
            oMsg.SetData("source", @"CCQIKXCOIQI\PROJET_SERVERSQL");
            oMsg.SetData("database", "ways");
            oMsg.SetData("login", "Utilisateur");
            oMsg.SetData("pwd", "Azerty");
            oXml.WriteConfigCrypted(oMsg);
            oMsg.SetData("host", @"smtp.orange.fr");
            oMsg.SetData("port", "25");
            oXml.WriteSmtpXml(oMsg);
            //oXml.WriteConfigSmtpCrypted(oMsg); 
            ////oMsg = oXml.ReadConfigSmtpDecrypted(oMsg);
            //MailSmtp oMailSmtp = new MailSmtp();
            //oMailSmtp.send(oMsg);
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new acceuil());
        }
    }
}
