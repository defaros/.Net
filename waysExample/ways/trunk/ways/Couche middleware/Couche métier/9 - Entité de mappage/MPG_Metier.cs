using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;

namespace ways.Couche_middleware.Couche_métier._9___Entité_de_mappage
{
    class MPG_Metier
    {
        private string requete_sql;
        private MSG oMSG ;
        private Hashtable tab;

        public MPG_Metier()
        {
            oMSG = new MSG();
            tab = new Hashtable();
        }

        public MSG m_select()
        {
            this.requete_sql = "SELECT * FROM [db_ways].[tb_metier];";
            oMSG.SetData("sql", requete_sql);
            return this.oMSG;
        }

        public MSG m_select_metier(MSG oMSG) // selectionne un metier en particulier.
        {
            if (oMSG.GetData("msg1") != null)
            {
                this.requete_sql = "SELECT * FROM [db_ways].[tb_metier] WHERE " + oMSG.GetData("msg1") + " = @param1 "; // REQUETE AVEC UN ARGUMENT
                tab.Add("@param1", oMSG.GetData("param1"));
            }
            else
            {
                this.requete_sql += ";";
            } 
            if (oMSG.GetData("msg2") != null)
            {
                this.requete_sql += "AND " + oMSG.GetData("msg2") + " = @param2"; // REQUETE AVEC DEUX ARGUMENTS
                tab.Add("@param2", oMSG.GetData("param2"));
            }
            else
            {
                this.requete_sql += ";";
            }
            if (oMSG.GetData("msg3") != null)
            {
                this.requete_sql += "AND " + oMSG.GetData("msg3") + " = @param3"; // REQUETE AVEC TROIS ARGUMENTS
                tab.Add("@param3", oMSG.GetData("param3"));
            }
            else
            {
                this.requete_sql += ";";
            }

            oMSG.SetData("boolParam", true);
            oMSG.SetData("sql", requete_sql);
            oMSG.SetData("parameters", tab);
            return oMSG;
        }

        public MSG m_select_metier_type(MSG oMSG)
        {
            this.requete_sql = "SELECT [nom_metier], [nom_type] FROM [db_ways].[tb_metier], [db_ways].[tb_type] WHERE [db_ways].[tb_metier].[id_type] = [db_ways].[tb_type].[id_type] AND [db_ways].[tb_type].[nom_type] = '@nom_type'"; 
            // LA REQUETE AU DESSUS, SELECTIONNE LES NOMS METIER ET LES NOM TYPE, A CHANGER SI IL FAUT TOUT AFFICHER.         

            oMSG.SetData("sql", requete_sql);
            tab.Add("@nom_type", oMSG.GetData("nom_type"));
            oMSG.SetData("parameters", tab);
            return this.oMSG;
        }

    }


}
