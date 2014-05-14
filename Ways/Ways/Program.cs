using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ways.Client._1.Composant_utilisateurs;
using Ways.Client.Composant_utilisateur_de_communication;
using Ways.Client.Composant_utilisateurs;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());

            


            //Tests pour la form question
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
            

            Application.Run(new EmailsForm());
        }
    }
}
