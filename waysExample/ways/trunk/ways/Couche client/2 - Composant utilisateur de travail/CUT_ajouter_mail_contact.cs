using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;
using ways.Couche_client._3___Composant_utilisateur_de_connexion;

namespace ways.Couche_client._2___Composant_utilisateur_de_travail
{
    class CUT_ajouter_mail_contact
    {
        #region Variables de classe

        private CUC cuc;

        #endregion

        #region Constructeurs

        public CUT_ajouter_mail_contact()
        {
            cuc = new CUC();
        }

        #endregion

        #region Méthodes

        public MSG ajouter_mail_contact_cut(MSG msg)
        {
            msg.Invoke = "Personnes_proc.insert_mail_contact";

            msg = cuc.con_ToCS(msg);

            return msg;
        }

        #endregion
    }
}
