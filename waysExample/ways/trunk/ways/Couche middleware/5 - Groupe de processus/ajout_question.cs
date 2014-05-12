using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ways.Couche_middleware._6___Composant_accès_métier;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;

namespace ways.Couche_middleware._5___Groupe_de_processus
{
    class ajout_question
    {
        private CAM cam;
        public void m_ajouter_qr(MSG oMSG)
        {
            cam = new CAM();
            oMSG.Invoke = "m_ajt_question.m_ajt_question_reponse";
            cam.go_to_wf(oMSG);
        }
    }
}
