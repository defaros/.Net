using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ways.Couche_middleware._91___Service_etendu.Composant_accès_aux_données;
using ways.Couche_middleware.Couche_métier._9___Entité_de_mappage;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;

namespace ways.Couche_middleware.Couche_métier._7___Contrôleur_de_workflow
{
    class Modif_contact_wf
    {
        #region Variables de classe

        private CAD cad;
        private MPG_Contact mpg_contact;


        #endregion

        public Modif_contact_wf() 
        {
            cad = new CAD();
            mpg_contact = new MPG_Contact();
        }

        #region Méthodes

        public MSG wf_modif_contact(MSG msg)
        {
            msg = cad.GetRows(mpg_contact.m_mpg_update_contact(msg));

            return msg;
        }

        #endregion
    }
}
