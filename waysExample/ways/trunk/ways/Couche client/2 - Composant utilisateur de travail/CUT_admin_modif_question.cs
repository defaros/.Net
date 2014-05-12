using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ways.Couche_client._3___Composant_utilisateur_de_connexion;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;

namespace ways.Couche_client._2___Composant_utilisateur_de_travail
{
    class CUT_admin_modif_question
    {
        private CUC cuc;

        public MSG m_charger_question (MSG oMSG)
        {

            return oMSG;
        }
        public void m_modif_question(MSG oMSG)
        {
            cuc = new CUC();
            MessageBox.Show("MODIF");
        }

    }
}
