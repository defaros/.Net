using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace ways.Couche_middleware.Couche_métier._8___Composant_métier
{
    class MailSmtp
    {

        #region Variables de classe

        private MailMessage message;
        private SmtpClient smtp;

        #endregion

        #region Constructeurs

        public MailSmtp()
        {
            message = new MailMessage();
            smtp = new SmtpClient();
        }

        #endregion

        #region Méthode

        public MSG send(MSG oMsg)
        {
            #region mail_remi
            //XML oXml = new XML();
            //oXml.ReadSmtpXml(oMsg);

            //// Crée le message et le remplit des données nécessaires
            //MailMessage message = new MailMessage(
            //   "remi.colnot@viacesi.fr", // expéditeur
            //   "adel.boukelt@viacesi.fr", // destinataire
            //   "Invitation à découvrir l'exia", // sujet
            //   "Vous êtes invités par un ami à découvrir l'école supérieure d'informatique eXia"); // contenu du message

            //// On récupère la config XML du SMTP
            //SmtpClient client = new SmtpClient((string)oMsg.GetData("host"), int.Parse((string)oMsg.GetData("port")));

            ////SmtpClient client = new SmtpClient("smtp.orange.fr", 25);
            ///*NetworkCredential networkSettings = new NetworkCredential();
            //networkSettings.Password = (string) oMsg.GetData("SmtpPwd");
            //networkSettings.UserName = (string)oMsg.GetData("SmtpLogin");*/

            //// Envoie le message
            //try
            //{
            //    client.Send(message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Erreur :  {0}",
            //          ex.ToString());
            //}

            //return oMsg;
            #endregion

            #region mail_vince

            message.To.Add((string)oMsg.GetData("mail"));
            message.Subject = "Mail JPO EXIA";
            message.From = new System.Net.Mail.MailAddress("vincent.rigah@gmail.com");
            if((string)oMsg.GetData("body") == null)
            {
                message.Body = "ici le message du destinataire";
            }
            else{
                message.Body = (string)oMsg.GetData("body");
            }

            smtp.Host = "smtp.orange.fr";
            smtp.Port = 25;
            smtp.Send(message);

            return oMsg;

            #endregion
        }

        #endregion
    }
}
