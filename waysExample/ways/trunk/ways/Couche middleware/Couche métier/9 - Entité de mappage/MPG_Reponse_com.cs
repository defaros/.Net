using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;

namespace ways.Couche_middleware.Couche_métier._9___Entité_de_mappage
{
    class MPG_Reponse_com
    {
        private string requete_sql;
        private Hashtable tab;

        private bool boolparam;
        private String rq;
        public MPG_Reponse_com()
        {
            tab = new Hashtable();
        }

        public MSG insert_reponse_com(MSG oMSG)
        {
            this.rq = "INSERT INTO[db_ways].[tb_reponse_commercial] ([id_question],[id_personne],[reponse]) VALUES (@id_question, @id_personne, @reponse);";

            oMSG.SetData("sql", rq);
            tab.Add("@id_question", oMSG.GetData("id_question"));
            tab.Add("@id_personne", oMSG.GetData("id_personne"));
            tab.Add("@reponse", oMSG.GetData("reponse"));

            oMSG.SetData("parameters", tab);
            boolparam = true;
            oMSG.SetData("boolParam", boolparam);
            return oMSG;

        }
    }
}
