using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Encrypt;
using System.IO;

namespace Mail
{
    class SMTP
    {
        static Cryptage crypt = new Cryptage();
        static string value;

        XmlDocument getdocConfig()
        {
            XmlDocument XMLDoc = new XmlDocument();

            StreamReader streamReader = new StreamReader("config.xml");
            string xml = streamReader.ReadToEnd();
            streamReader.Close();


            string xmlreadytoload = crypt.Decrypt(xml, true);
            XMLDoc.Load(xmlreadytoload);

            

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

           /* XmlNodeList node = getdocConfig().SelectNodes("smtp");

            foreach (XmlNode xn in getdocConfig())
            {
                xn[config].InnerText = value;
            }


            getdocConfig().Save("config.xml");*/

            XmlDocument XMLDoc = getdocConfig();
            XmlNode root = XMLDoc.DocumentElement[config];
            root.FirstChild.InnerText = value;

            string xml = XMLDoc.OuterXml;

            crypt.Encrypt(xml, true);

            XMLDoc.Save("config.xml");

        }

        

        public void mail(string mail, string subject, string msg)
        {

            string url = getSMTPconfig("url");
            int port = int.Parse(getSMTPconfig("port"));
            string compte = getSMTPconfig("compte");
            string pass = getSMTPconfig("pass");

            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress("quadearetest@gmail.com");
                message.To.Add(new MailAddress(mail));
                message.Subject = subject;
                message.Body = msg;

                smtp.Port = port;
                smtp.Host = url;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(compte, pass);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
