using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ways.Couche_middleware._91___Service_etendu.Composant_accès_aux_données;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;
using ways.Couche_middleware.Couche_métier._9___Entité_de_mappage;

namespace ways.Couche_middleware.Couche_métier._7___Contrôleur_de_workflow
{
    class wf_delete_question
    {
        private CAD cad;
        private MPG_Question question;
        private MPG_Reponse rep;
        public MSG delete_by_id(MSG oMSG)
        {

            cad = new CAD();
            question = new MPG_Question();
            rep = new MPG_Reponse();
            
            oMSG = rep.mpg_del_rep_by_id(oMSG);
            oMSG = cad.ActionRows(oMSG);

            oMSG = question.mpg_del_by_id(oMSG);
            oMSG = cad.ActionRows(oMSG);

            return oMSG;
        }
    }
}
