using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;
using ways.Couche_middleware.Couche_métier._9___Entité_de_mappage;
using ways.Couche_middleware._91___Service_etendu.Composant_accès_aux_données;

namespace ways.Couche_middleware.Couche_métier._7___Contrôleur_de_workflow
{
    class select_contact_wf
    {
        #region Variables de classe

        private CAD cad;
        private MPG_Contact mpg_contact;


        #endregion

        public select_contact_wf() 
        {
            cad = new CAD();
            mpg_contact = new MPG_Contact();
        }

        public MSG wf_select_contact(MSG msg)
        {
            msg = cad.GetRows(mpg_contact.m_select_mail(msg));

            return msg;
        }
    }
}
