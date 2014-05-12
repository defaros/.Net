using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ways.Couche_middleware._91___Service_etendu.Composant_accès_aux_données;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;

namespace ways.Couche_middleware.Couche_métier._7___Contrôleur_de_workflow
{
    class send_mail_wf
    {
        #region Variables de classe

        private CAD cad;
        private MailSmtp mail;


        #endregion

        public send_mail_wf() 
        {
            cad = new CAD();
            mail = new MailSmtp();
        }

        public MSG wf_send_mail(MSG msg)
        {
            msg = cad.GetRows(mail.send(msg));

            return msg;
        }
    }
}
