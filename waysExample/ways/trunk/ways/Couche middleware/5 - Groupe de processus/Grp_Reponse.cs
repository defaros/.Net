using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ways.Couche_middleware._6___Composant_accès_métier;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;

namespace ways.Couche_middleware._5___Groupe_de_processus
{
    class Grp_Reponse
    {
        public CAM oCAM;

        public Grp_Reponse()
        {
            oCAM = new CAM();
        }

        public MSG selectionner_reponse_by_idq(MSG msg)
        {
            msg.Invoke = "wf_selectionner_reponse_by_idq.recuperer_reponse_by_idq";
            msg = oCAM.go_to_wf(msg);
            return msg;
        }
    }
}
