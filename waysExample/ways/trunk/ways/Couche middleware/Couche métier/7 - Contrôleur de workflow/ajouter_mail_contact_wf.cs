using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;
using ways.Couche_middleware._91___Service_etendu.Composant_accès_aux_données;
using ways.Couche_middleware.Couche_métier._9___Entité_de_mappage;

namespace ways.Couche_middleware.Couche_métier._7___Contrôleur_de_workflow
{
    class ajouter_mail_contact_wf
    {
        #region Variables de classe
        private CAD cad;
        private MPG_Contact mpg_contact;

        #endregion

        public ajouter_mail_contact_wf()
        {
            cad = new CAD();
            mpg_contact = new MPG_Contact();
        }

        #region Méthodes

        public MSG wf_ajouter_mail_contact(MSG msg)
        {
            // instancier la classe de mappage a appeler
            msg = cad.ActionRows(mpg_contact.m_insert_mail_contact(msg));
            msg.Statut = true;
            return msg;
        }

        #endregion

            #region Assesseurs



            #endregion
    }
}
