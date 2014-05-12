using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;

namespace ways.Couche_middleware.Couche_métier._9___Entité_de_mappage
{
    class MPG_Reponse
    {
        private string requete_sql;
        private Hashtable tab;

        private bool boolparam;
        private String rq;
        public MPG_Reponse()
        {
            tab = new Hashtable();
        }

        public MSG mpg_del_rep_by_id(MSG oMSG)
        {
            this.rq = "DELETE FROM [db_ways].[tb_reponse] WHERE [id_question] = @id_q;";

            oMSG.SetData("sql", rq);
            tab.Add("@id_q", oMSG.GetData("id_question"));

            oMSG.SetData("parameters", tab);
            boolparam = true;
            oMSG.SetData("boolParam", boolparam);
            return oMSG;

        }
        public MSG mpg_select_rep_by_Q(MSG msg)
        {
            requete_sql = "SELECT * FROM [db_ways].[tb_reponse] WHERE [id_question] = @id_question ;";
            msg.SetData("sql", requete_sql);
            msg.SetData("boolParam", true);
            tab.Add("@id_question", (int)msg.GetData("id_question"));
            msg.SetData("parameters", tab);
            return msg;
        }

        public MSG m_mpg_insert_reponse(MSG oMSG)
        {
            tab = new Hashtable();
            if(oMSG.GetData("@type").ToString() == "1")
            {
                this.requete_sql = "INSERT INTO [db_ways].[tb_reponse] ([id_question],[id_metier],[nom_reponse]) VALUES (@id_question, @id_metier, @nom_reponse);";
                oMSG.SetData("sql", requete_sql);
                tab.Add("@id_metier", oMSG.GetData("bar"));
            }
            else if (oMSG.GetData("@type").ToString() == "3")
            {
                this.requete_sql = "INSERT INTO [db_ways].[tb_reponse] ([id_question],[nom_reponse],[bareme]) VALUES (@id_question, @nom_reponse, @bareme);";
                oMSG.SetData("sql", requete_sql);
                tab.Add("@bareme", oMSG.GetData("bar"));
            }
            else
            {
                this.requete_sql = "INSERT INTO [db_ways].[tb_reponse] ([id_question],[nom_reponse]) VALUES (@id_question, @nom_reponse);";
                oMSG.SetData("sql", requete_sql);
            }

            tab.Add("@id_question", oMSG.GetData("id_question"));
            tab.Add("@nom_reponse", oMSG.GetData("rep"));
            oMSG.SetData("parameters", tab);
            boolparam = true;
            oMSG.SetData("boolParam", boolparam);

            return oMSG;
        }

        public MSG m_mpg_update_reponse(MSG oMSG)
        {
            this.requete_sql = " UPDATE [db_ways].[tb_reponse] SET " + oMSG.GetData("msg1") + " = @param1 WHERE " + oMSG.GetData("msg2") + " = @param2;";

            tab.Add("@param1", oMSG.GetData("param1"));
            tab.Add("@param2", oMSG.GetData("param2"));
            oMSG.SetData("sql", requete_sql);
            oMSG.SetData("parameters", tab);
            return oMSG;
        }
    }
}
