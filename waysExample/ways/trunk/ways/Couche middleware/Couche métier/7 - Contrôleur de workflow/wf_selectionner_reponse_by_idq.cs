using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;
using ways.Couche_middleware._91___Service_etendu.Composant_accès_aux_données;
using ways.Couche_middleware.Couche_métier._9___Entité_de_mappage;

namespace ways.Couche_middleware.Couche_métier._7___Contrôleur_de_workflow
{
    class wf_selectionner_reponse_by_idq
    {
        private CAD oCAD;
        private MPG_Reponse oMPG;

        public wf_selectionner_reponse_by_idq()
        {
            oCAD = new CAD();
            oMPG = new MPG_Reponse();
        }

        public MSG recuperer_reponse_by_idq(MSG msg)
        {
            msg = oMPG.mpg_select_rep_by_Q(msg);
            msg = oCAD.GetRows(msg);
            return msg;
        }
    }
}
