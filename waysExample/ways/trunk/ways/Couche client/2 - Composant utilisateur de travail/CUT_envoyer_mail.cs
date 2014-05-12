using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ways.Couche_client._3___Composant_utilisateur_de_connexion;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;
using System.Net.Mail;

namespace ways.Couche_client._2___Composant_utilisateur_de_travail
{
    class CUT_envoyer_mail
    {
        #region Variables de classe

        private CUC cuc;
        private MailMessage message;

        #endregion

        #region Constructeurs

        public CUT_envoyer_mail()
        {
            cuc = new CUC();
            message = new MailMessage();
        }

        #endregion

        #region Méthodes

        public MSG envoyer_mail(MSG msg)
        {
            msg.Invoke = "Personnes_proc.send_mail";
            
            msg = cuc.con_ToCS(msg);

            return msg;
        }

        #endregion
    }
   }

    
