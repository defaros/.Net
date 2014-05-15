using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ways.Middleware.Service_etendu.Composant_d_acces_aux_donnees
{
    class MailSmtp
    {

        private MailMessage message;
        private SmtpClient smtp;


        public MailSmtp()
        {
            message = new MailMessage();
            smtp = new SmtpClient();
        }

        public static void sendEmail(string mailServer, int port, string login, string password, string mailAdress, string mailToSend, string mailSubject, string mailBody)
        {
            SmtpClient SmtpServer = new SmtpClient(mailServer,port);
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
                MessageBox.Show("ERREUR:\n" + Ex.Message);
            }
        }

    }
}
