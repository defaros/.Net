using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;
using ways.Couche_middleware.Couche_métier._9___Entité_de_mappage;
using ways.Couche_middleware._91___Service_etendu.Composant_accès_aux_données;

namespace ways.Couche_middleware.Couche_métier._7___Contrôleur_de_workflow
{
    class list_participant_wf
    {
        #region Variables de classe

        private CAD cad;
        private MPG_Personne mpg_personne;

        #endregion

        public list_participant_wf()
        {
            cad = new CAD();
            mpg_personne = new MPG_Personne();
        }

        #region Méthodes

        public MSG wf_list_participant(MSG msg)
        {

            msg = cad.GetRows(mpg_personne.m_SELECT_score());

            return msg;
        }


        #endregion

        #region Assesseurs



        #endregion
    }
}
