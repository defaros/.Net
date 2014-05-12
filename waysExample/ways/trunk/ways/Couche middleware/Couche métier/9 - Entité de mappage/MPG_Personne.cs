using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ways.Couche_middleware._91___Service_etendu.Composant_accès_aux_données;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;
using System.Collections;
using System.Data;

namespace ways.Couche_middleware.Couche_métier._9___Entité_de_mappage
{
    class MPG_Personne
    {
        private string requete_sql;
        private string requete_sql2;
        private string requete_sql3;
        private Hashtable tab;
        private bool boolParam;
        private MSG msg;

        public MPG_Personne()
        {
            msg = new MSG();
            boolParam = true;
            requete_sql = "nc";
            tab = new Hashtable();
        }

        // REQUETE D'AFFICHAGE
        public MSG m_SELECT()
        {
            this.requete_sql = "SELECT * FROM [db_ways].[tb_personne];";
            this.msg.SetData("sql", requete_sql);
            boolParam = false;
            this.msg.SetData("boolParam", boolParam);
            return this.msg;
        }

        public MSG m_SELECT_ID(MSG msg)
        {
            this.requete_sql = "SELECT (id_personne) FROM [db_ways].[tb_personne] WHERE (nom_personne) = @param1;";
            this.msg.SetData("sql", requete_sql);
            tab.Add("@param1", msg.GetData("nom"));
            this.msg.SetData("boolParam", boolParam);
            this.msg.SetData("parameters", tab);
            return this.msg;
        }

        public MSG m_SELECT_ID_PERSONNE(MSG msg)
        {
            this.requete_sql = "SELECT (id_personne) FROM [db_ways].[tb_personne] WHERE (nom_personne) = @param1 AND (prenom_personne) = @param2;";
            this.msg.SetData("sql", requete_sql);
            tab.Add("@param1", msg.GetData("nom"));
            tab.Add("@param2", msg.GetData("prenom"));
            this.msg.SetData("boolParam", boolParam);
            this.msg.SetData("parameters", tab);
            return this.msg;
        }

        public MSG m_SELECT_by_id(MSG msg)
        {
            this.requete_sql = "SELECT [nom_personne],[score] FROM [db_ways].[tb_personne] WHERE [id_personne] = @param1 ;";
            this.msg.SetData("sql", requete_sql);
            tab.Add("@param1" , msg.GetData("id"));
            this.msg.SetData("boolParam", boolParam);
            this.msg.SetData("parameters", tab);
            return this.msg;
        }

        public MSG m_SELECT_score()
        {
            this.requete_sql = "SELECT (nom_personne),(score) FROM [db_ways].[tb_personne] WHERE (score) IS NOT NULL;";
            this.msg.SetData("sql", requete_sql);
            boolParam = false;
            this.msg.SetData("boolParam", boolParam);
            return this.msg;
        }

        public MSG m_select_personne(MSG msg) // pour l'administrateur, si il veut selectionne une personne en particulier.
        {

           //  "SELECT * FROM tb_personne WHERE "+oMSG.GetData("msg1")+" = @param1 "if(oMSG.GetData("msg2") != null) {;}";"; // CONTINUER LE IF POUR PLUSIEUR CHAMPS

            if (msg.GetData("msg1") != null)
            {
                this.requete_sql = "SELECT * FROM [db_ways].[tb_personne] WHERE [" + msg.GetData("msg1") + "] = @param1 "; // REQUETE AVEC UN ARGUMENT
                tab.Add("@param1", msg.GetData("param1"));
            }
            else
            {
                this.requete_sql += ";";
            }

            if (msg.GetData("msg2") != null)
            {
                this.requete_sql += "AND [" + msg.GetData("msg2") + "] = @param2"; // REQUETE AVEC DEUX ARGUMENTS
                tab.Add("@param2", msg.GetData("param2"));
            }
            else
            {
                this.requete_sql += ";";
            }
            if (msg.GetData("msg3") != null)
            {
                this.requete_sql += "AND [" + msg.GetData("msg3") + "] = @param3"; // REQUETE AVEC TROIS ARGUMENTS
                tab.Add("@param3", msg.GetData("param3"));
            }
            else
            {
                //this.requete_sql += ";";
            }
            msg.SetData("boolParam", true);
            msg.SetData("sql", requete_sql);
            msg.SetData("parameters", tab);
            return msg;

        }

        // REQUETE D'INSERTION
        public MSG m_insert_personne(MSG msg) // Insertion d'un visiteur lors de son premier passage. // !!!!!!!!!! PS : IL MANQUE LA DATE DE NAISSANCE DU VISITEUR (format compliqué) !!!!!!!!!!!!
        {
            // VARIABLE CONTENANT LA REQUETE PREPARER
            this.requete_sql = "INSERT INTO [db_ways].[tb_personne] ([nom_personne], [prenom_personne], [adresse_personne], [email_personne], [telephone_personne],[date_de_naissance_personne]) VALUES (@nom, @prenom, @adresse,@email,@telephone,@date_de_naissance_personne);";

            // REMPLISSAGE ET RECUPERATION DES VARIABLE GRACE AU GETDATA ET REMPLIR DANS LE HASHTABLE TAB
            msg.SetData("sql", requete_sql);
            tab.Add("@nom", msg.GetData("nom"));
            tab.Add("@prenom", msg.GetData("prenom"));
            tab.Add("@adresse", msg.GetData("adresse"));
            tab.Add("@email", msg.GetData("mail"));
            tab.Add("@telephone", msg.GetData("telephone"));
            tab.Add("@date_de_naissance_personne", msg.GetData("date_de_naissance"));
            msg.SetData("parameters", tab);
            msg.SetData("boolParam", boolParam);

            return msg;
        }

        public MSG m_insert_admin(MSG msg) // Insertion d'un admin lors de son premier passage.
        {
            // VARIABLE CONTENANT LA REQUETE PREPARER
            this.requete_sql = "INSERT INTO [db_ways].[tb_personne] ([nom_personne], [mdp]) VALUES (@nom, @mdp);";

            // REMPLISSAGE ET RECUPERATION DES VARIABLE GRACE AU GETDATA ET REMPLIR DANS LE HASHTABLE TAB
            msg.SetData("sql", requete_sql);
            tab.Add("@nom", msg.GetData("log"));
            tab.Add("@mdp", msg.GetData("mdp"));
            msg.SetData("parameters", tab);
            msg.SetData("boolParam", boolParam);
            return msg;
        }
        // REQUETE DE DELETE D'UNE PERSONNE
        public void m_delete_personne(MSG msg) // supprimer une personne suivant son ID
        {
            this.requete_sql = " DELETE * FROM [db_ways].[tb_personne] WHERE ((([db_ways].[tb_personne].[email_personne])= @email_personne ));";

            msg.SetData("sql", requete_sql);

            tab.Add("@email_personne", msg.GetData("email"));
            msg.SetData("parameters", tab);
        }

        public MSG m_mpg_update_personne(MSG msg)
        {
            this.requete_sql = " UPDATE [db_ways].[tb_personne] SET  [nom_personne] = @param1 , [score] = @param2 WHERE [id_personne] = @param3;";

            tab.Add("@param1", msg.GetData("nom"));
            tab.Add("@param2", msg.GetData("score"));
            tab.Add("@param3", msg.GetData("id"));
            msg.SetData("sql", requete_sql);
            msg.SetData("parameters", tab);
            return msg;
        }
    }
}
