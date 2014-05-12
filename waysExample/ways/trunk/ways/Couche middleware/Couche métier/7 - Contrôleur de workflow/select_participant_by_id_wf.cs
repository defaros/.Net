using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ways.Couche_middleware._91___Service_etendu.Composant_accès_aux_données;
using ways.Couche_middleware.Couche_métier._9___Entité_de_mappage;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;

namespace ways.Couche_middleware.Couche_métier._7___Contrôleur_de_workflow
{
    class select_participant_by_id_wf
    {
        #region Variables de classe

        private CAD cad;
        private MPG_Personne mpg_personne;


        #endregion

        public select_participant_by_id_wf() 
        {
            cad = new CAD();
            mpg_personne = new MPG_Personne();
        }

        public MSG wf_select_participant_by_id(MSG msg)
        {
            msg = cad.GetRows(mpg_personne.m_SELECT_by_id(msg));

            return msg;
        }
    }
}
