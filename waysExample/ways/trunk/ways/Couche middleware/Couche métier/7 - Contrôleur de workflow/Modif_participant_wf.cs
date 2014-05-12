using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ways.Couche_middleware.Couche_métier._9___Entité_de_mappage;
using ways.Couche_middleware._91___Service_etendu.Composant_accès_aux_données;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;

namespace ways.Couche_middleware.Couche_métier._7___Contrôleur_de_workflow
{
    class Modif_participant_wf
    {
         #region Variables de classe

        private CAD cad;
        private MPG_Personne mpg_participant;


        #endregion

        public Modif_participant_wf() 
        {
            cad = new CAD();
            mpg_participant = new MPG_Personne();
        }

        #region Méthodes

        public MSG wf_modif_participant(MSG msg)
        {
            msg = cad.GetRows(mpg_participant.m_mpg_update_personne(msg));

            return msg;
        }

        #endregion
    }
}
