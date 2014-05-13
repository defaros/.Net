using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            Reponse rep = new Reponse();
            Reponse rep2 = new Reponse();

            rep.reponse="a";
            rep2.reponse="b";

            Reponse[] reps = new Reponse[2];
            reps[0] = rep;
            reps[1] = rep2;


            Question question = new Question("blob", null,reps);
            Question[] quests = new Question[1];
            quests[0] = question;
            List<Question> questions = new List<Question>();
            questions.Add(question);

            //Application.Run(new GameForm(quests, 1));

            Application.Run(new AdminForm(questions, null, null));
        }
    }
}
