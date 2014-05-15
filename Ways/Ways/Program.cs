using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ways.Client._1.Composant_utilisateurs;
using Ways.Client.Composant_utilisateur_de_communication;
using Ways.Client.Composant_utilisateurs;
using Ways.Middleware.Metier.Mappage;
using Ways.Middleware.Service_etendu.Composant_d_acces_aux_donnees;

namespace Ways
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Création des fichiers XML au démarrage du programme 
            XML oXml = new XML();
            MSG oMsg = new MSG();
            oMsg.SetData("source", "10.67.144.136");
            oMsg.SetData("database", "WAYS");
            oMsg.SetData("login", "Administrateur");
            oMsg.SetData("pwd", "adminways");
            oXml.WriteConfigCrypted(oMsg);

            /*oMsg.SetData("host", @"smtp.orange.fr");
            oMsg.SetData("port", "25");
            oXml.WriteSmtpXml(oMsg);*/
            //oXml.WriteConfigSmtpCrypted(oMsg); 
            ////oMsg = oXml.ReadConfigSmtpDecrypted(oMsg);
            //MailSmtp oMailSmtp = new MailSmtp();
            //oMailSmtp.send(oMsg);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());/*

            


            //Tests pour les forms
            Reponse rep = new Reponse("a",0);
            Reponse rep2 = new Reponse("b",1);

            Reponse[] reps = new Reponse[2];
            reps[0] = rep;
            reps[1] = rep2;


            Question question = new Question(0,"blob", null,reps);
            Question[] quests = new Question[1];
            quests[0] = question;
            List<Question> questions = new List<Question>();
            questions.Add(question);




            //Application.Run(new GameForm(quests, 1));

            //Application.Run(new AdminForm(questions, null, null));

            string s = "Invitation evenement eXia du " + DateTime.Today;

            DateTime thisDate1 = DateTime.Today;
            Console.WriteLine("Today is " + thisDate1.ToString(" dd/MM/yyyy") + ".");
            

            //Application.Run(new AidezNousForm());





            User user1 = new User("Robert", 25, 1);
            User user2 = new User("Jaques", 20, 2);
            User user3 = new User("Michel", 10, 3);

            BindingList<User> list = new BindingList<User>();
            list.Add(user1);
            list.Add(user2);
            list.Add(user3);

            Classement cl = new Classement(list);

            Application.Run(new ClassementForm(cl, user3));

            Mappage.addQuestion("Ceci est un test", "Jeu");*/
        }
    }
}
