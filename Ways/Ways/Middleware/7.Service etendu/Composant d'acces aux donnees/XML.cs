using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ways.Middleware.Service_etendu.Composant_d_acces_aux_donnees
{
    class XML
    {
        private XDocument document;
        public XML()
        {

        }

        public MSG WriteConfigCrypted(MSG oMsg)
        {
            oMsg.SetData("source", Crypt.Encrypt((string)oMsg.GetData("source")));
            oMsg.SetData("database", Crypt.Encrypt((string)oMsg.GetData("database")));
            oMsg.SetData("login", Crypt.Encrypt((string)oMsg.GetData("login")));
            oMsg.SetData("pwd", Crypt.Encrypt((string)oMsg.GetData("pwd")));

            return WriteXml(oMsg);
        }

        public MSG WriteXml(MSG oMsg)
        {
            try
            {
                document = new XDocument(
                    new XElement("config",
                        new XComment("Chemin réseau du SQL Server"),
                        new XElement("source", new XCData((string)oMsg.GetData("source"))),
                        new XComment("Nom de la base de données"),
                        new XElement("database", new XCData((string)oMsg.GetData("database"))),
                        new XComment("Login utilisateur"),
                        new XElement("login", new XCData((string)oMsg.GetData("login"))),
                        new XComment("Mot de passe"),
                        new XElement("pwd", new XCData((string)oMsg.GetData("pwd")))
                    )
                );

                document.Save(@"C:\Users\RcBh\Desktop\.NET\ConfigSqlServer.xml");
            }
            catch (Exception e)
            {
                MessageBox.Show("ERREUR:\n" + e.Message);
            }

            return oMsg;
        }

        public MSG ReadXml(MSG oMsg)
        {
            try
            {

                // Charge le fichier XML de config
                XDocument document = XDocument.Load(@"C:\Users\RcBh\Desktop\.NET\ConfigSqlServer.xml");

                // Récupère le chemin source du serveur
                string sourceC = "";
                IEnumerable<XElement> source = from s in document.Root.Descendants()
                                               where s.Name == "source"
                                               select s;
                foreach (XElement e in source)
                {
                    // Store the value
                    sourceC = e.Value;
                }

                oMsg.SetData("sourceC", sourceC);

                // Récupère le nom de la BDD
                string databaseC = "";
                IEnumerable<XElement> database = from s in document.Root.Descendants()
                                                 where s.Name == "database"
                                                 select s;
                foreach (XElement e in database)
                {
                    // Store the value
                    databaseC = e.Value;
                }

                oMsg.SetData("databaseC", databaseC);

                // Récupère le login de l'utilisateur
                string loginC = "";
                IEnumerable<XElement> login = from s in document.Root.Descendants()
                                              where s.Name == "login"
                                              select s;
                foreach (XElement e in login)
                {
                    // Store the value
                    loginC = e.Value;
                }

                oMsg.SetData("loginC", loginC);

                // Récupère le mot de passe de l'utilisateur
                string pwdC = "";
                IEnumerable<XElement> pwd = from s in document.Root.Descendants()
                                            where s.Name == "pwd"
                                            select s;
                foreach (XElement e in pwd)
                {
                    // Store the value
                    pwdC = e.Value;
                }

                oMsg.SetData("pwdC", pwdC);

            }
            catch (Exception e)
            {
                MessageBox.Show("ERREUR:\n" + e.Message);
            }

            return oMsg;
        }

        public MSG ReadConfigDecrypted(MSG oMsg)
        {
            oMsg = ReadXml(oMsg);

            oMsg.SetData("source", Crypt.Decrypt((string)oMsg.GetData("sourceC")));
            oMsg.SetData("database", Crypt.Decrypt((string)oMsg.GetData("databaseC")));
            oMsg.SetData("login", Crypt.Decrypt((string)oMsg.GetData("loginC")));
            oMsg.SetData("pwd", Crypt.Decrypt((string)oMsg.GetData("pwdC")));

            return oMsg;
        }


        public MSG WriteConfigSmtpCrypted(MSG oMsg)
        {
            oMsg.SetData("host", Crypt.Encrypt((string)oMsg.GetData("host")));
            oMsg.SetData("port", Crypt.Encrypt((string)oMsg.GetData("port")));


            return WriteSmtpXml(oMsg);
        }

        public MSG WriteSmtpXml(MSG oMsg)
        {
            try
            {
                document = new XDocument(
                    new XElement("config",
                        new XComment("Host"),
                        new XElement("host", new XCData((string)oMsg.GetData("host"))),
                        new XComment("Port"),
                        new XElement("port", new XCData((string)oMsg.GetData("port")))

                    )
                );

                document.Save(@"C:\Users\RcBh\Desktop\.NET\Configsmtp.xml");
            }
            catch (Exception e)
            {
                MessageBox.Show("ERREUR:\n" + e.Message);
            }

            return oMsg;
        }

        public MSG ReadConfigSmtpDecrypted(MSG oMsg)
        {
            oMsg = ReadSmtpXml(oMsg);

            oMsg.SetData("host", Crypt.Decrypt((string)oMsg.GetData("host")));
            oMsg.SetData("port", Crypt.Decrypt((string)oMsg.GetData("port")));

            return oMsg;
        }

        public MSG ReadSmtpXml(MSG oMsg)
        {
            try
            {

                // Charge le fichier XML de config
                XDocument document = XDocument.Load(@"C:\Users\RcBh\Desktop\.NET\Configsmtp.xml");

                // Récupère le chemin source du serveur
                string hostC = "";
                IEnumerable<XElement> host = from s in document.Root.Descendants()
                                             where s.Name == "host"
                                             select s;
                foreach (XElement e in host)
                {
                    // Store the value
                    hostC = e.Value;
                }

                oMsg.SetData("hostC", hostC);

                // Récupère le nom de la BDD
                string portC = "";
                IEnumerable<XElement> port = from s in document.Root.Descendants()
                                             where s.Name == "port"
                                             select s;
                foreach (XElement e in port)
                {
                    // Store the value
                    portC = e.Value;
                }

                oMsg.SetData("portC", portC);

            }
            catch (Exception e)
            {
                MessageBox.Show("ERREUR:\n" + e.Message);
            }

            return oMsg;
        }
    }
}
