using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;
using ways.Couche_client._3___Composant_utilisateur_de_connexion;

namespace ways.Couche_client._2___Composant_utilisateur_de_travail
{
    class CUT_profilage
    {
        private CUC oCUC;
        private MSG oMSG;
        public CUT_profilage()
        {
            oCUC = new CUC();
            oMSG = new MSG();
        }
        public MSG ajouter_reponse_com(MSG msg)
        {
            msg.Invoke = "Grp_reponse_commercial.Enregistrer_reponse";
            msg = oCUC.con_ToCS(msg);
            return msg;
        }
    }
}
