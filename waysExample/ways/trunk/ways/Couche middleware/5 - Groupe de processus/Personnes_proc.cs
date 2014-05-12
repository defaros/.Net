using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;
using ways.Couche_middleware.Couche_métier._7___Contrôleur_de_workflow;
using ways.Couche_middleware._6___Composant_accès_métier;

namespace ways.Couche_middleware._5___Groupe_de_processus
{
    class Personnes_proc
    {
        #region Variables de classe

        CAM oCAM;
        #endregion
        
        #region Méthodes
        public Personnes_proc()
        {
            oCAM = new CAM();
        }
        public MSG selectionner_Admin(MSG msg)
        {
            msg.Invoke = "wf_con_admin.con_admin";
            msg = oCAM.go_to_wf(msg);
            return msg;
        }
        public void ajout_info_perso(MSG msg)
            //peut aussi retourner un msg en la rendant de type MSG
        {
            msg.Invoke = "Ajout_info_perso_visiteur_wf.wf_ajout_info_perso_visiteur";

            oCAM.go_to_wf(msg);
        }

        public MSG list_contact(MSG msg)
        {
            msg.Invoke = "list_contact_wf.wf_list_contact";

            msg = oCAM.go_to_wf(msg);

            return msg;
        }
        public MSG list_participant(MSG msg)
        {
            msg.Invoke = "list_participant_wf.wf_list_participant";

            msg = oCAM.go_to_wf(msg);

            return msg;
        }

        public MSG select_id_participant(MSG msg)
        {
            msg.Invoke = "select_id_participant_wf.wf_select_id_participant";

            msg = oCAM.go_to_wf(msg);

            return msg;
        }

        public MSG select_participant_by_id(MSG msg)
        {
            msg.Invoke = "select_participant_by_id_wf.wf_select_participant_by_id";

            msg = oCAM.go_to_wf(msg);

            return msg;
        }

        public MSG select_contact(MSG msg)
        {
            msg.Invoke = "select_contact_wf.wf_select_contact";

            msg = oCAM.go_to_wf(msg);

            return msg;
        }

        public MSG insert_mail_contact(MSG msg)
        {
            msg.Invoke = "ajouter_mail_contact_wf.wf_ajouter_mail_contact";

            msg = oCAM.go_to_wf(msg);

            return msg;
        }

        public void modif_contact(MSG msg)
        //peut aussi retourner un msg en la rendant de type MSG
        {
            msg.Invoke = "Modif_contact_wf.wf_modif_contact";

            oCAM.go_to_wf(msg);
        }

        public void modif_participant(MSG msg)
        //peut aussi retourner un msg en la rendant de type MSG
        {
            msg.Invoke = "Modif_participant_wf.wf_modif_participant";

            oCAM.go_to_wf(msg);
        }

        public MSG select_id_personne(MSG msg)
        //peut aussi retourner un msg en la rendant de type MSG
        {
            msg.Invoke = "select_id_personne_wf.wf_select_id_personne";

            msg = oCAM.go_to_wf(msg);

            return msg;
        }

        public MSG send_mail(MSG msg)
        //peut aussi retourner un msg en la rendant de type MSG
        {
            msg.Invoke = "send_mail_wf.wf_send_mail";

            msg = oCAM.go_to_wf(msg);

            return msg;
        }


        #endregion

        #region Assesseurs



        #endregion
    }
}
