using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;
using System.Collections;

namespace ways.Couche_middleware.Couche_métier._9___Entité_de_mappage
{
    class MPG_Contact
    {
        private string requete_sql;
        private MSG msg ;
        private Hashtable tab;
        private bool boolParam;

        public MPG_Contact() 
        {
            tab = new Hashtable();
            boolParam = true;
            msg = new MSG();
        }

        public MSG m_select()
        {
            this.requete_sql = "SELECT [mail_personne_contact] FROM [db_ways].[tb_contact];";
            this.msg.SetData("sql", requete_sql);
            boolParam = false;
            this.msg.SetData("boolParam", boolParam);
            return this.msg;
        }

        public MSG m_select_mail(MSG msg)
        {
            this.requete_sql = "SELECT [mail_personne_contact] FROM [db_ways].[tb_contact] WHERE [mail_personne_contact] = @param1";
            tab.Add("@param1", msg.GetData("valCell"));
            msg.SetData("sql", requete_sql);
            msg.SetData("boolParam", boolParam);
            msg.SetData("parameters", tab);
            return msg;
        }

        public MSG m_mpg_select_contact(MSG msg)
        {

            if (msg.GetData("msg1") != null)
            {
                this.requete_sql = "SELECT * FROM [db_ways].[tb_contact] WHERE " + msg.GetData("msg1") + " = @param1 "; // REQUETE AVEC UN ARGUMENT
                tab.Add("@param1", msg.GetData("param1"));
            }
            else
            {
                this.requete_sql += ";";
            }
            if (msg.GetData("msg2") != null)
            {
                this.requete_sql += "AND " + msg.GetData("msg2") + " = @param2"; // REQUETE AVEC DEUX ARGUMENTS
                tab.Add("@param2", msg.GetData("param2"));
            }
            else
            {
                this.requete_sql += ";";
            }
            if (msg.GetData("msg3") != null)
            {
                this.requete_sql += "AND " + msg.GetData("msg3") + " = @param3"; // REQUETE AVEC TROIS ARGUMENTS
                tab.Add("@param3", msg.GetData("param3"));
            }
            else
            {
                this.requete_sql += ";";
            }


            msg.SetData("sql", requete_sql);
            boolParam = false;
            msg.SetData("boolParam", boolParam);
            msg.SetData("parameters", tab);
            return msg;
        }

        public MSG m_mpg_update_contact(MSG msg)
        {

            this.requete_sql = " UPDATE [db_ways].[tb_contact] SET [mail_personne_contact] = @param1 WHERE [mail_personne_contact] = @param2;";

            tab.Add("@param1", msg.GetData("mail"));
            tab.Add("@param2", msg.GetData("valAMod"));
            msg.SetData("sql", requete_sql);
            msg.SetData("parameters", tab);
            return msg;
        }

        // REQUETE D'INSERTION
        public MSG m_insert_mail_contact(MSG msg) // Insertion d'un visiteur lors de son premier passage. // !!!!!!!!!! PS : IL MANQUE LA DATE DE NAISSANCE DU VISITEUR (format compliqué) !!!!!!!!!!!!
        {
            // VARIABLE CONTENANT LA REQUETE PREPARER
            this.requete_sql = "INSERT INTO [db_ways].[tb_contact] ([mail_personne_contact])"
                             + " VALUES (@email);";

            // REMPLISSAGE ET RECUPERATION DES VARIABLE GRACE AU GETDATA ET REMPLIR DANS LE HASHTABLE TAB
            msg.SetData("sql", requete_sql);
            tab.Add("@email", msg.GetData("mail"));
            msg.SetData("parameters", tab);
            msg.SetData("boolParam", boolParam);

            return msg;
        }
    }
}
