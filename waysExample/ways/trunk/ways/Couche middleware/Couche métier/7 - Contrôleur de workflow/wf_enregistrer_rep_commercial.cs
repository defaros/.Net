using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ways.Couche_middleware._91___Service_etendu.Composant_accès_aux_données;
using ways.Couche_middleware.Couche_métier._9___Entité_de_mappage;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;

namespace ways.Couche_middleware.Couche_métier._7___Contrôleur_de_workflow
{
    class wf_enregistrer_rep_commercial
    {
        private CAD oCAD;
        private MPG_Reponse_com oMPG;

        public wf_enregistrer_rep_commercial()
        {
            oCAD = new CAD();
            oMPG = new MPG_Reponse_com();
        }
        public MSG ajouter_reponse(MSG msg)
        {
            msg = oMPG.insert_reponse_com(msg);
            msg = oCAD.ActionRows(msg);
            return msg;
        }
    }
}
