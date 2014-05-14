using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Ways.Client.Composant_utilisateur_de_communication;

namespace Ways.Middleware.Metier.Composant_technique
{
    class technique
    {
        //Effectue les calculs

        public static void saveEmailConfig(string URL, string port, string compte, string mdp)
        {
            //le truc avec le XML

            //si erreur affichage Message via Composant de communication
        }

        public static void sendEmail(string mailServer, string login, string password, string mailAdress, string mailToSend)
        {


            SmtpClient SmtpServer = new SmtpClient(mailServer);
            SmtpServer.Port = 25;
            SmtpServer.Credentials = new System.Net.NetworkCredential(login, password);
            SmtpServer.EnableSsl = true;

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(mailAdress);
                DateTime dateNow = DateTime.Today;
                mail.Subject = "Invitation evenement eXia du" + dateNow.ToString(" dd MMMM yyyy");
                mail.Body = "";
                mail.To.Add(mailToSend);
                SmtpServer.Send(mail);
            }
            catch (Exception Ex)
            {

            }
        }



        public static int calculScore(List<Reponse> reps)
        {
            int scoreTotal = 0;
            foreach(Reponse rep in reps)
            {
                scoreTotal += rep.points;
            }

            return scoreTotal;
        }



        

    }
}
