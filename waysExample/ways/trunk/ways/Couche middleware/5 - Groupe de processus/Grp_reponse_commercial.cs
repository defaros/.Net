using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ways.Couche_middleware._6___Composant_accès_métier;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;

namespace ways.Couche_middleware._5___Groupe_de_processus
{
    class Grp_reponse_commercial
    {
        private CAM oCAM;

        public Grp_reponse_commercial()
        {
            oCAM = new CAM();
        }

        public MSG Enregistrer_reponse(MSG msg)
        {
            msg.Invoke = "wf_enregistrer_rep_commercial.ajouter_reponse";
            msg = oCAM.go_to_wf(msg);
            return msg;
        }

    }
}
