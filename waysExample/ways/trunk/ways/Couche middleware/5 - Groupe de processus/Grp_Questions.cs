using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;
using ways.Couche_middleware._6___Composant_accès_métier;

namespace ways.Couche_middleware._5___Groupe_de_processus
{
    class Grp_Questions
    {
        public CAM oCAM;

        public Grp_Questions()
        {
            oCAM = new CAM();
        }
        public MSG selectionner_questions(MSG msg)
        {
            msg.Invoke = "wf_selectionner_question.recuperer_question";
            msg = oCAM.go_to_wf(msg);
            return msg;
        }
        public  MSG get_id_by_name(MSG msg)
        {
            msg.Invoke = "m_get_idquestion_by_name.m_get_id";
            msg = oCAM.go_to_wf(msg);
            return msg;
        }
        public MSG delete_by_id(MSG msg)
        {
            msg.Invoke = "wf_delete_question.delete_by_id";
            msg = oCAM.go_to_wf(msg);
            return msg;
        }
    }
}
