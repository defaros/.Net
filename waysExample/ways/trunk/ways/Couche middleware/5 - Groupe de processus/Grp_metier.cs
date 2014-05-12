using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ways.Couche_middleware._6___Composant_accès_métier;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;

namespace ways.Couche_middleware._5___Groupe_de_processus
{
    class Grp_Metier
    {
        private CAM oCAM;

        public Grp_Metier()
        {
            oCAM = new CAM();
        }
        public MSG selectionner_metier_by_id(MSG msg)
        {
            msg.Invoke = "wf_selectionner_metier.recuperer_metier";
            msg = oCAM.go_to_wf(msg);
            return msg;
        }
    }
}
