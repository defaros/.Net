using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Ways.Middleware.Service_etendu.Composant_d_acces_aux_donnees
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
            #region mail_r

            #endregion

            #region mail_e

            message.To.Add((string)oMsg.GetData("mail"));
            message.Subject = "Mail JPO EXIA";
            message.From = new System.Net.Mail.MailAddress("defaros67@gmail.com");
            if ((string)oMsg.GetData("body") == null)
            {
                message.Body = "ici le message du destinataire";
            }
            else
            {
                message.Body = (string)oMsg.GetData("body");
            }

            smtp.Host = "smtp.gmail.com";
            smtp.Port = 25;
            smtp.Send(message);

            return oMsg;

            #endregion
        }

        #endregion
    }
}
