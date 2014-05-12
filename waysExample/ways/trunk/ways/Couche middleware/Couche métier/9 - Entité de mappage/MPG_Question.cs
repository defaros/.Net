using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;
using System.Collections;
using ways.Couche_middleware._91___Service_etendu.Composant_accès_aux_données;
using System.Data;

namespace ways.Couche_middleware.Couche_métier._9___Entité_de_mappage
{
    class MPG_Question
    {
        private MSG oMSG;
        private Hashtable h;
        private string rq;
        private String type;
        private bool boolparam;

        public MPG_Question()
        {
            oMSG = new MSG();
            h = new Hashtable();
        }
        public MSG mpg_del_by_id(MSG oMSG)
        {
            this.rq = " DELETE FROM [db_ways].[tb_question] WHERE [id_question] = @id_q;";

            oMSG.SetData("sql", rq);
            h.Add("@id_q", oMSG.GetData("id_question"));

            oMSG.SetData("parameters", h);
            boolparam = true;
            oMSG.SetData("boolParam", boolparam);

            return oMSG;
        }
        //3 arguments : String type / String question / int bareme
        public MSG m_mpg_insert_question(MSG oMSG){

            h = new Hashtable();
            this.rq = "INSERT INTO [db_ways].[tb_question] ([id_type],[question],[q_ouverte]) VALUES (@id_type, @question, @ouv); SELECT @@IDENTITY AS LastId";
            //String rq = "INSERT INTO tb_questions (id_type, type_question, question, bareme_question) VALUES (@id_type, @type_question, @question, @bareme_question);";

            oMSG.SetData("sql", rq);
            h.Add("@ouv", oMSG.GetData("@ouvertefermee"));
            h.Add("@id_type", oMSG.GetData("@type"));
            h.Add("@question", oMSG.GetData("@question"));

            oMSG.SetData("parameters", h);
            boolparam = true;
            oMSG.SetData("boolParam", boolparam);

            return oMSG;
        }
        public MSG m_mpg_select_last_id_question(MSG oMSG)
        {
            h = new Hashtable();
            this.rq = " SELECT MAX ([id_question]) AS LastID FROM [db_ways].[tb_question];";

            oMSG.SetData("sql", rq);
            boolparam = false;
            oMSG.SetData("boolParam", boolparam);
//          h.Add("@id_question", oMSG.GetData("@id_question"));
//          oMSG.SetData("parameters", h);
            return oMSG;
        }

        //Aucun argument attendu
        public MSG m_mpg_select_all_question(){
            String rq = "SELECT * FROM [db_ways].[tb_questions];";
            oMSG.SetData("sql", rq);
            oMSG.SetData("boolParam", true);
            return this.oMSG;
        }

        // UN argument, ou plusieurs paramètres
        public MSG m_mpg_select_question_by_param(MSG oMSG)
        {
       
            if (oMSG.GetData("msg1") != null)
            {
                this.rq = "SELECT * FROM [db_ways].[tb_question] WHERE [" + oMSG.GetData("msg1") + "] = @param1 "; // REQUETE AVEC UN ARGUMENT
                h.Add("@param1", oMSG.GetData("param1"));
            }
            else
            {
                this.rq += ";";
            }
            if (oMSG.GetData("msg2") != null)
            {
                this.rq += "AND " + oMSG.GetData("msg2") + " = @param2"; // REQUETE AVEC DEUX ARGUMENTS
                h.Add("@param2", oMSG.GetData("param2"));
            }
            else
            {
                this.rq += ";";
            }
            if (oMSG.GetData("msg3") != null)
            {
                this.rq += "AND " + oMSG.GetData("msg3") + " = @param3"; // REQUETE AVEC TROIS ARGUMENTS
                h.Add("@param3", oMSG.GetData("param3"));
            }
            else
            {
                this.rq += ";";
            }
            oMSG.SetData("boolParam", true);

            oMSG.SetData("sql", rq);
            oMSG.SetData("parameters", h);
            return oMSG;
        }

        // METHODE POUVANT MODIFIER LA QUESTION, LE BAREME, ETC...
        public MSG m_mpg_update_question(MSG oMSG)
        {
            this.rq = " UPDATE [db_ways].[tb_question] SET " + oMSG.GetData("msg1") + " = @param1 WHERE " + oMSG.GetData("msg2") + " = @param2;";

            h.Add("@param1", oMSG.GetData("param1"));
            h.Add("@param2", oMSG.GetData("param2"));
            oMSG.SetData("sql", rq);
            oMSG.SetData("parameters", h);
            return oMSG;
        }
       
        public void m_delete_question(MSG oMSG) // supprimer une question suivant son ID
        {
            this.rq = " DELETE * FROM [db_ways].[tb_question] WHERE ((([db_ways].[tb_quesstion].[id_question])= @id_question ));";

            oMSG.SetData("sql", rq);

            h.Add("@id_question", oMSG.GetData("id_question"));
            oMSG.SetData("parameters", h);
        }
    }
}
