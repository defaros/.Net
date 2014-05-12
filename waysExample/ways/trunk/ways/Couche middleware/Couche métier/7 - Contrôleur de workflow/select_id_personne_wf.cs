using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ways.Couche_middleware._91___Service_etendu.Composant_accès_aux_données;
using ways.Couche_middleware.Couche_métier._9___Entité_de_mappage;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;

namespace ways.Couche_middleware.Couche_métier._7___Contrôleur_de_workflow
{
    class select_id_personne_wf
    {
        #region Variables de classe

        private CAD cad;
        private MPG_Personne mpg_personne;


        #endregion

        public select_id_personne_wf() 
        {
            cad = new CAD();
            mpg_personne = new MPG_Personne();
        }

        public MSG wf_select_id_personne(MSG msg)
        {
            msg = cad.GetRows(mpg_personne.m_SELECT_ID_PERSONNE(msg));

            return msg;
        }
    }
   }
