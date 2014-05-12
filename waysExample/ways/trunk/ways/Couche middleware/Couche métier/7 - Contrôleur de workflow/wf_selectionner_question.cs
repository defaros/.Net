using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;
using ways.Couche_middleware.Couche_métier._9___Entité_de_mappage;
using ways.Couche_middleware._91___Service_etendu.Composant_accès_aux_données;

namespace ways.Couche_middleware.Couche_métier._7___Contrôleur_de_workflow
{
    class wf_selectionner_question
    {
        private MPG_Question oMPG;
        private CAD oCAD;

        public wf_selectionner_question()
        {
            oMPG = new MPG_Question();
            oCAD = new CAD();
        }
        public MSG recuperer_question(MSG msg)
        {
            msg.SetData("msg1", "id_type");
            
            msg = oMPG.m_mpg_select_question_by_param(msg);
            msg = oCAD.GetRows(msg);

            return msg;
        }
    }
}
