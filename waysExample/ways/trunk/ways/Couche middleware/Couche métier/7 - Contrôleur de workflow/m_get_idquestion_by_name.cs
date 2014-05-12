using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ways.Couche_middleware._91___Service_etendu.Composant_accès_aux_données;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;
using ways.Couche_middleware.Couche_métier._9___Entité_de_mappage;

namespace ways.Couche_middleware.Couche_métier._7___Contrôleur_de_workflow
{
    class m_get_idquestion_by_name
    {
        private MPG_Question question;
        private CAD cad;
        private DataSet ds;
        public MSG m_get_id(MSG oMSG)
        {
            ds = new DataSet();
            cad = new CAD();
            question = new MPG_Question();
            oMSG.SetData("param1", oMSG.GetData("question").ToString());
            oMSG.SetData("msg1", "question");
            oMSG = question.m_mpg_select_question_by_param(oMSG);
            oMSG = cad.GetRows(oMSG);
            ds = (DataSet)oMSG.GetData("dataset");
            return oMSG;
        } 
    }
}
